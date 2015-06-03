using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnoDrustvo.Core
{
    class Narudzba
    {
        private int rbr;
        public List<StavkaNarudzbe> Stavke { get; set; }
        public Dobavljac Dobavljac { get; set; }
        public DateTime RokIsporuke { get; set; }
        public string NacinIsporuke { get; set; }
        private Vatrogasac upisao;

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
