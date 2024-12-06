using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_15_Feladat4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kocsmaros__ a1 = new Kocsmaros__(50);
            Ember e1 = new Ember("Karcsi", 22, true, 30000, 15, true);
            Console.WriteLine(e1.ToString());
            
            Console.ReadLine();
        }
    }
}
