using System;

namespace MetodCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



        }

        public bool GodkännRegNr(string regNr)
        {
            string bokstäver;
            string siffror;

            if (regNr.Length == 6)
            {
                bokstäver = regNr.Substring(0, 3);
                siffror = regNr.Substring(3, 7);

                if (
                    Regex.IsMatch(bokstäver, @"^[a-zA-Z]+$") &&
                    Regex.IsMatch(siffror, @"^[0-9]+$")
                    )
                { return true; }

                else { return false; }
            }
            else { return false; }
        }
    }
}
