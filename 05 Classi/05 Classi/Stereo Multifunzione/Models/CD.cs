using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereo_Multifunzione.Models
{
    internal class CD : Supporto
    {
		private int _dimensione;

		public int Dimensione
		{
			get { return _dimensione; }
			set { _dimensione = value; }
		}

		private int _capacitaAudio;

		public int CapacitaAudio
		{
			get { return _capacitaAudio; }
			set { _capacitaAudio = value; }
		}


		public CD(string marca,string modello,Brano[] tracce,int dimensione,int capacitaAudio) : base(marca, modello, tracce)
		{
			Dimensione = dimensione;
			CapacitaAudio = capacitaAudio;
		}

        public override string ToString()
        {
            return String.Format("{0,-20} {1,-20} {2,-20} {3,-20} {4,-20}",
               Marca, Modello, Tracce, Dimensione, CapacitaAudio);
        }
    }
}
