using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatrogasnoDrustvo.Bridge;

namespace VatrogasnoDrustvo.Core
{
    public enum VrstaIntervencije
    {
        Pozar,
        Tehnicka,
        Ostalo
    }

   public class Intervencija
    {
        public int BrojDojave { get; set; }
        public List<Vatrogasac> prisutniVatrogasci { get; set; }
        public Vatrogasac Upisao { get; set; }
        public string PocetnoVrijeme { get; set; }
        public string ZavrsnoVrijeme { get; set; }
        public string Opis { get; set; }
        public string Mjesto { get; set; }
        public string Adresa { get; set; }
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
            this.Mjesto = intervencija.Cells["Mjesto"].Value.ToString();
            this.Adresa = intervencija.Cells["Adresa"].Value.ToString();
            this.PocetnoVrijeme = intervencija.Cells["Početno vrijeme"].Value.ToString();
            this.ZavrsnoVrijeme = intervencija.Cells["Završno vrijeme"].Value.ToString();
            this.Vrsta = (VrstaIntervencije)Enum.Parse(typeof(VrstaIntervencije), intervencija.Cells["Vrsta intervencije"].Value.ToString());
            this.prisutniVatrogasci = JsonConvert.DeserializeObject<List<Vatrogasac>>
                        (new Sender().Receive("https://testerinho.com/vatrogasci/gettable.php?table=Prisutni&intervencija=" + BrojDojave));

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
