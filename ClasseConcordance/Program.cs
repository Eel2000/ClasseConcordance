using ClasseConcordance.Contexts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClasseConcordance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Appuyez sur ENTRER pour continuer");
            var entrerKey = Console.ReadKey(true);
            do
            {
                Console.WriteLine("S => Migration des eleves vers klasroom.");
                Console.WriteLine("P => Migration des parent vers klasroom.");
                Console.WriteLine("A => Envoi des SMS aux élèves nouvellement migrer.");
                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.S)
                {
                    //var con = new Concetrator();
                    //var classes = con.GetClassConcordances("28963294960535598040566165793", "28963294960535598040566165793");
                    //var zippedClasses = classes.klasClass.Zip(classes.stClass, (first, second) => $"{first}       {second}");
                    //foreach (var item in zippedClasses)
                    //{
                    //    Console.WriteLine("{0}", item);
                    //}

                    Console.WriteLine("\nStudent migration...\n");
                    Worker.MergeClassesCodes("28963294960535598040566165793", "28337480073573483691160808906");
                    Console.ReadLine();
                }
                else if (key.Key == ConsoleKey.P)
                {
                    Console.WriteLine("\nParent migration...\n");
                    Worker.MergeParent("28963294960535598040566165793", "28337480073573483691160808906");
                    Console.WriteLine("Process finished...");
                    Console.ReadLine();
                }
                else if (key.Key == ConsoleKey.A)
                {
                    Console.WriteLine("\n Sending sms with login info...\n");
                    Worker.SendLoginInfoByclasse("28963294960535598040566165793");
                    Console.WriteLine("process finished...");
                    Console.ReadLine();
                }
            } while (entrerKey.Key == ConsoleKey.Enter);
        }

    }

    public class Concetrator
    {
        public IDictionary<string, string> Keys { get; set; }

        public Concetrator()
        {
            Keys = new Dictionary<string, string>();
        }

        public (List<string> klasClass, List<string> stClass) GetClassConcordances(string codeEcoleKlas, string codeEcoleStd)
        {
            var klasClasses = new List<string>();
            var stClasses = new List<string>();

            using var klassContext = new Klasroom_TestContext();
            var classes = klassContext.Classes.Where(x => x.CodeEcole == codeEcoleKlas)
                .OrderBy(x => x.Intitule)
                .Select(x => x.Intitule)
                .Distinct()
                .ToList();

            using var stdContext = new Eteyelo_system_ecmContext();
            int notFound = 0;
            foreach (var item in classes)
            {
                var stdClasses = stdContext.GlobalAffectationLocalClasses.FirstOrDefault(x => x.EloCodeEcole == codeEcoleStd && x.Intitule.ToUpper() == item.ToUpper());

                if (stdClasses is null)
                {
                    notFound++;
                }

                klasClasses.Add(item);
                stClasses.Add(stdClasses?.Intitule ?? "not found");
            }

            System.Diagnostics.Debug.WriteLine(notFound);





            return (klasClasses, stClasses);
        }
    }
}
