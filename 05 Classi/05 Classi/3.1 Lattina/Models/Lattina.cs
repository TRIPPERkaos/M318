using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_Lattina.Models
{
    internal class Lattina
    {
        #region Membri e proprietà

        private double _altezza;
        public double Altezza
        {
            get { return _altezza; }
            set 
            { 
                if( value <= 0)
                {
                    _altezza = 0.0;
                }

                else
                {
                    _altezza = value;
                }
            }
        }

        private double _raggio;
        public double Raggio
        {
            get { return _raggio; }
            set 
            { 
                if(value <= 0)
                {
                    _raggio = 0.0;
                }

                else
                {
                    _raggio= value;
                }
            }
        }
        #endregion

        #region Costruttori
        public Lattina(double raggio, double altezza)
        {
            _raggio = raggio;
            _altezza = altezza;
        }
        #endregion

        #region Metodi Public
        public double SuperficieLaterale()
        {
            return Circonferenza() * _altezza;
        }
        
        public double SuperficieTotale()
        {
            return SuperficieLaterale() + AreaBase() * 2;
        }

        public double Volume()
        { 
            return Math.Pow(_raggio, 2) * Math.PI * _altezza;
        }
        #endregion

        #region Metodi Private
        private double Circonferenza()
        {
            return _raggio * 2 * Math.PI;
        }

        private double AreaBase()
        {
            return Math.Pow(_raggio, 2) * Math.PI;
        }
        #endregion
    }
}
