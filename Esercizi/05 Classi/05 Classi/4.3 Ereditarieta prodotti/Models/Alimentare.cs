using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3_Ereditarieta_prodotti.Models
{
    internal class Alimentare : Prodotto
    {
        private DateTime _data;
		public DateTime Data
		{
			get { return _data; }
			set { _data = value; }
		}

		public Alimentare(string codice, double prezzo, string descrizione, DateTime data) : base(codice,prezzo,descrizione)
		{
			Data = data;
		}

        public override double ApplicaSconto()
        {
			//DateTime DataCorrente = DateTime.Now
			Prezzo = Prezzo - (Prezzo * 0.2);
			return Prezzo;
        }

        public override string ToString()
        {
            return Codice + ";" + Prezzo + ";" + Descrizione + ";" + Data;
        }

    }
}
