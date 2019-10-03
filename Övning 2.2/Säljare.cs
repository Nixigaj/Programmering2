using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._2
{
    class Säljare : Anställd
    {
        private double provision;
        private double försäljning;

        public Säljare(string n, double p, double f) : base(n)
        {
            this.namn = n;
            this.provision = p;
            this.försäljning = f;
        }

        public override double BeräknaLön()
        {
            return försäljning * provision / (double)100;
        }

        public override string ToString()
        {
            return namn + " (Säljare)";
        }
    }
}
