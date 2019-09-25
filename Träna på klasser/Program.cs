using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Träna_på_klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Bok minBok1 = new Bok(120, "Harry Potter", "JK Rowling");
            Bok minBok2 = new Bok(15, "Bamse", "Rune");
            List<Bok> böcker = new List<Bok>();
            böcker.Add(minBok1);
            böcker.Add(minBok2);
            foreach(Bok bok in böcker)
            {
                Console.Write(bok);
            }

            Console.ReadKey();
        }
    }
}
