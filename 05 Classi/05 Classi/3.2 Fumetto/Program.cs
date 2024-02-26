using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3._2_Fumetto.Models;

namespace _3._2_Fumetto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fumetto[] fumetti = new Fumetto[1];
            string titoloInput;
            string autoreInput;
            double prezzoInput;
            int isbnInput;
            string statoInput;

            for(int i = 0; i < fumetti.Length; i++)
            {
               Console.Write("Inserisci Titolo");
               titoloInput = Console.ReadLine();

               Console.Write("Inserisci Autore");
               autoreInput = Console.ReadLine();

               Console.Write("Inserisci Prezzo");
               prezzoInput = Convert.ToDouble(Console.ReadLine());

               Console.Write("Inserisci ISBN");
               isbnInput = Convert.ToInt32(Console.ReadLine());

               Console.Write("Inserisci Stato");
               statoInput = Console.ReadLine();

                fumetti[i] = new Fumetto(titoloInput, autoreInput,prezzoInput,isbnInput,statoInput);


            }
            Console.WriteLine(fumetti);
            Console.ReadKey();
        }
    }
}
