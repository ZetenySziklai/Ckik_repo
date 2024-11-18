using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2024_11_07_Feladat2
{
    internal class Szamitogep
    {
        public double memoria;
        public bool bekapcs;

        public Szamitogep(double memoria, bool bekapcs)
        {
            this.memoria = memoria;
            this.bekapcs = bekapcs;
        }
        public Szamitogep()
        {
            memoria = 1024;
            bekapcs = false;
        }
        public void Kapcsol()
        {
            if (bekapcs == false)
            {
                bekapcs = true;
            }
            else
            {
                bekapcs = false;
            }
        }
        public bool programMasol(double memoria)
        {
            
            int program = 0;
            if (bekapcs == true && memoria-program >= 0)
            {
                memoria -= program;
                return true;
            }
                return false;
            
        }

        public override string ToString()
        {
            return string.Format("{0} Szabad memo: {1} ", bekapcs ? "Be van kapcsolva" : "Nincs bekapcsolva",memoria);
        }

        
        
       
    }
    
}
