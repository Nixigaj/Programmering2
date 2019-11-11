using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROV_KAP_2_ERIK_JUNSVED
{
    abstract class Figur : IComparable
    {
        protected string namn;
        protected Dimension dimension;

        protected Figur(string n, Dimension d)
        {
            this.namn = n;
            this.dimension = d;
        }

        // Get/Set


        public abstract double BeräknaArea();
        public abstract double BeräknaOmkrets();

        public int CompareTo(object obj)
        {
            // Tar in det externa objektet som ska undersökas
            Figur annan = (Figur)obj;

            // Använder objektens implementerade BeräknaArea-metoder
            if (this.BeräknaArea() > annan.BeräknaArea()) return -1;
            else if (this.BeräknaArea() == annan.BeräknaArea())
            {
                if (this.BeräknaOmkrets() > annan.BeräknaOmkrets()) return -1;
                else if (this.BeräknaOmkrets() == annan.BeräknaOmkrets()) return 0; // Förhindrar en exeption när man försöker sortera 16 eller fler med samma area och omkrets.
                else return 1;
            }
            else return 1;
        }
    }

    class Cirkel : Figur
    {
        private double radie;

        public Cirkel(string n, Dimension d, double r) : base(n, d)
        {
            this.namn = n;
            this.dimension = d;
            this.radie = r;
        }

        // Get/Set


        public override double BeräknaArea()
        {
            return radie * radie * Math.PI;
        }

        public override double BeräknaOmkrets()
        {
            return radie * 2 * Math.PI;
        }

        public override string ToString()
        {
            return "Cirkel\tArea: " + BeräknaArea() + "\tOmkrets: " + BeräknaOmkrets() + "\tRadie: " + radie;
        }
    }

    class Rektangel : Figur
    {
        protected double bredd;
        protected double höjd;

        public Rektangel(string n, Dimension d, double b, double h) : base(n, d)
        {
            this.namn = n;
            this.dimension = d;
            this.bredd = b;
            this.höjd = h;
        }

        // Get/Set


        public override double BeräknaArea()
        {
            return bredd * höjd;
        }

        public override double BeräknaOmkrets()
        {
            return bredd * 2 + höjd * 2;
        }

        public override string ToString()
        {
            return "Rektangel\tArea: " + BeräknaArea() + "\tOmkrets: " + BeräknaOmkrets() + "\tBredd: " + bredd + "\tHöjd: " + höjd;
        }
    }

    class Kvadrat : Rektangel
    {
        public Kvadrat(string n, Dimension d, double sida) : base(n, d, sida, sida)
        {
            this.namn = n;
            this.dimension = d;
            this.bredd = sida;
            this.höjd = sida;
        }

        // Get/Set


        public override string ToString()
        {
            // Spelar ingen roll om man ger bredd eller höjd
            return "Kvadrad\tArea: " + BeräknaArea() + "\tOmkrets: " + BeräknaOmkrets() + "\tSida: " + bredd;
        }
    }

    enum Dimension
    {
        Dim_2D,
        Dim_3D
    }
}
