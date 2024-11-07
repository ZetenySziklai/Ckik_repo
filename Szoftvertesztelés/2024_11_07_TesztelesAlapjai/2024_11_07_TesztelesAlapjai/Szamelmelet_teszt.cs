using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace _2024_11_07_TesztelesAlapjai
{
    [TestFixture]
    internal class Szamelmelet_teszt
    {

        [Test]
        public void Duplaz_a12()
        {
            //Arrange
            int a = 12;
            Szamelmelet sz = new Szamelmelet(a);

            //Act (Ebben a lépésben végrehajtjuk a tesztelendő műveletet vagy műveleteket.)
            int eredmeny = sz.Duplazas();

            //Assert
            ClassicAssert.AreEqual(24, eredmeny);
            
            

        }
        [Test]
        public void Duplaz_b2()
        {
            int b = 2;
            Szamelmelet sz = new Szamelmelet(b);

            int eredmeny = sz.Duplazas();

            ClassicAssert.AreEqual(4, eredmeny);
        }
        [Test]

        public void Hatvany_a36()
        {
            int a = 6;
            int b = 2;
            Szamelmelet sz = new Szamelmelet(a);

            double eredmeny = sz.Hatvanyozas(b);

            ClassicAssert.AreEqual(36, eredmeny);
        }
    }
}
