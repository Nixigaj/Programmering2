using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROV_KAP_2_ERIK_JUNSVED
{
    public partial class Form1 : Form
    {
        private FigurBank bank;
        public Form1()
        {
            InitializeComponent();
        }

        private void UppdateraVy()
        {
            listBoxFigurbank.Items.Clear();

            if (radioButtonAllaFig.Checked)
            {
                foreach (Figur nuvarande in bank.Figurer)
                {
                    listBoxFigurbank.Items.Add(nuvarande.ToString());
                }
            }

            else if (radioButtonCirklar.Checked)
            {
                foreach (Figur nuvarande in bank.FåCirklar())
                {
                    listBoxFigurbank.Items.Add(nuvarande.ToString());
                }
            }

            else if (radioButtonRektanglar.Checked)
            {
                foreach (Figur nuvarande in bank.FåRektanglar())
                {
                    listBoxFigurbank.Items.Add(nuvarande.ToString());
                }
            }
        }

        private void RensaFält()
        {
            textBoxRadie.Text = "";
            textBoxBredd.Text = "";
            textBoxHöjd.Text = "";
            textBoxSida.Text = "";
        }

        private void ButtonAddCirkel_Click(object sender, EventArgs e)
        {
            try
            {
                bank.LäggTillCirkel("Cirkel", Convert.ToDouble(textBoxRadie.Text));
            }
                
            catch (System.FormatException)
            {
                MessageBox.Show("Vänligen ange tal.");
            }

            
            UppdateraVy();
            RensaFält();
        }

        private void ButtonAddRektangel_Click(object sender, EventArgs e)
        {
            try
            {
                bank.LäggTillRektangel("Rektangel", Convert.ToDouble(textBoxBredd.Text), Convert.ToDouble(textBoxHöjd.Text));
            }

            catch (System.FormatException)
            {
                MessageBox.Show("Vänligen ange tal.");
            }


            UppdateraVy();
            RensaFält();
        }

        private void ButtonAddKvadrat_Click(object sender, EventArgs e)
        {

        }
    }
}
