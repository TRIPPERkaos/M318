using _05_Clown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Clown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clown[] clowns = new Clown[2];
            string nome;
            double peso;
            double altezza;

            for(int i = 0; i < clowns.Length; i++)
            {
                Console.Write("Inserisci il nome del clown: ");
                nome = Console.ReadLine();
                Console.Write("Inserisci il peso del clown: ");
                peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Inserisci l'altezza del clown: ");
                altezza = Convert.ToDouble(Console.ReadLine());

                clowns[i] = new Clown(nome, peso, altezza);

            }

            foreach(Clown c in clowns)
            {
                Console.WriteLine(c);
            }
            Console.Read();
        }
    }
}
