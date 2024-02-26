using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_Equation.Models
{
    internal class Equation
    {
		private double _a;

		public double A
		{
			get { return _a; }
			set {
				if (_a.Equals(0))
				{
					Console.WriteLine("Il valore 0 non è accettato");
					_a = value;
				}
			}
		}

		private double _b;

		public double B
		{
			get { return _b; }
			set { _b = value; }
		}

		private double _c;

		public double C
		{
			get { return _c; }
			set { _c = value; }
		}

		private double _delta;
		public double Delta
		{
			get { return _delta; }
			set { _delta = value; }
		}

		private double _root1;
		public double Root1
		{
			get { return _root1; }
			set { _root1 = value; }
		}

		private double _root2;
		public double Root2
		{
			get { return _root2; }
			set { _root2 = value; }
		}

        public Equation(double a, double b, double c)
        {
             A = a;
			 B = b;
			 C = c;
        }

		public void Roots()
		{
			Delta = Math.Sqrt(Math.Pow(_b, 2) - 4*_a*_c);
			Root1 = (-_b + Delta) / 2*_a;
			Root2 = (-_b - Delta) / 2 * _a;
        }

		public double Y(double x)
		{
			
		}

    }
}
