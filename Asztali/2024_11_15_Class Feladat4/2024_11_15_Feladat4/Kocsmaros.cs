using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_15_Feladat4
{
    internal class Kocsmaros__
    {
        private int penz;
        public static int koszospohar;

        public int Penz
        {
            get { return penz; }
            set { penz = value; }
        }

        public Kocsmaros__(int penz)
        {
            this.penz = penz;
        }

        public void Elmos()
        {
            
            if (koszospohar == 0)
            {
                Console.WriteLine("Nincs koszos pohár");
            }
            else
            {
                Console.WriteLine("Elmosott egy poharat");
                koszospohar--;
            }
        }
        public override string ToString() {
            return string.Format("Kocsmaros penze: {0}, Koszospohar{1}",penz,koszospohar);
        }
    }
    
}
