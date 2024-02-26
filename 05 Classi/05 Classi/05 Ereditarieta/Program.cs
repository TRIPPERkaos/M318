using _05_Ereditarieta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Ereditarieta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cane c = new Cane(true,"Pluto");
            Console.WriteLine(c.Abbaia());
            c.Dormire();
            c.EmettiVerso();

            Console.ReadKey();
        }
    }
}
