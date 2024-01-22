using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_Geometria.Models
{
    internal class Triangolo : Figura
    {
        private int _latoA;

        public int LatoA
        {
            get { return _latoA; }
            set { _latoA = value; }
        }

        private int _latoB;

        public int LatoB
        {
            get { return _latoB; }
            set { _latoB = value; }
        }

        private int _latoC;

        public int LatoC
        {
            get { return _latoC; }
            set { _latoC = value; }
        }

        public Triangolo(int latoA, int latoB, int latoC)
        {
            LatoA = latoA;
            LatoB = latoB;
            LatoC = latoC;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int getPerimetro()
        {
            return LatoA + LatoB + LatoC;
        }
    }
}
