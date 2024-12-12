using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_05_Gepjarmu
{
    internal class AudiS8 : Jarmu
    {
        public bool lezerblokkolo;

        public AudiS8(bool lezerblokkolo,int aktsebesseg, string rendszam) : base(aktsebesseg, rendszam)
        {
            this.lezerblokkolo = lezerblokkolo;
        }
        public override bool gyorshajtottE(int sebessegKorlat)
        {

            return aktsebesseg > sebessegKorlat || lezerblokkolo;
        }
    }
}
