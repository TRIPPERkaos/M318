using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_Fumetto.Models
{
    internal class Fumetto
    {   
        private string _titolo;
        private string _autore;
        private int _annoPubblicazione;
        private double _prezzo;

        public string Titolo
        {
            get { return _titolo; }
            set { _titolo = value;} 
        
        }

        public string Autore
        {
            get { return _autore;}
            set { _autore = value;}
        }

        public int AnnoPubblicazione
        {
            get { return _annoPubblicazione;}
            set { _annoPubblicazione = value;}
        }
        public double Prezzo
        {
            get { return _prezzo; }
            set 
            { 
                if (_prezzo <= 0.0)
                {
                    Console.WriteLine("Il prezzo deve essere maggiore di 0.0");
                }
                else
                {
                    _prezzo = value;
                }
            }
        }
        private string _breveDescrizione;
        public string BreveDescrizione
        {
            get { return _breveDescrizione; }
            set
            {
                if(_breveDescrizione == "")
                {
                    _breveDescrizione = "Nessuna descrizione";
                }

                else
                {
                    _breveDescrizione = value;
                }
            }
        }
        private int _isbn;
        private string _stato;
        public string Stato
        {
            get { return _stato; }
            set
            {
                if(_stato != "Nuovo" || _stato != "nuovo" || _stato != "Usato" || _stato != "usato")
                {
                    Console.WriteLine("Il libro deve essere nuovo o usato...");
                }

                else
                {
                    _stato = value;
                }
            } 
        }


        #region costruttori
        public Fumetto() 
        {
            _titolo = "Sconosciuto";
            _autore = "Sconosciuto";
            _annoPubblicazione = 0;
            _prezzo = 0.0;
            _breveDescrizione = "...";
            _isbn = 0;
            _stato = "Sconosciuto";

        }

        public Fumetto(string titolo, string autore, double prezzo, int isbn, string stato)
        {
            _titolo = titolo;
            _autore = autore;
            _prezzo = prezzo;
            _isbn = isbn;
            _stato = stato;
        }


        #endregion

        #region Metodi Public

        public override string ToString()
        {   
            //Place Holders (x,-20)  (x) --> servono a fare riferimento a quale elemento si riferiscie (in base alla posizione)
            //l'attributo viene posizionato a 20 da sinistra (-20) con (20) avrebbe messso da destra
            // "|" è il carattere che li separa, si può mettere qualunque cosa anche niente (e fa semplicemente degli spazi)
            string description = String.Format("{0,-20} | {1,-20} | {2,-20} | {3,-20} | {4,-20}",
                checkString(Titolo), checkString(Autore), AnnoPubblicazione, Prezzo, checkString(Stato));
            return description;
        }
        public void ritornaInfo()
        {
            string line = "-----------------------------------------------------";
            string[] indici = { "Titololo: ", "Autore: ", "Anno Pubblicazione: ", "Prezzo: ", "Breve Descrizione: ", "ISBN: ", "Stato: " };
            string[] valori = { _titolo, _autore, Convert.ToString(_annoPubblicazione), Convert.ToString(_prezzo), _breveDescrizione, Convert.ToString(_isbn), _stato };
            int pos = 0;

            for (int i = 0; i < valori.Length; i++)
            {
                Console.WriteLine(line);
                Console.WriteLine(indici[pos] + valori[pos]);
                pos += 1;

            }
        }
        #endregion

        #region Metodi Private
        public string checkString(string stringa)
        {
            string s = stringa;
            if(stringa.Length > 20)
            {
                s = stringa.Substring(0, 17) + "."; // Si poteva metterre un return anche qua (però nel modo in cui lo si è fatto ora, si è tolta la rindondanza di return)
            }
            return s;
        }
        #endregion
    }
}
