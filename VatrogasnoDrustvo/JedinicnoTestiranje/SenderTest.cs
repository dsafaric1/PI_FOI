using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VatrogasnoDrustvo;
using VatrogasnoDrustvo.Bridge;
using VatrogasnoDrustvo.Core;
using VatrogasnoDrustvo.Forme;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class SenderTest
    {

        public SenderTest()
        {

        }

        public Natjecanje podatci1()
        {
            Natjecanje natjecanje = new Natjecanje();
            natjecanje.Kotizacija = -50;
            natjecanje.Mjesto = "Sisak";
            natjecanje.Naziv = "Gradsko natjecanje";
            natjecanje.VrijemeOdrzavanja=DateTime.Parse("10/12/2013");
            natjecanje.Tip=TipNatjecanja.Gradsko;

            return natjecanje;
        }
        [TestMethod]
        public void SendNatjecanjaTest()
        {
            Sender s1=new Sender();
            object send=s1.Send(podatci1(),"https://testerinho.com/vatrogasci/insertNatjecanja.php");
            
        }

        /// napraviti Sender za postojeći url al ne naš (recimo google.hr)
        /// napraviti Sender za nepostojeći url (recimo abcdefgh.jkl)
        /// potražiti u Core folderu klase koje imaju metode koje se isplati testirati (recimo Narudzba -> getUkupnaCijena)
        /// napraviti Sender koji šalje null podatke na naš url
        /// DocumentGenerator razne narudžbe
    }
}
