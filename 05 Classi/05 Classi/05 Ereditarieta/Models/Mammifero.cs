using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Ereditarieta.Models
{
    internal class Mammifero
    {
        private string _nome;
        public string Nome {
            get {return _nome;}
            set {_nome = value;}
        }

        public Mammifero(string nome)
        {
            _nome = nome;
        }

        public void Dormire() 
        {
            Console.WriteLine("Ronf Ronf... Dormo");
        }

        public virtual string EmettiVerso() // --> Il virtual indica che questo metodo puo' essere sovrascritto da un altro metodo di una sottoclasse (con lo stesso nome)
        {
            return "emetto un verso";
        }



    }
}
