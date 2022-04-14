using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop_2
{
    internal class Acqua : Prodotto
    {
        public double litri; //litri presenti nella bottiglia
        private double ph; //livello di acidità dell'acqua
        private string sorgente; //provenienza dell'acqua
        public const double MAX_LITRI = 1.5;

        //COSTRUTTORE senza iva e senza prezzo
        public Acqua(string nome, string descrizione, double litri, double ph, string sorgente) : base(nome, descrizione)
        {
            this.litri = litri;
            this.ph = ph;  
            this.sorgente = sorgente;
        }

        //COSTRUTTORE con iva e prezzo
        public Acqua(string nome, string descrizione, double prezzo, double iva, double litri, double ph, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            this.litri = litri;
            this.ph=ph;
            this.sorgente = sorgente;
        }

        //--------------GETTER E SETTER-------------------
        public double GetPh()
        {
            return ph;
        }

        public string GetSorgente()
        {
            return sorgente;
        }

        //-------------METODI----------------
        public void bevi(double litriDabere)
        {
            if(this.litri - litriDabere > 0)
            {
                this.litri -= litriDabere;
                Console.WriteLine("Stai bevendo!");
            }
            else if(this.litri == 0)
            {
                throw new ArgumentOutOfRangeException("litri","LA BOTTIGLIA è VUOTA");
            }
            else
            {
                this.litri = 0;
                Console.WriteLine("Hai finito tutta l'acqua!");
            }
        }

        public void riempi(double litri)
        {
            if (litri == 0)
            {
                Console.WriteLine("Errore nel riempimento!");
            } else if (this.litri + litri < MAX_LITRI)
            {
                this.litri += litri;
                Console.WriteLine("Stai riempiendo la bottiglia!");
            } else if (this.litri + litri > MAX_LITRI)
            {
                this.litri = MAX_LITRI;
                Console.WriteLine("Hai riempito troppo la bottiglia!");
            }
        }

        public void svuota()
        {
            if(this.litri == 0)
            {
                Console.WriteLine("La bottiglia è già vuota!");
            }
            else
            {
                this.litri = 0;
                Console.WriteLine("Hai svuotato la bottiglia!");
            }
        }

        public override void stampaProdotto()
        {
            base.stampaNomeEsteso();
            Console.WriteLine("Descrizione: " + base.descrizione);
            Console.WriteLine("Sorgente: " + this.sorgente);
            Console.WriteLine("PH: " + this.ph);
            Console.WriteLine("Litri: " + this.litri);
            base.stampaPrezzoBase();
            base.calcoloIva();
        }

        //METODO STATICO
        public static double convertiInGalloni(double litri)
        {
            return litri * 3.785;
        }
    }
}
