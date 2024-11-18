using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Haromszog
    {
        //Mezők
        double a, b, c;

        //Konstruktor
        public Haromszog(double oldal1, double olda2, double oldal3)
        {
            a = oldal1;
            b = olda2; 
            c = oldal3;
        }
        
        public Haromszog(string sor)
        {
            string[] st = sor.Split(';');
            a = Convert.ToDouble(st[0]);
            b = Convert.ToDouble(st[1]);
            c = Convert.ToDouble(st[2]);

        }
        public bool SzerkezhatoE()
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EgyenloSzaruE()
        {
            if (a == b || a == c || b == c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SzabalyosE()
        {
            if (a == b & a == c)
            {
                return true;
            }
            else {
                return false;
            }
        }
        public double Kerulet()
        {
             return a + b + c ;
        }

        public double Terulet()
        {
            double s = a + b + c / 2;
            return Math.Sqrt(s*(s-a)*(s-b)*(s-c));
           
        }
        public bool DerekSzoguE()
        {
            return a * a + b * b == c * c;
        }

        //Metódusok
        public double A { get { return a; }}
        public double B { get { return b; }}
        public double C { get { return c; }}

        //public double A
        //{
        //    get;
        //    private set;
        //}
    }
    
}
