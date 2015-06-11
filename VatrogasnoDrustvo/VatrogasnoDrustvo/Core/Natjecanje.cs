using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VatrogasnoDrustvo.Core
{
    public enum TipNatjecanja
    {
        Opcinsko,
        Gradsko,
        Zupanijsko,
        Memorijal,
        SpajanjeUsisnogVoda
    }

    public class Natjecanje
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public List<Ekipa> EkipeNatjecanja { get; set; }
        public string Mjesto { get; set; }
        public DateTime VrijemeOdrzavanja { get; set; }
        public TipNatjecanja Tip { get; set; }
        public Decimal Kotizacija { get; set; }

        public Natjecanje() { }

        public Natjecanje(DataGridViewRow row)
        {
            this.ID = int.Parse(row.Cells["ID"].Value.ToString());
            this.Naziv = row.Cells["Naziv"].Value.ToString();
            this.Mjesto = row.Cells["Mjesto"].Value.ToString();
            this.VrijemeOdrzavanja = DateTime.Parse(row.Cells["Vrijeme održavanja"].Value.ToString());
            this.Tip = (TipNatjecanja)Enum.Parse(typeof(TipNatjecanja), row.Cells["Tip natjecanja"].Value.ToString());
            this.Kotizacija = Decimal.Parse(row.Cells["Kotizacija"].Value.ToString());
        }
    }
}
