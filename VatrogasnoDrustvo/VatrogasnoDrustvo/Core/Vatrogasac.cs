using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        Spremistar,
        Nema
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
        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string DatumRodenja { get; set; }
        public string Adresa { get; set; }
        public string DatumUclanjenja { get; set; }
        public Clan VrstaClana { get; set; }
        public Zvanje Zvanje { get; set; }
        public Duznost Duznost { get; set; }

        public Vatrogasac() { }

        public Vatrogasac(DataGridViewRow row) 
        {
            OIB = row.Cells["OIB"].Value.ToString();
            Ime = row.Cells["Ime"].Value.ToString();
            Prezime = row.Cells["Prezime"].Value.ToString();
            Adresa = row.Cells["Adresa"].Value.ToString();
            DatumRodenja = row.Cells["Datum rođenja"].Value.ToString();
            DatumUclanjenja = row.Cells["Datum učlanjenja"].Value.ToString();
            Zvanje = (Zvanje)Enum.Parse(typeof(Zvanje), row.Cells["Zvanje"].Value.ToString(), true);
            if (row.Cells["Dužnost"].Value.ToString() == "")
            {
                Duznost = Duznost.Nema;
            }
            else
            {
                Duznost = (Duznost)Enum.Parse(typeof(Duznost), row.Cells["Dužnost"].Value.ToString(), true);
            }
            VrstaClana = (Clan)Enum.Parse(typeof(Clan), row.Cells["Vrsta člana"].Value.ToString(), true);
        }

    }
}
