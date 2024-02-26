using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereo_Multifunzione.Models
{
    internal class Vinile : Supporto
    {
		private double _giriMinuti;

		public double GiriMinuti
		{
			get { return _giriMinuti; }
			set { _giriMinuti = value; }
		}

		public Vinile(string marca,string modello,Brano[ tracce,double giriMinuti) : base(marca, modello, tracce)
		{
			GiriMinuti = giriMinuti;
		}

        public override string ToString()
        {
            return String.Format("{0,-20} {1,-20} {2,-20} {3,-20}",
               Marca, Modello, Tracce, GiriMinuti);
        }
    }
}
