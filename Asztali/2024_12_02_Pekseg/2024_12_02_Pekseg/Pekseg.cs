using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_02_Pekseg
{
    internal class Pekseg
    {
        static List<IArlap> termekek = new List<IArlap>();
        static void Vasarlok(string path)
        {
            StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream)
            {
                string[] st = sr.ReadLine().Split(' ');
                if (st[0] == "pogacsa")
                {
                    Pogacsa p = new Pogacsa(Convert.ToDouble(st[1]), Convert.ToDouble(st[2]));
                    termekek.Add(p);
                }
                else
                {
                    Kave kv = new Kave(st[1] == "habos");
                    termekek.Add(kv);
                }
            }    

            sr.Close();
        }
    }
}
