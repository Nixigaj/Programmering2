using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._2
{
    class Anställd
    {
        private string namn;

        public Anställd(string namn)
        {
            this.namn = namn;
        }

        public double beräknaLön()
        {
            return 0.0;
        }

        public override string ToString()
        {
            return namn + " (Anställd)";
        }
    }
}
