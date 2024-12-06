using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_15_Feladat4
{
    internal class Ember
    {
        private string nev;
        private int kor,penz,reszegseg;
        private bool ferfi,kocsmaban;

        

        public Ember(string nev, int kor, bool ferfi, int penz, int reszegseg, bool kocsmaban)
        {
            this.nev = nev;
            this.ferfi = ferfi;
            this.kor = kor;
            this.penz = penz;
            this.reszegseg = 0;
            this.kocsmaban = false;
        }

        public void Iszik(Kocsmaros__ kocsmaros)
        {
            if (kocsmaban == true)
            {
                penz--;
                reszegseg++;
                Kocsmaros__.koszospohar++;
                kocsmaros.Penz++;
               
            }
            else
            {
                Console.WriteLine("Nincs a kocsmában");
            }
            if (reszegseg == 40)
            {
                Alszik();
            }

        }
        public void Iszik(Kocsmaros__ kocsmaros, Ital ital)
        {
            if(kocsmaban == true)
            {
                penz = penz - ital.Ar;
                kocsmaros.Penz += ital.Ar;
                reszegseg += ital.Alkoholtartalom;

            }

            if (reszegseg == 40)
            {
                Alszik();
            }




        }
        public void Alszik()
        {
            reszegseg = 0;
            Console.WriteLine($"{nev}Elaludt");
            
        }
        public void Hazamegy()
        {
            
            kocsmaban = false;
            Console.WriteLine($"{nev}Hazament");

        }
        public void Jon()
        {
            kocsmaban = true;
            Console.WriteLine($"{nev}Érkezik");
            
        }
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public int Kor
        {
            get { return kor; }
            set { kor = value; }
        }
        public int Reszegseg
        {
            get { return reszegseg; }
            set { reszegseg = value; }
        }
        public int Penz
        {
            get { return penz; }
            set { penz = value; }
        }

        public bool Ferfi
        {
            get { return ferfi; }
            set { ferfi = value; }
        }
        public bool Kocsmaban
        {
            get { return kocsmaban; }
            set { kocsmaban = value; }
        }
        public override string ToString()
        {
            return string.Format("Név: {0}, Kor: {1}, Reszegseg: {2}, Penz: {3}, Ferfi: {4}, Kocsmaban: {5} ",nev,kor,reszegseg,penz,ferfi,kocsmaban);
        }
    }
}
