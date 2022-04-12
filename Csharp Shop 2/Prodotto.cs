using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop_2
{
    internal class Prodotto
    {
        internal class Prodotto
        {
            private int codice;
            public string nome;
            public string descrizione;
            public double prezzo;
            public double iva;

            //---COSTRUTTORE---
            public Prodotto(string nome, string descrizione, double prezzo, double iva)
            {
                this.nome = nome;
                this.descrizione = descrizione;
                this.prezzo = prezzo;
                Random r = new Random(100000000);
                codice = r.Next();
                this.iva = iva;
            }


            //---GETTER CODICE e BONUS
            public string getCodice()
            {
                string codiceInStringa = codice.ToString();

                if (codiceInStringa.Length != 8)
                {
                    while (codiceInStringa.Length < 8)
                    {
                        codiceInStringa = "0" + codiceInStringa;
                    }
                    return codiceInStringa;
                }
                else
                {
                    return codiceInStringa;
                }

            }

            public void stampaPrezzoBase()
            {
                Console.WriteLine("Il prezzo di base è: " + prezzo + " euro");
            }

            public void calcoloIva()
            {
                double risultato = Math.Round(prezzo * iva / 100 + prezzo, 2);
                Console.WriteLine("Il prezzo con Iva è: " + risultato + " euro");
            }

            public void stampaNomeEsteso()
            {
                Console.WriteLine("Il nome esteso del prodotto è: " + getCodice() + " - " + nome);
            }

            public void stampaProdotto()
            {
                stampaNomeEsteso();
                Console.WriteLine("Descrizione: " + descrizione);
                stampaPrezzoBase();
                calcoloIva();
            }


        }
    }
}
