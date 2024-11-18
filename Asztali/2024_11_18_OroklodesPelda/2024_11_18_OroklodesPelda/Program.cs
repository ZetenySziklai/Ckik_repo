using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_18_OroklodesPelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutya k = new Kutya();
            k.Ugat();

            Puli p = new Puli();
            p.Ugat();
            p.Terel();


            k = p;
            k.Ugat();
            ((Puli)k).Terel();

            Console.ReadLine();
        }
    }
    class Kutya
    {
        public void Ugat()
        {
            Console.WriteLine("Vau-Vau");
        }
    }

    class Puli: Kutya
    {
        public void Terel()
        {
            Console.WriteLine("Álljá meg geci");
        }
    }
}
