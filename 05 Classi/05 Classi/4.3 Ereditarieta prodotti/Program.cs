using _4._3_Ereditarieta_prodotti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3_Ereditarieta_prodotti
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            NonAlimentare na = new NonAlimentare("||||| | |", 10.90, "Bello","plastica");
            na.ToString();
            na.ApplicaSconto();


            Console.ReadKey();
        }
    }
}
