using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROV_KAP_2_ERIK_JUNSVED
{
    class FigurBank
    {
        private List<Figur> figurer = new List<Figur>();

        public List<Figur> Figurer
        {
            get { return figurer; }
        }

        public void LäggTillCirkel(string namn, double radie)
        {
            figurer.Add(new Cirkel(namn, Dimension.Dim_2D, radie));
        }

        public void LäggTillRektangel(string namn, double bredd, double höjd)
        {
            figurer.Add(new Rektangel(namn, Dimension.Dim_2D, bredd, höjd));
        }

        public void LäggTillKvadrat(string namn, double sida)
        {
            figurer.Add(new Kvadrat(namn, Dimension.Dim_2D, sida));
        }

        public double BeräknaTotalOmkrets()
        {
            double total = 0;

            foreach (Figur nuvarande in figurer)
            {
                total += nuvarande.BeräknaOmkrets();
            }

            return total;
        }

        public void TaBortAllaFigurer()
        {
            figurer.Clear();
        }

        public void SorteraFigurer()
        {
            figurer.Sort();
        }

        public List<Figur> FåCirklar()
        {
            List<Figur> samling = new List<Figur>();

            foreach (Figur nuvarande in figurer)
            {
                if (nuvarande is Cirkel)
                {
                    samling.Add(nuvarande);
                }
            }

            return samling;
        }

        public List<Figur> FåRektanglar()
        {
            List<Figur> samling = new List<Figur>();

            foreach (Figur nuvarande in figurer)
            {
                if (nuvarande is Rektangel || nuvarande is Kvadrat)
                {
                    samling.Add(nuvarande);
                }
            }

            return samling;
        }
    }
}
