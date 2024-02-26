using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3._1_Lattina.Models;

namespace _3._1_Lattina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lattina[] can = new Lattina[2];
            double raggio;
            double altezza;

            for(int i =  0; i < can.Length; i++)
            {
                Console.Write("Inserisci raggio: ");
                raggio = Convert.ToDouble(Console.ReadLine());
                Console.Write("Inserisci altezza: ");
                altezza = Convert.ToDouble(Console.ReadLine());

                can[i] = new Lattina(raggio, altezza);
            }

            foreach(Lattina l in can)
            {
                Console.Write(l);
            }
        }
    }
}
