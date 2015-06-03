using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnoDrustvo.Core
{
    class Intervencija
    {
        private int brojDojave;
        private List<Vatrogasac> prisutniVatrogasci;
        public Vatrogasac Upisao { get; set; }
        public Decimal VrijemeTrajanja { get; set; }
        public string Opis { get; set; }
        public string Uzrok { get; set; }

        public Intervencija()
        {
            prisutniVatrogasci = new List<Vatrogasac>();
        }

        public Intervencija(JObject intervencija)
        {
            
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
