using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Träna_på_klasser
{
    class Bok
    {
        // Medlemsvariabkerna
        private int antalSidor;
        private string titel;
        private string författare;

        // Konstruktor
        // Här skapas objektet när new Bok() anropas.
        public Bok(int antalSidor, string titel, string författare)
        {
            this.antalSidor = antalSidor;
            this.titel = titel;
            this.författare = författare;
        }
        
        public string Titel
        {
            get { return this.titel; }
        }

        public int AntalSidor
        {
            set { this.antalSidor = value; }
        }

        public int Författare
        {
            set { this.antalSidor = value; }
        }

        override // Betyder att vu sja sjruva över metoden ToString i klassen object.
        public string ToString()
        {
            string beskrivning = "";
            beskrivning += "Titel: " + this.titel + "\n";
            beskrivning += "Antal sidor: " + this.antalSidor + "\n";
            beskrivning += "Författare: " + this.titel;
            
            return beskrivning;
        }
    }
}
