using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlumpaLösenord
{
    class LösenordsGenerator
    {
        Random random = new Random();

        public static string Generera()
        {
            return SlumpadLitenBokstav();
            
        }

        private static string SlumpadLitenBokstav()
        {
            return (char) random.Next(97, 123);
        }

        private static char SlumpadStorBokstav()
        {
            return (char) random.Next(65, 91);
        }
    }
}
