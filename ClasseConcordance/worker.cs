using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasseConcordance.Contexts;
using ClasseConcordance.KlasModels;
using ClasseConcordance.StdModels;
using MlkPwgen;

namespace ClasseConcordance
{
    public static class Worker
    {
        public static void MergeClassesCodes(string codeEcoleKlas, string codeEcoleStd)
        {
            using var standardContext = new Eteyelo_system_ecmContext();
            var classes = standardContext.GlobalAffectationLocalClasses
                .Where(x => x.EloCodeEcole == codeEcoleStd)
                .ToList();

            var klasContext = new Klasroom_TestContext();

            var students = new List<InscriptionEleve>();
            foreach (var classe in classes)
            {
                var parcoursList = standardContext.InscriptionParcours.Where(x => x.CodeAffectationLocalClass == classe.CodeAffectationLocalClass && x.EstActif == true)
                        .ToList();

                if (parcoursList.Count is <= 0) continue;

                foreach (var parcours in parcoursList)
                {
                    var student = standardContext.InscriptionEleves.First(x => x.EloCodeEcole == parcours.EloCodeEcole &&
                            x.EloCodeEleve == parcours.EloCodeEleve);
                    if (student is null) continue;
                    students.Add(student);
                }

                var result = MergeOnKlasroom(students, codeEcoleKlas, classe.CodeAffectationLocalClass);
                Console.WriteLine("Nombre d'eleve pusher {0} pour la classe {1}", result, classe.Intitule);
            }
        }

        public static void MergeParent(string codeEcoleKlas, string codeEcoleStd)
        {
            using var standardContext = new Eteyelo_system_ecmContext();
            var parents = standardContext.GlobalParents
                .Where(x => x.CodeEcole == codeEcoleStd && x.Actif == true)
                .Distinct()
                .ToList();
        }

        /// <summary>
        /// Push Standard student on Klasroom.
        /// </summary>
        /// <param name="eleves">list of <see cref="Elefe"/> to push.</param>
        /// <param name="codeEcole">the klasroom school unique identifier.</param>
        /// <param name="codeClasse">The standard class code key corresponding to the klasroom class where to push students.</param>
        /// <returns> the number of student pushed.</returns>
        private static int MergeOnKlasroom(List<InscriptionEleve> eleves, string codeEcole, string codeClasse)
        {
            if (string.IsNullOrWhiteSpace(codeEcole))
            {
                throw new ArgumentException("Cannot migrate because the school of destination code is missing.");
            }

            if (string.IsNullOrWhiteSpace(codeClasse))
            {
                throw new ArgumentException("Cannot migrate because the classe of destination code is missing.");
            }

            var klasContext = new Klasroom_TestContext();

            var activeYear = klasContext.AnneeScolaires.FirstOrDefault(x => x.EstActif == true);
            if (activeYear is null)
            {
                throw new KeyNotFoundException("Cannot continue the operation because there is not active year configured.");
            }

            var klasEleve = new List<Elefe>();
            var klasParcours = new List<Parcour>();
            foreach (var eleve in eleves)
            {
                if (eleve is null) continue;

                klasEleve.Add(new Elefe
                {
                    Code = eleve.EloCodeEleve,
                    Nom = eleve.Nom,
                    Postnom = eleve.Postnom,
                    Prenom = eleve.Prenom,
                    Sexe = eleve.Sexe,
                    DateInscription = (DateTime)eleve.DateInscription,
                    DateNaissance = (DateTime)eleve.DateNaissance,
                    CodeEcole = codeEcole,
                    EstActif = true,
                    LieuNaissance = "",
                    Telephone = ""
                });

                klasParcours.Add(new Parcour
                {
                    Code = GenerateId(),
                    CodeEleve = eleve.EloCodeEleve,
                    CodeAnneeScolaire = activeYear.Code,//get the active school from klasroom
                    DateAffectation = DateTime.Now,
                    CodeClasse = codeClasse,
                    CodeEcole = codeEcole,
                    EstActif = true
                });
            }

            if (klasEleve.Count is <= 0 || klasParcours.Count is <= 0)
            {
                return 0;
            }

            klasContext.Eleves.AddRange(klasEleve);
            klasContext.Parcours.AddRange(klasParcours);
            klasContext.SaveChanges();

            return klasEleve.Count;
        }

        private static string GenerateId() => PasswordGenerator.Generate(30, Sets.Digits);

    }
}
