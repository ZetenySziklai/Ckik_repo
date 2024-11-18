using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_07_Feladat2
{
    internal class Program
    {
        static List<Szamitogep> szamitogep = new List<Szamitogep>();

        static void Main(string[] args)
        {
            Szamitogep sz1 = new Szamitogep();
            Szamitogep sz2 = new Szamitogep(14000, true);

            sz1.Kapcsol();
            sz1.programMasol(800);
            sz1.programMasol(400);
            sz2.programMasol(1);

            Console.Write(sz1.ToString());
            Console.WriteLine(sz2.ToString());
        }

        private static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("Szamitogep.txt");
            f.ReadLine();
            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split('\t');
                szamitogep.Add(new Szamitogep(Convert.ToInt32(st[0]), st[1] == "x"));
            }
            f.Close();
        }

       
        private static int Megszamlalas()
        {
            int megs = 0;
            for (int i = 0; i < szamitogep.Count; i++)
            {
                if (szamitogep[i].bekapcs == true)
                {
                    megs++;
                }
            }
            return megs;

        }
        private static bool Bevane()
        {
            int maxi = 0;
            for (int i = 0; i < szamitogep.Count; i++)
            {
                if (szamitogep[i].memoria > szamitogep[maxi].memoria)
                {
                    maxi = i;
                }
            }
            return szamitogep[maxi].bekapcs ? true : false;
        }

    }
}
