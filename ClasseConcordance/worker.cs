using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ClasseConcordance.Contexts;
using ClasseConcordance.KlasModels;
using ClasseConcordance.StdModels;
using Microsoft.EntityFrameworkCore;
using MlkPwgen;
using Newtonsoft.Json;

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

                if (IsExistParent(klasContext, parent.CodeParent))
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

                        if (IsExistEleveParent(klasContext, eleveParent.Code))
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

            var klasEcole = klasContext.Ecoles.FirstOrDefault(x => x.Code == codeEcole);
            if (klasContext is null)
            {
                throw new KeyNotFoundException($"Cannot find the specified school. please check the given code {codeEcole} and retry.");
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
                    var connectionIDs = GenerateLoginAndPwd(klasEcole.Domaine, klasContext);
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
                        Telephone = "",
                        CodePwd = connectionIDs.pwd,
                        CodeAuth = connectionIDs.user
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
                    klasContext.SaveChanges();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Nouvel etudiant pusher");
                    Console.ForegroundColor = ConsoleColor.White;


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

        /// <summary>
        /// Return the login info for the newly pushed student.
        /// </summary>
        /// <param name="klasEcoleDomain">the Ecole domaine.</param>
        /// <param name="context">the db context access.(DOA)</param>
        /// <returns><see cref="Tuple{T1, T2}"/> the login information.</returns>
        private static (string user, string pwd) GenerateLoginAndPwd(string klasEcoleDomain, Klasroom_TestContext context)
        {

            Elefe studentWithSameIds = null;
            string username, password;

            do
            {
                username = $"student{GenerateId(4)}@{klasEcoleDomain}";
                password = $"{GenerateId(1, Sets.Alphanumerics)}{GenerateId(3)}";

                studentWithSameIds = context.Eleves.FirstOrDefault(x => x.CodeAuth == username && x.CodePwd == password);

            } while (studentWithSameIds is not null || string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password));


            return (user: username, pwd: password);
        }

        /// <summary>
        /// Send message with the student's login info to the parents.
        /// </summary>
        /// <param name="KlasEcoleCode">The klasroom school unique identifier.</param>
        public static async void SendLoginInfoByclasse(string KlasEcoleCode)
        {
            var klasContext = new Klasroom_TestContext();

            var classes = klasContext.Classes.Where(x => x.CodeEcole == KlasEcoleCode).ToList();
            foreach (var classe in classes)
            {
                var data = new
                {
                    CodeClasse = classe.Code,
                    CodeEcole = classe.CodeEcole
                };

                PostAsync(data);
                await Task.Delay(5);
            }
        }

        private static string GenerateId() => PasswordGenerator.Generate(30, Sets.Digits);
        private static string GenerateId(int length) => PasswordGenerator.Generate(length, Sets.Digits);
        private static string GenerateId(int length, string type = Sets.Alphanumerics) => PasswordGenerator.Generate(length, type);

        /// <summary>
        /// Configure the HttpClient object to prepare for making request.
        /// </summary>
        /// <returns><see cref="HttpClient"/> the configured httpClient.</returns>
        private static HttpClient ConfigureHttp()
        {
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (s, c, t, d) => true;

            var httpClient = new HttpClient(handler);
            httpClient.BaseAddress = new Uri(string.Format("https://napoche-apis.eteyelo.com/Sms/send-login-info", string.Empty));
            httpClient.Timeout = TimeSpan.FromSeconds(20);

            return httpClient;
        }

        /// <summary>
        /// Send the request to the server throught httpPost method.
        /// </summary>
        /// <typeparam name="T">any data to send.</typeparam>
        /// <param name="data">the data to send</param>
        private static async void PostAsync<T>(T data)
        {
            var client = ConfigureHttp();
            var serializedData = JsonConvert.SerializeObject(data);
            var content = new StringContent(serializedData, Encoding.UTF8, "application/json");
            try
            {
                var httpRequest = await client.PostAsync(client.BaseAddress, content);
                if (httpRequest.IsSuccessStatusCode)
                {
                    var result = await httpRequest.Content.ReadAsStringAsync();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("The result of the sending request is {0}", result);
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Diagnostics.Debug.Assert(false);
                }
                else if (httpRequest.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    var result = await httpRequest.Content.ReadAsStringAsync();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("The result of the sending request is {0}\n the result is {1}", httpRequest.ReasonPhrase, result);
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
