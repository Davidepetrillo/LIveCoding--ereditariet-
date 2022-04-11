using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop
{
    internal class CiboInScatola : Prodotto
    {
        private double peso;

        // con 'base' stiamo chiamando il costruttore della classe prodotto (costruttore della classe base)
        public CiboInScatola(string nome, string descrizione, double peso, double prezzo, int iva) : base(nome, descrizione, prezzo, iva)
        {
            this.peso = peso;
        }
    }
}
