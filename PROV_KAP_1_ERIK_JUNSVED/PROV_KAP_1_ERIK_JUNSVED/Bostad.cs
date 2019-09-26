using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROV_KAP_1_ERIK_JUNSVED
{
    class Bostad
    {
        // 4 Medlemsvariabler
        private string objektNummer;
        private int boyta;
        private int pris;
        private bostadsTyp bostadsTyp;

        // Konstruktor-metod med de initierande 4 variablerna
        public Bostad(string on, int b, int p, bostadsTyp bt)
        {
            this.objektNummer = on;
            this.boyta = b;
            this.pris = p;
            this.bostadsTyp = bt;
        }

        // Tilldela och efterfråga värden i objektet
        public string ObjektNummer
        {
            get { return this.objektNummer; }
            set { this.objektNummer = value; }
        }

        public int Boyta
        {
            get { return this.boyta; }
            set { this.boyta = value; }
        }

        public int Pris
        {
            get { return this.pris; }
            set { this.pris = value; }
        }

        public bostadsTyp BostadsTyp
        {
            get { return this.bostadsTyp; }
            set { this.bostadsTyp = value; }
        }

        // Returnerar en kvot
        public double PrisPerKvm(int boyta, int pris)
        {
            // Omvandlar till double för division med decimal
            return ((double)pris) / ((double)boyta);
        }

        // Skapar en sträng som presenterar datan i objektet
        public override string ToString()
        {
            return this.objektNummer + ", " + this.boyta + "KVM, " + this.pris + "kr, " + this.bostadsTyp;
        }
    }

    // De 2 bostadstyperna
    enum bostadsTyp
    {
        Lägenhet,
        Villa,
    }
}
