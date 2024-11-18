using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_08_Feladat3
{
    internal class Program
    {
        static List<Hallgato> hallgato = new List<Hallgato>();

        static void Main(string[] args)
        {

            Hallgato h1 = new Hallgato("Laci",2,5);
            Hallgato h2 = new Hallgato("Kálmán",3,0);

            Sikeres(h1);
            Sikeres(h2);
            Console.ReadLine(); 

        }

        static void Sikeres(Hallgato hallgato)
        {
            Console.WriteLine(hallgato.vizsgazik() ? "Sikeres vizsga" : "Sikertelen");
            Console.WriteLine(hallgato.ToString());
        }
        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("hallgatok.txt");
            f.ReadLine();
            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split('\t');
                hallgato.Add(new Hallgato(st[0], Convert.ToInt32(st[1]), Convert.ToInt32(st[2])));
            }


        }

        
        public void Hozzarendel()
        {
            for (int i = 0; i < hallgato.Count; i++)
            {
                Random r = new Random();
                hallgato[i].evfolyam = r.Next(0,4);
            }
        }
        public void Vizsga()
        {
            int osszeg = 0;
            for (int i = 0; i < hallgato.Count; i++)
            {
                if (hallgato[i].vizsgazik() == true)
                {
                    osszeg++;
                }
                
            }
            Console.WriteLine(osszeg + "vizsgázó lépett a következő évfolyamba");
        }

    }
}
