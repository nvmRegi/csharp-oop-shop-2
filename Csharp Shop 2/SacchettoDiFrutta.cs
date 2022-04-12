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
        public int pezzi;
        
        //---------COSTRUTTORI-----------
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

        //-----------METODI-----------------
        public void aggiungiPezzoFrutta(int pezzoDaAggiungere)
        {
            if(pezzi + pezzoDaAggiungere < MAX_PEZZI)
            {
                pezzi += pezzoDaAggiungere;
                Console.WriteLine("Hai aggiunto " + pezzoDaAggiungere + "pezzi di frutta!");
            } else if(pezzoDaAggiungere == 0)
            {
                Console.WriteLine("Errore nell'aggiunta del nuovo pezzo!");
            }
            else
            {
                pezzi = MAX_PEZZI;
                Console.WriteLine("Hai raggiunto il massimo dei pezzi di frutta!");
            }
        }

        public void togliPezzoFrutta(int pezzoDaTogliere)
        {
            if(pezzi - pezzoDaTogliere <= 0)
            {
                pezzi = 0;
                Console.WriteLine("Hai tolto tutti i pezzi!");
            } else if (pezzoDaTogliere == 0)
            {
                Console.WriteLine("Errore nell'aggiunta del nuovo pezzo!");
            }
            else
            {
                pezzi -= pezzoDaTogliere;
                Console.WriteLine("Hai tolto " + pezzoDaTogliere + "pezzi. Ne rimangono: " + pezzi);
            }
        }

        public override void stampaProdotto()
        {
            base.stampaNomeEsteso();
            Console.WriteLine("Descrizione: " + base.descrizione);
            Console.WriteLine("Tipo di Frutta: " + this.tipoFrutta);
            Console.WriteLine("Pezzi di Frutta: " + pezzi);
            base.stampaPrezzoBase();
            base.calcoloIva();
        }

    }
}
