using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public Narudzba() { }

        public Narudzba(DataGridViewRow row)
        {
            Rbr = int.Parse(row.Cells["Narudžbenica"].Value.ToString());
            RokIsporuke = DateTime.Parse(row.Cells["Rok isporuke"].Value.ToString());
            NacinIsporuke = row.Cells["Način isporuke"].Value.ToString();
            Upisao = GlavnaForma.TrenutniVatrogasac;
            //TODO stavke
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
