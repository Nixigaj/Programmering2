using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fordon_Improved
{
    class Fordon
    {
        // Medlemsvariablerna
        private string regNr;
        private string märke;
        private string modell;
        private fordonsTyp typ;

        // Konstruktor som anropar samtliga variabler
        public Fordon(string regNr, string märke, string modell, fordonsTyp typ)
        {
            this.regNr = regNr;
            this.märke = märke;
            this.modell = modell;
            this.typ = typ;
        }

        public string RegNr
        {
            get { return this.regNr; }
            set { regNr = value; }
        }

        public string Märke
        {
            get { return this.märke; }
            set { this.märke = value; }
        }

        public string Modell
        {
            get { return this.modell; }
            set { this.modell = value; }
        }

        public fordonsTyp FordonsTyp
        {
            get { return this.typ; }
            set { typ = value; }
        }

        public static bool GodkännRegNr (string regNr)
        {
            if (regNr.Length == 6)
            {
                string bokstäver = regNr.Substring(0, 3);
                string siffror = regNr.Substring(3, 3);

                if (Regex.IsMatch(bokstäver, @"^[a-zA-Z]+$") && Regex.IsMatch(siffror, @"^[0-9]+$"))
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
        /*
        public override string ToString()
        {
            return this.regNr + " " + this.märke + ", " + this.modell + " (" + this.typ + ")";
        }
        */
    }



    enum fordonsTyp
    {
        Bil,
        MC
    }
}
