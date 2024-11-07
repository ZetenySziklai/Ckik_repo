using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_07_TesztelesAlapjai
{
    internal class Szamelmelet
    {
        /// <summary>
        /// Számelméleti algoritmusok
        /// </summary>
        int a;
        public Szamelmelet(int uja)
        {
            a = uja;
        }

        /// <summary>
        /// A függvény megtuplázza az osztályban használz "a" változó értékét!
        /// </summary>
        /// <returns>Megduplázott érték</returns>
        public int Duplazas()
        {
            return a * 2;
        }

        public double Hatvanyozas(int kitevo)
        {
            double szam = 1;
            for (int i = 0; i < kitevo; i++) 
            {
                szam = szam * a;
            }
            return szam;
            
            


        }
    }
}
