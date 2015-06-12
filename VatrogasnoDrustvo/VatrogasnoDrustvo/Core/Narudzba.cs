using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatrogasnoDrustvo.Bridge;
using VatrogasnoDrustvo.Forme;

namespace VatrogasnoDrustvo.Core
{
    class Narudzba
    {
        public int Rbr { get; set; }
        public List<StavkaNarudzbe> Stavke { get; set; }
        public Dobavljac Dobavljac { get; set; }
        public DateTime RokIsporuke { get; set; }
        public string NacinIsporuke { get; set; }
        public Vatrogasac Upisao { get; set; }

        public Narudzba() 
        {
            Stavke = new List<StavkaNarudzbe>();
        }

        public Narudzba(DataGridViewRow row)
        {
            Stavke = new List<StavkaNarudzbe>();
            Rbr = int.Parse(row.Cells["Narudžbenica"].Value.ToString());
            RokIsporuke = DateTime.Parse(row.Cells["Rok isporuke"].Value.ToString());
            NacinIsporuke = row.Cells["Način isporuke"].Value.ToString();
            Upisao = GlavnaForma.TrenutniVatrogasac;
            Dobavljac = new Dobavljac { Naziv = row.Cells["Dobavljač"].Value.ToString() };
            //dohvacanje stavki narudzbi za danu narudzbu
            try
            {
                var stavke = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(new Sender().Receive
                    ("https://testerinho.com/vatrogasci/gettable.php?table=StavkeNarudžbe&narudzba=" + Rbr));
                stavke.ForEach(
                    s => Stavke.Add(new StavkaNarudzbe
                    {
                        Cijena = decimal.Parse(s["cijena"].ToString()),
                        JedinicaMjera = s["jedinicna_mjera"].ToString(),
                        NarucenaOprema = new Oprema { Naziv = s["naziv"].ToString() },
                        Kolicina = int.Parse(s["kolicina"].ToString())
                    }));
            }
            catch (Exception e)
            {
                MessageBox.Show("Pogreška kod kontaktiranja servera! " + e.ToString());
            }
        }

        public void AddStavka(StavkaNarudzbe stavka) 
        {
            Stavke.Add(stavka);
        }

        public void RemoveStavka(StavkaNarudzbe stavka)
        {
            Stavke.Remove(stavka);
        }
    }
}
