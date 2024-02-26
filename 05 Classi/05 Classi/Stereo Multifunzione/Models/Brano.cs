using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereo_Multifunzione.Models
{
    internal class Brano
    {
		private string _artista;

		public string Artista
		{
			get { return _artista; }
			set { _artista = value; }
		}

		private double _durata;

		public double Durata
		{
			get { return _durata; }
			set { _durata = value; }
		}

		private string _titolo;

		public string Titolo
		{
			get { return _titolo; }
			set { _titolo = value; }
		}

		public Brano(string artista,double durata,string titolo)
		{
			Artista = artista;
			Durata = durata;
			Titolo = titolo;	
		}



	}
}
