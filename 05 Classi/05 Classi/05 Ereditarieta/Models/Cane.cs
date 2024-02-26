using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Ereditarieta.Models
{
    internal class Cane : Mammifero
    {
        private bool _isSegugio;
        public bool IsSegugio {
            get {return _isSegugio;}
            set {_isSegugio = value;}
        }

        public Cane(bool isSegugio, string nome) : base(nome)
        {
            _isSegugio = isSegugio;
        }

        public string Abbaia()
        {
            return "Bau Bau Bauuuuuu";
        }

        public override string EmettiVerso() // --> Override indica che il metodo è sovrascritto a quello della classe base Mammifero
        {
            return "Bau Bau Bauuuuuuuuuuuuuuuuuuuuuuuuuuuuu";
        }

    }
}
