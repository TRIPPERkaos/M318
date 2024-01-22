using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Classe_Persona.Models
{
    internal class Studente : Persona
    {
        private string _matricola;
        private string _universita;

        public string Matricola
        {
            get { return _matricola; }
            set { _matricola = value; }
        }

        public string Universita
        {
            get { return _universita; }
            set { _universita = value; }
        }

        public Studente(string codiceFiscale, string nome, string cognome, 
            string matricola, string universita) : base (codiceFiscale,nome,cognome)
        {
            Matricola = matricola;
            Universita = universita;
        }

        public override string ToString()
        {
            return String.Format("{0,-20} {1,-20} {2,-20} {3,-20} {4,-20}", 
                CodiceFiscale, Nome, Cognome, Matricola, Universita);
        }
    }
}
