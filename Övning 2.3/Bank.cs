namespace Övning_2._3
{
    class Bank
    {

    }

    abstract class BankKonto
    {
        protected string personNummer;
        protected double behållning;
        protected double ränteSats;

        protected BankKonto(string pn, double rs)
        {
            this.personNummer = pn;
            this.ränteSats = rs;
        }

        protected BankKonto(string pn)
        {
            this.personNummer = pn;
        }

        public double Behållning;
        public abstract void insättning(double belopp);
        public abstract bool Uttag(double belopp);
        public abstract double beräknaRänta();
        public abstract override string ToString();
    }

    class SparKonto : BankKonto
    {
        public SparKonto(string pn, double rs) : base(pn, rs) { }

        public SparKonto(string pn) : base(pn) { }

        public override double beräknaRänta()
        {
            return behållning + (behållning * ränteSats);
        }

        public override void insättning(double belopp)
        {
            behållning += belopp;
        }

        public override string ToString()
        {
            return "Sparkonto: " + personNummer + ": " + behållning;
        }

        public override bool Uttag(double belopp)
        {
            if (behållning - belopp >= 0)
            {
                behållning -= belopp;
                return true;
            }

            else return false;
        }
    }

    class LåneKonto
    {
        
    }
}
