namespace Övning_2._1
{
    class Film : Ljudspår
    {
        // Standardupplösningen är 1080p.
        protected upplösning upplösning = upplösning._1080p;

        // Tar emot från ljudspår.
        public Film(string titel, medieTyp medieTyp, int antalTimmar, int antalMinuter, int antalSekunder, upplösning upplösning) : base(titel, medieTyp, antalTimmar, antalMinuter, antalSekunder)
        {
            // Ger värden till de ärvda variablerna.
            this.titel = titel;
            this.medieTyp = medieTyp;
            this.antalTimmar = antalTimmar;
            this.antalMinuter = antalMinuter;
            this.antalSekunder = antalSekunder;
            this.upplösning = upplösning;
        }

        public string[] getValues()
        {
            string[] egenskaper = { titel, "Film", TimeToString(), getUpplösning() };
            return egenskaper;
        }

        private string getUpplösning()
        {
            if (upplösning == upplösning._144p) return "144p";
            else if (upplösning == upplösning._240p) return "240p";
            else if (upplösning == upplösning._360p) return "360p";
            else if (upplösning == upplösning._480p) return "480p";
            else if (upplösning == upplösning._720p) return "720p";
            else if (upplösning == upplösning._1080p) return "1080p";
            else if (upplösning == upplösning._1440p) return "1440p";
            else if (upplösning == upplösning._2160p) return "2160p";
            else if (upplösning == upplösning._2880p) return "2880p";
            else if (upplösning == upplösning._4320p) return "4320p";
            else return "";
        }
    }

    // Olika upplösningar.
    enum upplösning
    {
        _144p,
        _240p,
        _360p,
        _480p,
        _720p,
        _1080p,
        _1440p,
        _2160p,
        _2880p,
        _4320p
    }
}
