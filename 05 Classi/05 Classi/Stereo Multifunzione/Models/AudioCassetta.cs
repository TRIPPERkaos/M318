using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereo_Multifunzione.Models
{
    internal class AudioCassetta : Supporto
    {
		private double _lunghezzaNastro;

		public double LunghezzaNastro
		{
			get { return _lunghezzaNastro; }
			set { _lunghezzaNastro = value; }
		}

		public AudioCassetta(string marca,string modello,Brano[] tracce,double lunghezzaNastro) : base(marca, modello, tracce)
		{
			LunghezzaNastro = lunghezzaNastro;
		}

        public override string ToString()
        {
            return String.Format("{0,-20} {1,-20} {2,-20} {3,-20}",
               Marca, Modello, Tracce, LunghezzaNastro);
        }

    }
}
