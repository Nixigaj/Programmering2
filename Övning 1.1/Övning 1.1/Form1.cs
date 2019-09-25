using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private int omvandla_Sträng_Till_Tal(string text)
        {

            int tal = 0;

            int startvärde;
            if (text[0] == '-') { startvärde = 1; }
            else { startvärde = 0; }

            int heltalsvärde = ;

            for (int postition = startvärde; postition >= text.Length-1; postition++)
            {
                heltalsvärde /= 10;

                
            }

            
            
        }

        private int pow10(int exponent)
        {
            int resultat = 1;
            for (int i = 0; i < exponent; i++) { resultat *= 10; }
            return resultat;
        }
    }
}
