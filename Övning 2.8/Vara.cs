using System;

namespace Övning_2._8
{
    // Klassen har sortering implementerad
    abstract class Vara : IComparable
    {
        protected string namn;

        // Namn ska vara gemensamt och kunna anropas på alla instanser av Vara
        public Vara(string n)
        {
            namn = n;
        }

        public string Namn() { return namn; }

        // Alla ärvande klasser kan sortera på pris eftersom att BeräknaPris() måste implementeras
        public abstract double BeräknaPris();

        // Retunerar de olika värdena som strängar
        public abstract string[] GetValues();

        public int CompareTo(object obj)
        {
            // Tar in det externa objektet som ska undersökas
            Vara annan = (Vara)obj;

            // Använder objektens implementerade BeräknaPris-metoder
            if (this.BeräknaPris() > annan.BeräknaPris()) return 1;
            else return -1;
        }
    }


    sealed class LösVikt : Vara
    {
        // Enheten för vikt är kilogram
        private double kiloPris;
        private double vikt;

        public LösVikt(string n, double p, double v) : base(n)
        {
            namn = n;
            kiloPris = p;
            vikt = v;
        }

        public double KiloPris() { return kiloPris; }
        public double Vikt() { return vikt; }

        public override double BeräknaPris()
        {
            return vikt * kiloPris;
        }

        public override string[] GetValues()
        {
            return new string[]
            {
                vikt.ToString() + " kg",
                namn,
                "Lösvikt",
                kiloPris.ToString() + " kr/kg",
                Convert.ToString(BeräknaPris()) + " kr"
            };
        }
    }

    sealed class StyckSak : Vara
    {
        private double styckPris;
        private int antal;

        public StyckSak(string n, double p, int a) : base(n)
        {
            namn = n;
            styckPris = p;
            antal = a;
        }

        public double StyckPris() { return styckPris; }

        override public double BeräknaPris()
        {
            return antal * styckPris;
        }

        public override string[] GetValues()
        {
            return new string[]
            {
                antal.ToString() + " st.",
                namn,
                "Styckvara",
                styckPris.ToString() + " kr/st",
                Convert.ToString(BeräknaPris()) + " kr"
            };
        }
    }
}
