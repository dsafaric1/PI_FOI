using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnoDrustvo.Core
{
    enum KategorijaEkipe
    {
        Pomladak,
        Mladez,
        Seniori
    }

    class Ekipa
    {
        public string Naziv { get; set; }
        public List<Vatrogasac> Clanovi { get; set; }
        public KategorijaEkipe Kategorija { get; set; }

        public Ekipa(string naziv, KategorijaEkipe kategorija, Vatrogasac vatrogasci)
        {
            this.Naziv = naziv;
            this.Kategorija = kategorija;
            this.Clanovi.Add(vatrogasci);
        }

        public void AddClan(Vatrogasac clan)
        {
            Clanovi.Add(clan);
        }

        public void RemoveClan(Vatrogasac clan)
        {
            Clanovi.Remove(clan);
        }
    }
}
