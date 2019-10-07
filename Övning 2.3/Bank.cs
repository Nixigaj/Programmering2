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
        public SparKonto(string pn) : base(pn)
        {

        }

        public SparKonto(string pn, double rs) : base(pn, rs)
        {

        }

        public override double beräknaRänta()
        {
            throw new System.NotImplementedException();
        }

        public override void insättning(double belopp)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

        public override bool Uttag(double belopp)
        {
            throw new System.NotImplementedException();
        }
    }

    class LåneKonto
    {

    }
}
