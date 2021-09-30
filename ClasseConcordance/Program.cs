using System;
using System.IO;
using System.Linq;
using System.Collections;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using ClasseConcordance.Contexts;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ClasseConcordance
{
    class Program
    {
        static async Task Main(string[] args)
        {


            var code = await Configure();

            Console.WriteLine($"[{ DateTime.Now}] :  Migration des données vers klasroom.");
            await Task.Delay(5000);
            //var key = Console.ReadKey();


            try
            {
                //Console.WriteLine("Veuillez entrez les codeEcoles (1)klasroom et (2)standard separer par un point-virgule. veuillez respecter l'ordre de saisi svp.");
                var codes = code?.Split(';');
                if (codes?.Count() is <= 0)
                {
                    Console.WriteLine($"[{DateTime.Now}] : Donnees incorrect , sortie du programme.");
#pragma warning disable CA1416 // Validate platform compatibility
                    Console.Beep(4, 6);
                    Console.ReadLine();
#pragma warning restore CA1416 // Validate platform compatibility
                    Environment.Exit(-1);
                }
                else if (codes.Where(x => x == "" || x == null).Count() is >= 1)
                {
                    Console.WriteLine($"[{DateTime.Now}] : Donnees incorrect , sortie du programme.");
#pragma warning disable CA1416 // Validate platform compatibility
                    Console.Beep(40, 6);
#pragma warning restore CA1416 // Validate platform compatibility
                    Console.ReadLine();
                    Environment.Exit(-1);
                }
                else
                {
                    Console.WriteLine($"[{DateTime.Now}] : Student migration...\n");
                   await Worker.MergeClassesCodes(codes[0], codes[1]);
                    Console.WriteLine($"[{DateTime.Now}] : Process finished...");
                    //Console.ReadLine();
                    await Task.Delay(10000);
                    Console.WriteLine($"[{DateTime.Now}] : Parent migration...\n");
                    await Worker.MergeParent(codes[0], codes[1]);
                    Console.WriteLine($"[{DateTime.Now}] : Process finished...");

                    await Task.Delay(1000);
                    Console.WriteLine($"[{DateTime.Now}] : finalisation...\n");
                    await Worker.CreateKlasUserForNewStudent();
                    Console.WriteLine($"[{DateTime.Now}] : Process finished...");

                    Console.WriteLine("Closing...");
                    await Task.Delay(1000);
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"[{DateTime.Now}] : Configuration manquante");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Appuyez sur une touche pour quitter.");
                Console.ReadLine();
                Environment.Exit(-1);
            }

        }

        ///<summary>
        ///configure contexts connections strings for querying database.
        /// And also get the schools codes configured.
        ///</summary>
        ///<returns>The schools codes.</returns>
        private static async Task<string> Configure()
        {
            try
            {
                Console.WriteLine($"[{DateTime.Now}] : Starting Application....");

                await Task.Delay(5000);
                JObject configfile = null;
                var path = AppDomain.CurrentDomain.BaseDirectory + "appsettings.json";
                var isExistFile = File.Exists(path);
                if (isExistFile)
                {
                    configfile = JObject.Parse(File.ReadAllText(path));
                }
                else
                {
                    var fileDefaultContent = new
                    {
                        ConnectionStrings = new
                        {
                            Standard = "<PUT_STANDARD_CONNECTION_STRING_HERE>",
                            Klasroom = "<PUT_KLASROOM_CONNECTION_STRING_HERE>"
                        },
                        Schools = "<PUT_SCHOOLS_IDs>"
                    };

                    File.WriteAllText(path, JsonConvert.SerializeObject(fileDefaultContent));
                }

                //var builder = new ConfigurationBuilder()
                //    .SetBasePath(Directory.GetCurrentDirectory())
                //    .AddJsonFile("appsettings.json");

                // var dir = Directory.GetFiles($"{AppDomain.CurrentDomain.BaseDirectory}appsettings")


                //var configuration = builder.Build();
                Console.WriteLine($"[{DateTime.Now}] : Initializing configurations...");

                if (configfile is null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Failed to initializing configurations...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(-5);
                }


                var schools = configfile.SelectToken("Schools");
                var standarConnectionString = configfile.SelectToken("ConnectionStrings").Value<string>("Standard");
                var klasroomConnectionString = configfile.SelectToken("ConnectionStrings").Value<string>("Klasroom");

                await Task.Delay(5000);

                if (string.IsNullOrWhiteSpace(standarConnectionString))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"[{DateTime.Now}] : Configuration manquante");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(-1);
                }

                if (string.IsNullOrWhiteSpace(klasroomConnectionString))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"[{DateTime.Now}] : Configuration manquante");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(-1);
                }

                if (string.IsNullOrWhiteSpace(((string)schools)))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"[{DateTime.Now}] : Configuration manquante");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(-1);
                }

                var stdContextBuilder = new DbContextOptionsBuilder<Eteyelo_system_ecmContext>().UseSqlServer(standarConnectionString);
                var klasroomContextBuilder = new DbContextOptionsBuilder<Klasroom_TestContext>().UseSqlServer(klasroomConnectionString);

                ///Builder configuration
                Constants.stdConfigBuild = stdContextBuilder;
                Constants.klasConfingBuilder = klasroomContextBuilder;

                Console.WriteLine($"[{DateTime.Now}] : Initialization of configurations finished...");

                return ((string)schools);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }

        }
    }
}
