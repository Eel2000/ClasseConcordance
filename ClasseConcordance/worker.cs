using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasseConcordance.Contexts;
using ClasseConcordance.KlasModels;
using ClasseConcordance.StdModels;
using Microsoft.EntityFrameworkCore;
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
                .OrderBy(x => x.Intitule)
                .ToList();

            var klasContext = new Klasroom_TestContext();

            var students = new List<InscriptionEleve>();
            foreach (var classe in classes)
            {
                var parcoursList = standardContext.InscriptionParcours.Where(x => x.CodeAffectationLocalClass == classe.CodeAffectationLocalClass && x.EstActif == true)
                        .ToList();

                if (parcoursList.Count is <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(" aucun parcours pour la classe de {0}", classe.Intitule);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                var correspondanceKlas = klasContext.Classes.FirstOrDefault(x => x.CodeClassStandard == classe.CodeAffectationLocalClass);
                if (correspondanceKlas is null)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("{0} n'a pas de correspondances sur klasroom", classe.Intitule);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

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
            using var klasContext = new Klasroom_TestContext();


            var parents = standardContext.GlobalParents
                .Where(x => x.CodeEcole == codeEcoleStd && x.Actif == true)
                .OrderBy(x => x.Nom)
                .ToList();

            int tutorCounter = 0;
            int eleveParentCounter = 0;
            foreach (var parent in parents)
            {
                if (parent is null)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("parent data is null");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                var eleveParents = standardContext.GlobalEleveParents.Where(x => x.CodeParent == parent.CodeParent).ToList();
                if (eleveParents.Count is <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Aucune correspondance trouvee dans Parent_eleve standard pour {0}", parent.Nom);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                if(IsExistParent(klasContext, parent.CodeParent))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("{0} is already pushed to klasroom", parent.CodeParent);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                try
                {
                    var tutor = new Parent
                    {
                        Code = parent.CodeParent,
                        CodeEcole = codeEcoleKlas,
                        Email = parent.Email,
                        EstActif = true,
                        Adresse = parent.Adresse,
                        Telephone = parent.Telephone,
                        Nom = parent.Nom,
                        Postnom = parent.Postnom,
                        Prenom = parent.Prenom,
                        Sexe = parent.Sexe
                    };

                    klasContext.Parents.Add(tutor);
                    klasContext.SaveChanges();

                    tutorCounter++;

                    foreach (var eleveParent in eleveParents)
                    {
                        var tutorStudent = new ParentsElefe
                        {
                            Code = eleveParent.Code,
                            CodeEcole = codeEcoleKlas,
                            CodeEleve = eleveParent.CodeEleve,
                            CodeParent = eleveParent.CodeParent,
                        };

                        if(IsExistEleveParent(klasContext, eleveParent.Code))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("{0} is already pushed to klasroom.", eleveParent.Code);
                            Console.ForegroundColor = ConsoleColor.White;
                            continue;
                        }

                        klasContext.ParentsEleves.Add(tutorStudent);
                        klasContext.SaveChanges();

                        eleveParentCounter++;
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Nouveau Parent pusher");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                catch (DbUpdateException e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }
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

            int counter = 0;
            foreach (var eleve in eleves)
            {
                if (eleve is null) continue;

                if (IsExistEleve(klasContext, eleve.EloCodeEleve))
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} est deja migrer", eleve.EloCodeEleve);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                try
                {
                    var el = new Elefe
                    {
                        Code = eleve.EloCodeEleve,
                        Nom = eleve.Nom,
                        Postnom = eleve.Postnom,
                        Prenom = eleve.Prenom,
                        Sexe = eleve.Sexe,
                        DateInscription = (DateTime)eleve.DateInscription,
                        DateNaissance = eleve.DateNaissance,
                        CodeEcole = codeEcole,
                        EstActif = true,
                        LieuNaissance = "",
                        Telephone = ""
                    };

                    var parcours = new Parcour
                    {
                        Code = GenerateId(),
                        CodeEleve = eleve.EloCodeEleve,
                        CodeAnneeScolaire = activeYear.Code,//get the active school from klasroom
                        DateAffectation = DateTime.Now,
                        CodeClasse = codeClasse,
                        CodeEcole = codeEcole,
                        EstActif = true
                    };

                    klasContext.Eleves.Add(el);
                    klasContext.Parcours.Add(parcours);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Nouvel etudiant pusher");
                    Console.ForegroundColor = ConsoleColor.White;

                    klasContext.SaveChanges();

                    counter++;
                }
                catch (DbUpdateException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }


            return counter;
        }

        /// <summary>
        /// checks if the student is already pushed to klasroom.
        /// </summary>
        /// <param name="klasContext">the context.</param>
        /// <param name="code">the unique identifier.</param>
        /// <returns><see cref="true"/> if it's exist otherwise <seealso cref="false"/></returns>
        private static bool IsExistEleve(Klasroom_TestContext klasContext, string code)
        {
            var eleve = klasContext.Eleves.FirstOrDefault(x => x.Code == code);
            if (eleve is null)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// checks if the parent is already pushed to klasroom.
        /// </summary>
        /// <param name="klasContext">the context.</param>
        /// <param name="code">the unique identifier.</param>
        /// <returns><see cref="true"/> if it's exist otherwise <seealso cref="false"/></returns>
        private static bool IsExistParent(Klasroom_TestContext klasContext, string code)
        {
            var parcour = klasContext.Parents.FirstOrDefault(x => x.Code == code);
            if (parcour is null)
            {
                return false;
            }

            return true;
        }
        
        /// <summary>
        /// checks if the eleve parent is already pushed to klasroom.
        /// </summary>
        /// <param name="klasContext">the context.</param>
        /// <param name="code">the unique identifier.</param>
        /// <returns><see cref="true"/> if it's exist otherwise <seealso cref="false"/></returns>
        private static bool IsExistEleveParent(Klasroom_TestContext klasContext, string code)
        {
            var parcour = klasContext.ParentsEleves.FirstOrDefault(x => x.Code == code);
            if (parcour is null)
            {
                return false;
            }

            return true;
        }

        private static string GenerateId() => PasswordGenerator.Generate(30, Sets.Digits);

    }
}
