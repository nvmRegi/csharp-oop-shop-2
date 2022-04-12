using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop_2
{
    internal class CiboInScatola : Prodotto
    {
        public const double MAX_KG = 300;
        private string tipoCibo;
        private string materialeContenitore;

        public CiboInScatola(string nome, string descrizione, string tipoCibo, string materialeContenitore) : base(nome, descrizione)
        {
            this.tipoCibo = tipoCibo;
            this.materialeContenitore = materialeContenitore;
        }
        
        public CiboInScatola(string nome, string descrizione, double prezzo, double iva, string tipoCibo, string materialeContenitore) : base(nome, descrizione, prezzo, iva)
        {
            this.tipoCibo = tipoCibo;
            this.materialeContenitore = materialeContenitore;
        }
    }
}
