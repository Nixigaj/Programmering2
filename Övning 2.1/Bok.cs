namespace Övning_2._1
{
    class Bok : Media
    {
        // Standardantal sidor är noll.
        protected int antalSidor = 0;

        // Tar emot från media.
        public Bok(string titel, medieTyp medieTyp, int antalSidor) : base(titel, medieTyp)
        {
            // Ger ett värde till den ärvda variabeln.
            this.titel = titel;
            this.medieTyp = medieTyp;
            this.antalSidor = antalSidor;
        }

        public string[] getValues()
        {
            string[] egenskaper = { titel, "Bok", antalSidor.ToString() + " sidor" };
            return egenskaper;
        }
    }
}
