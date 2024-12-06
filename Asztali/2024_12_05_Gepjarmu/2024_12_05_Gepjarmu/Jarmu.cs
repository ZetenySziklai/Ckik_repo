using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_05_Gepjarmu
{
    internal abstract class Jarmu
    {
        protected int aktsebesseg; 
        private string rendszam;

        public string Rendszam
        {
            get { return rendszam; }
        }   
            
        public Jarmu(int aktsebesseg, string rendszam)
        {
            this.aktsebesseg = aktsebesseg;
            this.rendszam = rendszam;
        }

        public abstract bool gyorshajtottE(int sebessegkorlat)
        {
            return aktsebesseg>sebessegkorlat ? true : false;
        }
        public override string ToString()
        {
            return $"{rendszam} - {aktsebesseg} km/h";
        }
    }
}
