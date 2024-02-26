using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Navigatore.Models
{
    public class Navigatore
    {
        #region Attributi
        //Attributi della classe Navigatore
        public string Marca;
        public int Dimensioni;
        public string Modello;
        //---------------------------------
        #endregion

        #region Costruttori
        public Navigatore() { // --> Valori di default
            Marca = "Sconosciuta";
            Dimensioni = 0;   
            Modello = "Sconosciuto";
        }

        public Navigatore(string marca,string modello,int dimensioni) { 
            Marca = marca;
            Dimensioni = dimensioni;
            Modello = modello;
        }
        #endregion

        #region Metodi public
        //Metodi della classe Navigatore

        /// <summary>Metodo che trova il percorso</summary>
        /// <param name = "percorso">Luogo da raggiungere (destinazione)</param>
        /// <returns>Percorso da effettuare</returns>
        public void TrovaPercorso()
        {
            //Implementare codice metodo
        }

        /// <summary>Metodo che calcola la destinazione<summary>
        /// <param name = "destinazione">Destinazione da raggiungere</param>
        /// <returns>Tempo di percorrenza</returns>
        public void InserireDestinazione()
        {
            //Implementare codice metodo
        }

        /// <summary>Metodo che calcola la deviazione di percorso</summary>
        /// <param name = "deviazione">Luogo da evitare</param>
        /// <returns>Percorso alternativo</returns>
        public void InserireDeviazione()
        {
            //Implementare codice metodo
        }

        /// <summary>Metodo che calcola la distanza totale</summary>
        /// <param name = "distanza">Luoghi da raggiungere</param>
        /// <returns>Distanza totale</returns>
        public void DistanzaTotale()
        {
            //Implementare codice metodo
        }

        /// <summary>Metodo che calcola il tempo</summary>
        /// <param name = "tempo">Destinazione da raggiungere</param>
        /// <returns>Tempo di percorrenza</returns>
        public void TempoTotale()
        {
            //Implementare codice metodo
        }

        /// <summary>Metodo che stampa informazioni sugli attributi</summary>
        /// <returns>Informazioni sugli attributi</returns>
        public string StampaInformazioni()
        {
            return "Marca: " + Marca + " ; " + "Dimensioni: " + Dimensioni + " ; " + "Modello" + Modello;
        }

        //---------------------------------
        #endregion
    }
}
