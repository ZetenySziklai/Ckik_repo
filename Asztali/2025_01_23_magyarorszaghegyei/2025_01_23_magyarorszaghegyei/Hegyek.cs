using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_23_magyarorszaghegyei
{
    internal class Hegyek
    {
        public string hegycsucsnev, hegyseg;
        public int magassag;

        public Hegyek(string nev)
        {
            string[] st = nev.Split(';');
            hegycsucsnev = st[0];
            hegyseg = st[1];
            magassag = Convert.ToInt32(st[2]);
        }
    }
}
