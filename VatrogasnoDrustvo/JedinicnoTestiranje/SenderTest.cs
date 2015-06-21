using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VatrogasnoDrustvo;
using VatrogasnoDrustvo.Bridge;
using VatrogasnoDrustvo.Core;
using VatrogasnoDrustvo.Forme;
using System.Collections.Generic;
using Newtonsoft.Json;

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
            return natjecanje;
        }

        public Natjecanje podatci2()
        {
            Natjecanje natjecanje = new Natjecanje();
            natjecanje.Kotizacija = 10;
            natjecanje.Mjesto = "Sisak";
            natjecanje.Naziv = "Gradsko natjecanje";
            natjecanje.VrijemeOdrzavanja = DateTime.Parse("10/12/2013");
            natjecanje.Tip = TipNatjecanja.Gradsko;

            return natjecanje;
        }
        [TestMethod]
        public void SendNatjecanjaTest()
        {
            Sender s1 = new Sender();
            var send1 =JsonConvert.DeserializeObject<Dictionary<string, object>>
                    (s1.Send(podatci1(), "https://testerinho.com/vatrogasci/insertNatjecanja.php"));
            Assert.AreEqual(false,bool.Parse(send1["passed"].ToString()),"Podaci su dobro unešeni.");

            Sender s2=new Sender();
            object send2 = s2.Send(podatci2(),"http://testerinho.com/");
        }

        public Dobavljac podatci3()
        {
            Dobavljac dobavljac = new Dobavljac();
            return dobavljac;
        }
        public Dobavljac podatci4()
        {
            Dobavljac dobavljac = new Dobavljac();
            dobavljac.Adresa = "Ludbreška 3";
            dobavljac.Email = "mvracan@foi.hr";
            dobavljac.Kontakt = "00385915554444";
            dobavljac.Naziv = "OpremaShop";
            return dobavljac;
        }

        [TestMethod]
        public void SendDobavljaciTest()
        {
            Sender s3 = new Sender();
            var send3 = JsonConvert.DeserializeObject<Dictionary<string, object>>
                (s3.Send(podatci3(), "https://testerinho.com/vatrogasci/insertDobavljac.php"));
            Assert.AreEqual(false,bool.Parse(send3["passed"].ToString()),"Podaci su dobro unešeni.");

            Sender s4 = new Sender();
            object send4 = s3.Send(podatci4(), "http://testerinho.com/");
        }


        public Intervencija podatci5()
        {
            Intervencija intervencija = new Intervencija();
            return intervencija;
        }

        [TestMethod]
        public void SendIntervencijaTest()
        {
            Sender s5 = new Sender();
            var send5 = JsonConvert.DeserializeObject<Dictionary<string, object>>
                (s5.Send(podatci5(), "https://testerinho.com/vatrogasci/insertIntervencija.php"));
            Assert.AreEqual(false,bool.Parse(send5["passed"].ToString()),"Podaci su dobro unešeni");

        }
    }
}
