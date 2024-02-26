using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_Geometria.Models
{
    // Classe astratta, non puo' essere istanziata e fa da modello per tutte le classi derivate
    internal abstract class Figura
    {
        public abstract int getPerimetro();
    }
}
