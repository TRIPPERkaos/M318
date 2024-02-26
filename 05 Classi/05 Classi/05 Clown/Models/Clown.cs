using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Clown.Models
{
    internal class Clown
    {
        #region Membri e Proprietà
        private string _nome;
        public string Nome
        {
            get{ return _nome; }
            set
            { 
                if(value == "")
                {
                    _nome = "Sconosciuto";
                }

                else
                {
                    _nome = value;
                }
                 
            }

        }

        private double _altezza;
        public double Altezza
        {
            get { return _altezza; }
            set
            {
                if( value <= 0)
                {
                    Console.WriteLine("Altezza improponibile");
                }

                else if(value < 100)
                {
                    Console.WriteLine("Altezza minima 100cm");
                }

                else
                {
                    _altezza = value;
                }
            }
        }

        private double _peso;
        public double Peso
        {
            get { return _peso; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Peso inesistente...");
                }
                
                else if(Peso < 35)
                {
                    Console.WriteLine("Il peso minimo deve essere almeno 35Kg");
                }

                else
                {
                    _peso = value;
                }
            }
        }
        #endregion

        #region Costruttori
        public Clown() 
        {
            _nome = "Sconosciuto";
            _altezza = 0.0;
            _peso = 0.0;

        }

        public Clown(string nome, double altezza, double peso) 
        { 
            _nome = nome;
            _altezza = altezza;
            _peso = peso;
        }
        #endregion

        #region Metodi public
        public string Saluta()
        {
            return "Ciao sono " + _nome + "\n" + RaccontaColmo();
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " Altezza: " + Altezza + " Peso: " + Peso;
        }
        #endregion

        #region Metodi private
        private string RaccontaColmo()
        {
            return "Qual è il colmo per un gatto?...Fare una vita da cani";
        }
        #endregion
    }
}
