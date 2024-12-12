using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_05_Gepjarmu
{
    internal class Orszagut
    {
        static List<Jarmu> jarmu = new List<Jarmu>();

        public static void jarmuvekJonnek(string szoveg)
        {
            StreamReader f = new StreamReader(szoveg);
            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(' ');

                if (st[0] == "robogo")
                {
                    Robogo robogo = new Robogo(Convert.ToInt32());
                }
                else if (st[0] == "audi")
                {

                }
                
            }
            f.Close();
        }
        public static void kiketMertunkBe()
        {
            int i = 0;
            StreamWriter f = new StreamWriter("buntetes.txt");
            while (i<jarmu.Count)
            {
                if(jarmu[i].GetType() == typeof(AudiS8))
                {
                    f.Write(jarmu);
                    if (jarmu[i].gyorshajtottE(90))
                    {
                        f.WriteLine("gyorshajtott");
                    }
                    else
                    {
                        f.WriteLine();
                    }
                }
                else if (jarmu[i].GetType() == typeof(Robogo))
                {
                    f.Write(jarmu);
                    if (((Robogo)jarmu[i]).haladhatItt(90))
                    {
                        f.WriteLine("Nem haladhat itt");
                    }
                    else
                    {
                        f.WriteLine();
                    }

                }
            }
        }
    }
}
