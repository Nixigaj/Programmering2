namespace Övning_2._1
{
    class Media
    {
        protected string titel = "";
        protected medieTyp medieTyp = medieTyp.Bok;

        public Media(string titel, medieTyp medieTyp)
        {
            this.titel = titel;
            this.medieTyp = medieTyp;
        }

        public medieTyp MedieTyp()
        {
            return this.medieTyp;
        }
    }

    

    // Ett enum som kan hålla variabel för vilken typ av medie som stoppas in vid en given tidpunkt
    enum medieTyp
    {
        Bok,
        Ljudspår,
        Film
    }
}

