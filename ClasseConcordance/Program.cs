﻿using System;
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
        static void Main(string[] args)
        {

            var code = Configure();


            Console.WriteLine("S => Migration des données vers klasroom.");
            var key = Console.ReadKey();


            //Console.WriteLine("Veuillez entrez les codeEcoles (1)klasroom et (2)standard separer par un point-virgule. veuillez respecter l'ordre de saisi svp.");
            var codes = code.Split(';');
            if (codes.Count() is <= 0)
            {
#pragma warning disable CA1416 // Validate platform compatibility
                Console.Beep(4, 6);
#pragma warning restore CA1416 // Validate platform compatibility
                Environment.Exit(-1);
            }
            else if (codes.Where(x => x == "" || x == null).Count() is >= 1)
            {
                Console.WriteLine("Donnees incorrect , sortie du programme.");
#pragma warning disable CA1416 // Validate platform compatibility
                Console.Beep(40, 6);
#pragma warning restore CA1416 // Validate platform compatibility
                Environment.Exit(-1);
            }
            else
            {
                Console.WriteLine("\nStudent migration...\n");
                Worker.MergeClassesCodes(codes[0], codes[1]);
                Console.WriteLine("Process finished...");
                //Console.ReadLine();
                Task.Delay(10000);
                Console.WriteLine("\nParent migration...\n");
                Worker.MergeParent(codes[0], codes[1]);
                Console.WriteLine("Process finished...");
                Console.ReadLine();
            }

        }

        ///<summary>
        ///configure contexts connections strings for querying database.
        /// And also get the schools codes configured.
        ///</summary>
        ///<returns>The schools codes.</returns>
        private static string Configure()
        {
            Console.WriteLine("Starting Application....");
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            Console.WriteLine("Initializing configurations...");


            var schools = configuration.GetSection("Schools").Value;
            var standarConnectionString = configuration.GetConnectionString("Standard");
            var klasroomConnectionString = configuration.GetConnectionString("Klasroom");

            if (string.IsNullOrWhiteSpace(standarConnectionString))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Configuration manquante");
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(-1);
            }

            if (string.IsNullOrWhiteSpace(klasroomConnectionString))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Configuration manquante");
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(-1);
            }

            if (string.IsNullOrWhiteSpace(schools))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Configuration manquante");
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(-1);
            }

            var stdContextBuilder = new DbContextOptionsBuilder<Eteyelo_system_ecmContext>().UseSqlServer(standarConnectionString);
            var klasroomContextBuilder = new DbContextOptionsBuilder<Klasroom_TestContext>().UseSqlServer(klasroomConnectionString);

            ///Builder configuration
            Constants.stdConfigBuild = stdContextBuilder;
            Constants.klasConfingBuilder = klasroomContextBuilder;

            Console.WriteLine("Initialization of configurations finished...");

            return schools;
        }
    }
}
