using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._2
{
    class Konsult : Anställd
    {
        private double arbetadeTimmar;
        private double timLön;

        public Konsult(string n, double a, double t) : base(n)
        {
            this.namn = n;
            this.arbetadeTimmar = a;
            this.timLön = t;
        }

        public override double BeräknaLön()
        {
            return timLön * arbetadeTimmar;
        }

        public override string ToString()
        {
            return namn + " (Konsult)";
        }
    }
}
