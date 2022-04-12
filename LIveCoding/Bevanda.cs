using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop
{
    internal class Bevanda : Prodotto
    {
        private double litri;
        public string materialeContenitore;
        

        public Bevanda(string nome, string descrizione, double prezzo, int iva, double litri, string materiale) : base(nome, descrizione, prezzo, iva)
        {
            this.litri = litri;
            this.materialeContenitore = materiale;
        }

        public void CodiceBevanda()
        {
            // codice pad - nome bevanda - litri

            Console.Write($"{base.PadLeft()} - {base.GetNome} - {this.litri}");
            Console.WriteLine($"Sono una bottiglia da {this.litri}");
        }
       
    }
 }
