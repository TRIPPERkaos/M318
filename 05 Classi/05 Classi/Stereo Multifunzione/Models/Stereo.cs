using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereo_Multifunzione
{
    internal class Stereo
    {
        private string _modello;

		public string Modello
		{
			get { return _modello; }
			set { _modello = value; }
		}

		public Stereo(string modello) 
		{
			Modello = modello;
		}

		public void InserisciSupportoCassetta()
		{

		}

		public void InserisciSupportoVinile()
		{

		}

		public void InserisciSupportoCD()
		{

		}

		public void RimuoviSupportoCassette()
		{

		}

		public void RimuoviSupportoVinile()
		{

		}

		public void RimuoviSupportoCD()
		{

		}

		public void PlayCD()
		{

		}

		public void PlayVinile() 
		{
			
		}

		public void PlayCassetta()
		{

		}

		public void Stop()
		{

		}

	}
}
