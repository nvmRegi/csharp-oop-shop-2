using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop_2
{
    internal class SacchettoDiFrutta : Prodotto
    {
        private string tipoFrutta;
        private double peso;
        public const int MAX_PEZZI = 5;
        
        public SacchettoDiFrutta(string nome, string descrizione, string tipoFrutta, double peso) : base(nome, descrizione)
        {
            this.tipoFrutta = tipoFrutta;
            this.peso = peso;
        }

        public SacchettoDiFrutta(string nome, string descrizione, double prezzo, double iva, string tipoFrutta, double peso) : base(nome, descrizione, prezzo, iva)
        {
            this.tipoFrutta= tipoFrutta;
            this.peso= peso;
        }
    }
}
