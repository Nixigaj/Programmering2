using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Tömmer felmeddelandet.
            labelFelmeddelande.Text = "";
        }

        // Skapar en ljudspelare för felmeddelanden.
        System.Media.SoundPlayer errorSound = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Background.wav");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Skickar användaren till Github om man klickar på mitt namn.
            System.Diagnostics.Process.Start("https://github.com/Nixigaj");
        }
    }

    // Ett enum som kan hålla variabel för vilken typ av medie som stoppas in vid en given tidpunkt
    enum medieTyp
    {
        Bok,
        Ljud,
        Film
    }
}
