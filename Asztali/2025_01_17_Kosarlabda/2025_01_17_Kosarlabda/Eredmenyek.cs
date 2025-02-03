using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_17_Kosarlabda
{
    internal class Eredmenyek
    {
        public string hazaics, idegencs,helyszin, idopont;
        public int hazapont, idegenpont;
         
        public Eredmenyek(string sor)
        {
            string[] st = sor.Split(';');
            hazaics = st[0];
            idegencs = st[1];
            hazapont = Convert.ToInt32(st[2]);
            idegenpont = Convert.ToInt32(st[3]);
            helyszin = st[4];
            idopont = st[5];

        }
    }
}
