using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlumpaLösenord
{
    class Inloggningar
    {
        private List<string> allaInloggningar = new List<string>();
        private List<string> allaAnvändarnamn = new List<string>();
        private List<string> allaLösenord = new List<string>();
        private string filväg;
        Random random = new Random();

        public Inloggningar(string filväg)
        {
            this.filväg = filväg;
            allaLösenord.Add(LösenordsGenerator.Generera());
        }

        public void LäggTill(string användarnamn)
        {
            allaAnvändarnamn.Add(användarnamn);
            allaLösenord.Add(LösenordsGenerator.Generera());
        }

        public void SkrivTillFil()
        {
            Sammanställ();


        }

        public List<string> GetValues()
        {
            Sammanställ();
            return allaInloggningar;
        }

        private void Sammanställ()
        {
            allaInloggningar.Clear();
            allaInloggningar.Add("Användarnam\tLösenord");

            int index = 0;

            foreach (string nuvarande in allaAnvändarnamn)
            {
                allaInloggningar.Add(nuvarande + "\t\t" + allaLösenord[index]);
                index++;
            }
        }

        public string NästaLösen()
        {
            return allaLösenord[allaLösenord.Count - 1];
        }
    }
}
