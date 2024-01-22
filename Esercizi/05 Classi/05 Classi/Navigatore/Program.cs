using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using _05Navigatore.Models;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Navigatore tomTom; //Crea istanza dell'oggetto Navigatore
            Navigatore garmin;
            tomTom = new Navigatore();
            garmin = new Navigatore("Garmin", "X2N", 30);
            Console.WriteLine(tomTom.StampaInformazioni());
            Console.WriteLine(garmin.StampaInformazioni());


            Console.Read(); //Non chiude la finestra
        }
    }
}

