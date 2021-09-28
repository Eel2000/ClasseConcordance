using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;
using ClasseConcordance.Contexts;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

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
#pragma warning disable CA1416 // Validate platform compatibility
                    Console.Beep(4, 6);
#pragma warning restore CA1416 // Validate platform compatibility
                    Environment.Exit(-1);
                }
                else if (codes.Where(x => x == "" || x == null).Count() is >= 1)
                {
                    Console.WriteLine($"[{DateTime.Now}] : Donnees incorrect , sortie du programme.");
#pragma warning disable CA1416 // Validate platform compatibility
                    Console.Beep(40, 6);
#pragma warning restore CA1416 // Validate platform compatibility
                    Environment.Exit(-1);
                }
                else
                {
                    Console.WriteLine($"[{DateTime.Now}] : Student migration...\n");
                    Worker.MergeClassesCodes(codes[0], codes[1]);
                    Console.WriteLine($"[{DateTime.Now}] : Process finished...");
                    //Console.ReadLine();
                    await Task.Delay(10000);
                    Console.WriteLine($"[{DateTime.Now}] : Parent migration...\n");
                    Worker.MergeParent(codes[0], codes[1]);
                    Console.WriteLine($"[{DateTime.Now}] : Process finished...");
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"[{DateTime.Now}] : Configuration manquante");
                Console.ForegroundColor = ConsoleColor.White;
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

                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");

                var configuration = builder.Build();
                Console.WriteLine($"[{DateTime.Now}] : Initializing configurations...");


                var schools = configuration.GetSection("Schools").Value;
                var standarConnectionString = configuration.GetConnectionString("Standard");
                var klasroomConnectionString = configuration.GetConnectionString("Klasroom");

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

                if (string.IsNullOrWhiteSpace(schools))
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

                return schools;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }

        }
    }
}
