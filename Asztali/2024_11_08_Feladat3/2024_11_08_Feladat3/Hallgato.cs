using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
namespace _2024_11_08_Feladat3
{
    internal class Hallgato
    {

        public string azonosito;
        public int evfolyam, kreditszam;

        public Hallgato(string azonosito,int evfolyam,int kreditszam) 
        {
            
            this.azonosito = azonosito;
            this.evfolyam = evfolyam;
            this.kreditszam = kreditszam;
        }

        public Hallgato(string azonosito)
        {
            this.azonosito=azonosito;
            evfolyam = 1;
            kreditszam=0;
        }
        public void targyFelvesz(int kredit)
        {
            kreditszam += kredit;
        }
        public bool vizsgazik()
        {
            if (kreditszam > 0)
            {
                evfolyam++;
                kreditszam = 0;
                return true;
            }
            return false;
            
        }
        public override string ToString()
        {
            return string.Format("{0}. évfolyam azonosító:{1} kreditszám:{2}",evfolyam,azonosito,kreditszam); 
        }

        
    }
}
