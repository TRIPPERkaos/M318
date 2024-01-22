using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3_Ereditarieta_prodotti.Models
{
    internal class Prodotto
    {
        private string _codice;
        public string Codice
        {
            get { return _codice; }
            set { _codice = value; }
        }

        private double _prezzo;
        public double Prezzo
        { 
            get { return _prezzo; }
            set 
            { 
                _prezzo = value;
            }
        }

        private string _descrizione;
        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }
        
        public Prodotto(string codice, double prezzo, string descrizione)
        {
            Codice = codice;
            Prezzo = prezzo;
            Descrizione = descrizione;
        }

        public virtual double ApplicaSconto()
        {
            Prezzo = Prezzo - (Prezzo * 0.05);
            return Prezzo;
        }

        public override string ToString()
        {
            return Codice + ";" + Prezzo + ";" + Descrizione;
        }
    }
}
