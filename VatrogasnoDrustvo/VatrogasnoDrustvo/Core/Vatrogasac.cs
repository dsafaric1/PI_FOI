using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnoDrustvo.Core
{

    #region Enums

    public enum Clan
    {
        Operativni,
        Izvrsni,
        Pricuvni,
        Pomazuci,
        Veteran,
        Pocasni
    }

    public enum Duznost 
    {
        Predsjednik,
        ZamjenikPredsjednika,
        Zapovjednik,
        ZamjenikZapovjednika,
        Tajnik,
        Blagajnik,
        Spremistar
    }

    public enum Zvanje
    {
        Vatrogasac,
        VatrogasacPrveKlase,
        Docasnik,
        DocasnikPrveKlase,
        Casnik,
        CasnikPrveKlase,
        VisiCasnik,
        VisiCasnikPrveKlase,
        PocasnikCasnik
    }

    #endregion Enums

    public class Vatrogasac
    {
        private string oib;
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string DatumRodenja { get; set; }
        public string Adresa { get; set; }
        public string DatumUclanjenja { get; set; }
        public Clan VrstaClana { get; set; }
        public Zvanje Zvanje { get; set; }
        public Duznost Duznost { get; set; }

        public Vatrogasac() { }

        public Vatrogasac(JObject podaci) { }

    }
}
