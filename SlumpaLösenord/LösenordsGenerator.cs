using System;

namespace SlumpaLösenord
{
    static class LösenordsGenerator
    {
        static Random random = new Random();

        public static string Generera()
        {
            // "Det där är det värsta jag sett" /Måns
            return
                SlumpadLitenBokstav().ToString() + SlumpadLitenBokstav().ToString() + SlumpadLitenBokstav().ToString() +
                random.Next(0,10).ToString() + random.Next(0, 10).ToString() + random.Next(0, 10).ToString() +
                SlumpadStorBokstav() + SlumpadStorBokstav() + SlumpadStorBokstav();
        }

        private static char SlumpadLitenBokstav()
        {
            return (char) random.Next(97, 123);
        }

        private static char SlumpadStorBokstav()
        {
            return (char) random.Next(65, 91);
        }
    }
}
