using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_12_Szuperhosok
{
    internal abstract class Bosszuallo : Szuperhos
    {
        private float szuperero;
        private bool vanEGyengesege;

        public Bosszuallo(float szuperero, bool vanEGyengesege)    
        {
            this.szuperero = szuperero;
            this.vanEGyengesege = vanEGyengesege;
        }
        public abstract bool megmentiAVilagot();

        public override bool legyoziE(int szuperhos)
        {

        }
        public override



    }
}
