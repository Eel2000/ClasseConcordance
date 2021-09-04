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
            Console.WriteLine("Hello World!\r\n Tapez sur ENTER pour continuer...");
            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {
                //var con = new Concetrator();
                //var classes = con.GetClassConcordances("28963294960535598040566165793", "28963294960535598040566165793");
                //var zippedClasses = classes.klasClass.Zip(classes.stClass, (first, second) => $"{first}       {second}");
                //foreach (var item in zippedClasses)
                //{
                //    Console.WriteLine("{0}", item);
                //}
                Worker.MergeClassesCodes("28963294960535598040566165793", "28337480073573483691160808906");

                Console.ReadLine();
            }
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
