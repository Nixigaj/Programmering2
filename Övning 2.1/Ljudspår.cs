namespace Övning_2._1
{
    class Ljudspår : Media
    {
        // Standardtiden är noll.
        protected int antalTimmar = 0;
        protected int antalMinuter = 0;
        protected int antalSekunder = 0;

        // Tar emot från media.
        public Ljudspår(string titel, medieTyp medieTyp, int antalTimmar, int antalMinuter, int antalSekunder) : base(titel, medieTyp)
        {
            // Ger ett värde till den ärvda variabeln.
            this.titel = titel;
            this.medieTyp = medieTyp;
            this.antalTimmar = antalTimmar;
            this.antalMinuter = antalMinuter;
            this.antalSekunder = antalSekunder;
        }

        public string[] getValues()
        {
            string[] egenskaper = { titel, "Ljud", TimeToString() };
            return egenskaper;
        }

        // Returnerar tiden som en sträng i timecode: HH:MM:SS.
        public string TimeToString()
        {
            return antalTimmar + ":" + antalMinuter + ":" + antalSekunder;
        }
    }
}
