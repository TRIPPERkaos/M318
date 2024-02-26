using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Classe_Persona.Models
{
    internal class Docente : Persona
    {
        private string _materia;
        private double _salario;

        public string Materia
        {
            get { return _materia; }
            set {_materia = value; }
        }

        public double Salario
        {
            get { return _salario; }
            set { _salario = value; }
        }

        public Docente(string codiceFiscale, string nome, string cognome, string materia, double salario) : base(codiceFiscale, nome, cognome)
        {
            _materia = materia;
            _salario = salario;
        }

        public override string ToString()
        {
            return String.Format("{0,-20 } {1,-20} {2,-20} {3,-20} {4,-20}",
                CodiceFiscale, Nome, Cognome, Materia, Salario);
        }
    }
}
