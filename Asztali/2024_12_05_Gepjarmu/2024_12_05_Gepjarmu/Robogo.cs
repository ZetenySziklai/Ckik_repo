using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_05_Gepjarmu
{
    internal class Robogo : Jarmu,IKisGepjarmu
    {
        public int maxis;

        public Robogo(int maxis,int aktsebesseg, string rendszam) : base(aktsebesseg,rendszam)
        {
            this.maxis = maxis;
            this.aktsebesseg = aktsebesseg;
            this.rendszam = rendszam;
        }

        Robogo r1 = new Robogo(60,30,"amek-123");
        public bool gyorsanhajtottE()
        {
            return maxis> aktsebesseg? true:false;
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
