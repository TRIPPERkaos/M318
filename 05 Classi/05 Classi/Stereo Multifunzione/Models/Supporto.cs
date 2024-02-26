using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereo_Multifunzione.Models
{
    internal class Supporto
    {
		private string _marca;

		public string Marca
		{
			get { return _marca; }
			set { _marca = value; }
		}

		private string _modello;

		public string Modello
		{
			get { return _modello; }
			set { _modello = value; }
		}

		private Brano[] _tracce;

		public Brano[] Tracce
		{
			get { return _tracce; }
			set { _tracce = value; }
		}

		public Supporto(string marca,string modello,Brano[] tracce)
		{
			Marca = marca;
			Modello = modello;
			Tracce = tracce; //Passato per riferimento
		}

        public override string ToString()
        {
            return String.Format("{0,-20} {1,-20} {2,-20}",
               Marca, Modello, Tracce);
        }



    }
}
