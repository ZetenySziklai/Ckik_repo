using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static List<Haromszog> haromszog = new List<Haromszog>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            MaximumTerulet();
            VaneSzabalyos();
            VaneSzabalyos();
            Console.ReadLine();
        }
        private static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("haromszogek.txt");

            f.ReadLine();
            while (!f.EndOfStream)
            {
                haromszog.Add(new Haromszog(f.ReadLine()));
            }
            f.Close();
        }
        private static void Szerkeszhetoe()
        {
            int osszeg = 0;
            for (int i = 0; i < haromszog.Count; i++)
            {
                if (haromszog[i].SzerkezhatoE() == false)
                {
                    osszeg += 1;
                }
            }

        }
        private static void MaximumTerulet()
        {
            int maxi = 0;
            for (int i = 0; i < haromszog.Count; i++)
            {
                if (haromszog[maxi].Terulet() < haromszog[i].Terulet())
                {
                    maxi = i;
                }
            }
            
            Console.WriteLine(haromszog[maxi].A+" "+haromszog[maxi].B+" " +haromszog[maxi].C);
        }
        private static void VaneSzabalyos()
        {
            string szoveg = " ";
            for (int i = 0; i < haromszog.Count; i++)
            {
                if (haromszog[i].SzabalyosE() == true)
                {
                    szoveg = " ";
                    szoveg = "van";
                
                }
                else
                {
                    szoveg = " ";
                    szoveg = "nincs";
                }
            }
        }
    }
    
}
