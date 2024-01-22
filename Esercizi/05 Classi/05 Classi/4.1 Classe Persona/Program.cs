using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4._1_Classe_Persona.Models;

namespace _4._1_Classe_Persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************Persona*************************");
            Persona p = new Persona("dsads","Alfonso","Bonomelli");
            Console.WriteLine(p.ToString());

            Console.WriteLine("********************Studente*************************");
            Studente s = new Studente("dsabdab", "Alfredo", "Manni", "888", "Milano");
            Console.WriteLine(s.ToString());

            Console.WriteLine();

            Console.WriteLine("********************Docente*************************");
            Docente d = new Docente("dbashd", "Flavio", "Mauri", "Filosofia", 2200.23);
            Console.WriteLine(d.ToString());

            Console.ReadKey();
        }
    }
}
