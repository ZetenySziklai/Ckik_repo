using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_17_Kosarlabda
{
    internal class Program
    {
        static List<Eredmenyek> list = new List<Eredmenyek>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();            Console.ReadLine();
        }

        public static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("eredmenyek.csv");
            f.ReadLine();
            while (!f.EndOfStream)
            {
                Eredmenyek sv = new Eredmenyek(f.ReadLine());
                list.Add(sv); ;
            }
            f.Close();

        }

        private static void Feladat3()
        {
            int realmadridh = list.Where(x => x.hazaics == "Real Madrid").Count();
            int realmadride = list.Where(x => x.idegencs == "Real Madrid").Count();
            Console.WriteLine(realmadride + realmadridh);

        }
        private static bool Feladat4()
        {
            bool dontetlen = list.Any(x => x.hazaics == x.idegencs);
            return true;

        }
        private static void Feladat5()
        {
            var barca = list.Find(x => x.hazaics.Contains("Barcelona"));
            Console.WriteLine(barca.hazaics);
        }
        private static void Feladat6()
        {

            var hazai = list.Where(x => x.idopont == "2004-11-21");
            foreach (var item in hazai)
            {
                Console.WriteLine(item.hazaics);
            }
            
            
        }
        private static void Feladat7()
        {
            var husznaltobb = list.GroupBy(x => x.helyszin).Where(x => x.Count() > 20);

            foreach (var item in husznaltobb)
            {
                Console.WriteLine(item.Key + " " + item.Count());
            }
        }
        
    }
}
