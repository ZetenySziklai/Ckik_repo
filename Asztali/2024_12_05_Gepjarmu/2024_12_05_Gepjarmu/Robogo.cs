using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_05_Gepjarmu
{
    internal class Robogo : Jarmu,KisGepjarmu
    {
        public int maxis;

        public Robogo(int maxis,int aktsebesseg, string rendszam) : base(aktsebesseg,rendszam)
        {
            this.maxis = maxis;
            
            
        }

        Robogo r1 = new Robogo(60,30,"amek-123");

        public override bool gyorshajtottE(int sebessegKorlat)
        {
            return aktsebesseg>sebessegKorlat;
        }
        public bool haladhatItt(int hatar)
        {
            return hatar<maxis?false:true;
        }
        public override string ToString()
        {
            return $"Robogo:{Rendszam}-{aktsebesseg}km/h";
        }

    }
}
