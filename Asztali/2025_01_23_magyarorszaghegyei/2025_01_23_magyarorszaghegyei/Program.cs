using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_23_magyarorszaghegyei
{
    internal class Program
    {
        static List<Hegyek> hegyek = new List<Hegyek>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Feladat3();
            Feladat4();
            Feladat5();
            Console.ReadLine();
        }
        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("hegyekMo.txt");
            f.ReadLine();
            while (!f.EndOfStream)
            {
                Hegyek sv = new Hegyek(f.ReadLine());
                hegyek.Add(sv);

            }
            f.Close();
        }
        static void Feladat3()
        {
            var mennyivan = hegyek.Count();
            Console.WriteLine(mennyivan);
        }
        static void Feladat4()
        {
            var osszeg = hegyek.Average(x => x.magassag);
            
            Console.WriteLine(osszeg);
        }

        static void Feladat5()
        {
            var max = hegyek.Max(x => x.magassag);
            var hely = hegyek.Find(x => x.magassag == max);
            Console.WriteLine(hely.magassag+" "+hely.hegyseg+" "+hely.hegycsucsnev);
        }
        static void Feladat6()
        {
            int magassag = Convert.ToInt32( Console.ReadLine());
            var Borzsonyhegyek = hegyek.Where(x => x.hegyseg == "Börzsöny");
            var vane = hegyek.Find(x => x.magassag > magassag);
        }
        static void Feladat7() {
            var hegyekatvalt = hegyek.Where(x=>x.magassag* 3.280839895>3000).Count();
        }
        static void Feladat8()
        {
            var statisztika = hegyek.GroupBy(x => x.hegyseg);
            foreach (var item in statisztika)
            {
                var osszes = item.Count();
            }


        }
        static void Feladat9()
        {
            StreamWriter w = new StreamWriter("bukk-videk.txt");
            var niga = hegyek.Where(x => x.hegyseg == "Bükk-vidék").Select(x => new
            {
                hegycsucs = x.hegycsucsnev,
                magassag = x.magassag * 3.280839895
            });
            foreach (var item in niga)
            {
                w.WriteLine(item.magassag + " " + item.hegycsucs);
            }
            w.Close();

        }

    }
}
