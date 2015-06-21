using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VatrogasnoDrustvo;
using VatrogasnoDrustvo.Core;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class StavkaNarudzbeTest
    {
        [TestMethod]
        public void GetUkupnaCijenaTest()
        {
            StavkaNarudzbe p1 = new StavkaNarudzbe();
            p1.Kolicina = 0;
            p1.Cijena = 5;
            Decimal r1=p1.GetUkupnaCijena();
            Assert.AreEqual(0,r1,"Vrijednosti nisu nula");

            StavkaNarudzbe p2 = new StavkaNarudzbe();
            p2.Kolicina = -1;
            p2.Cijena = 5;
            Decimal r2 = p2.GetUkupnaCijena();
            Assert.IsTrue(r2<0,"Vrijednosti nisu negativne");
        }
    }
}
