using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._2
{
    class Anställd
    {
        protected string namn;

        public Anställd(string n)
        {
            this.namn = n;
        }

        public virtual double BeräknaLön()
        {
            return 0.0;
        }

        public override string ToString()
        {
            return namn + " (Anställd)";
        }
    }
}
