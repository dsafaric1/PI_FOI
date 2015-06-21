using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace VatrogasnoDrustvo.Core
{
   public class Dobavljac
    {
        public string ID { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Kontakt { get; set; }
        public string Email { get; set; }

        public Dobavljac() { }

        public Dobavljac(DataGridViewRow row)
        {
            ID = row.Cells["Redni broj"].Value.ToString();
            Naziv = row.Cells["Naziv"].Value.ToString();
            Adresa = row.Cells["Adresa"].Value.ToString();
            Kontakt = row.Cells["Kontakt broj"].Value.ToString();
            Email = row.Cells["E-mail"].Value.ToString();

        }

        public override string ToString()
        {
            return this.Naziv;
        }
    }
}
