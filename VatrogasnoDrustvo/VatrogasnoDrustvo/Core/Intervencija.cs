using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VatrogasnoDrustvo.Core
{
    enum VrstaIntervencije
    {
        Pozar,
        Tehnicka,
        Ostalo
    }

    class Intervencija
    {
        public int BrojDojave { get; set; }
        public List<Vatrogasac> prisutniVatrogasci { get; set; }
        public Vatrogasac Upisao { get; set; }
        public Decimal VrijemeTrajanja { get; set; }
        public string Opis { get; set; }
        public string Uzrok { get; set; }
        public VrstaIntervencije Vrsta { get; set; }

        public Intervencija()
        {
            prisutniVatrogasci = new List<Vatrogasac>();
        }

        public Intervencija(DataGridViewRow intervencija)
        {
            this.BrojDojave = int.Parse(intervencija.Cells["Broj dojavnice"].Value.ToString());
            this.Opis = intervencija.Cells["Opis"].Value.ToString();
            this.Uzrok = intervencija.Cells["Uzrok"].Value.ToString();
            //TODO konstruktor za intervenciju do kraja
        }

        public void AddPrisutniVatrogasac(Vatrogasac vatrogasac) 
        {
            prisutniVatrogasci.Add(vatrogasac);
        }

        public void RemovePrisutniVatrogasac(Vatrogasac vatrogasac)
        {
            prisutniVatrogasci.Remove(vatrogasac);
        }
    }
}
