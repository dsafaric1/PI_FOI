using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatrogasnoDrustvo.Bridge;

namespace VatrogasnoDrustvo.Core
{
    public enum KategorijaEkipe
    {
        Podmladak,
        Mladez,
        SenioriA,
        SenioriB
    }

    public class Ekipa
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public int Ocjena { get; set; }
        public int Rezultat { get; set; }
        public List<Vatrogasac> Clanovi { get; set; }
        public KategorijaEkipe Kategorija { get; set; }

        public Ekipa(string naziv, KategorijaEkipe kategorija, Vatrogasac vatrogasci)
        {
            this.Naziv = naziv;
            this.Kategorija = kategorija;
            this.Clanovi = new List<Vatrogasac>();
            this.Clanovi.Add(vatrogasci);
        }

        public Ekipa(DataGridViewRow row)
        {
            this.ID = int.Parse(row.Cells["ID"].Value.ToString());
            this.Naziv = row.Cells["Naziv"].Value.ToString();
            this.Kategorija = (KategorijaEkipe)Enum.Parse(typeof(KategorijaEkipe), row.Cells["Kategorija"].Value.ToString());
            this.Clanovi = JsonConvert.DeserializeObject<List<Vatrogasac>>(
                new Sender().Receive("http://testerinho.com/vatrogasci/gettable.php?table=ČlanoviEkipe&ekipa=" + this.ID));
            this.Ocjena = int.Parse(row.Cells["Ocjena"].Value.ToString());
            this.Rezultat = int.Parse(row.Cells["Rezultat"].Value.ToString());
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
