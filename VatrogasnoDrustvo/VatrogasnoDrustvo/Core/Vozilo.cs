using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnoDrustvo.Core
{
    public enum TipVozila
    {
        Zapovjedno,
        Navalno,
        Tehnicko,
        Autoljestve,
        Autocisterna,
        Platforma,
        Specijalno
    }

    public class Vozilo:Oprema
    {
        public int Godiste { get; set; }
        public int BrojSjedala { get; set; }
        public TipVozila tipVozila { get; set; }
        public int ZapremninaVode { get; set; }
    }
}
