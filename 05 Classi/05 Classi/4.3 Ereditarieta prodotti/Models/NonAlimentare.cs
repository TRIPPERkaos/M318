using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3_Ereditarieta_prodotti.Models
{
    internal class NonAlimentare : Prodotto
    {
		private string _materiale;
		public string Materiale
		{
			get { return _materiale; }
			set { _materiale = value; }
		}

		public NonAlimentare(string codice, double prezzo, string descrizione, string materiale) : base(codice,prezzo,descrizione)
		{
			Materiale = materiale;
		}

        public override double ApplicaSconto()
        {	
			if(Materiale.Equals("carta") || Materiale.Equals("vetro") || Materiale.Equals("plastica"))
			{
                Prezzo = Prezzo - (Prezzo * 0.1);
            }
			else
			{
				Prezzo = Prezzo - (Prezzo * 0.05);
			}
            
            return Prezzo;
        }

        public override string ToString()
        {
            return String.Format("{0,-20} {1,-20} {2,-20} {3,-20}",
               Codice, Prezzo, Descrizione, Materiale);
        }
    }
}
