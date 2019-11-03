namespace Övning_2._8
{
    abstract class Vara
    {
        protected string namn;

        public Vara(string n)
        {
            this.namn = n;
        }

        public string Namn() { return this.namn; }

        abstract public double BeräknaPris();
    }

    class LösVikt : Vara
    {
        protected double kiloPris;
        protected double vikt;

        public LösVikt(string n, double p, double v) : base(n)
        {
            this.namn = n;
            this.kiloPris = p;
            this.vikt = v;
        }

        public double KiloPris() { return this.kiloPris; }
        public double Vikt() { return this.vikt; }

        override public double BeräknaPris()
        {
            return this.vikt * this.kiloPris;
        }

        class StyckSak : Vara
        {
            protected double styckPris;
            protected int antal;

            public StyckSak(string n, double p, int a) : base(n)
            {
                this.namn = n;
                this.styckPris = p;
                this.antal = a;
            }

            public double KiloPris() { return this.styckPris; }
            public int Vikt() { return this.antal; }

            override public double BeräknaPris()
            {
                return this.antal * this.styckPris;
            }
        }
    }
}
