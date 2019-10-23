using System;
using System.Windows.Forms;

namespace Övning_2._2
{
    public partial class formStart : Form
    {
        System.Media.SoundPlayer errorSound = new System.Media.SoundPlayer("C:/Windows/media/Windows Background.wav");
        // C:/Windows/media/Windows Background.wav

        System.Collections.Generic.List<Anställd> allaAnställda = new System.Collections.Generic.List<Anställd>();

        public formStart()
        {
            InitializeComponent();
        }

        private void ButtonRegFörsäljning_Click(object sender, EventArgs e)
        {
            allaAnställda.Add(new Säljare(
                textBoxSäljarNamn.Text,
                Convert.ToDouble(textBoxProvision.Text),
                Convert.ToDouble(textBoxFörsäljning.Text)
                ));

            uppdateraRegister();

            
        } 
        private void ButtonRegArbetspass_Click(object sender, EventArgs e)
        {
            allaAnställda.Add(new Konsult(
                textBoxKonsultNamn.Text,
                Convert.ToDouble(textBoxTimlön.Text),
                Convert.ToDouble(textBoxArbetadTid.Text)
                ));

            uppdateraRegister();
        }

        private void buttonRegMånslön_Click(object sender, EventArgs e)
        {
            allaAnställda.Add(new Kontorist(
                textBoxKontoristnamn.Text,
                Convert.ToDouble(textBoxMånadslön.Text)
                ));

            uppdateraRegister();
        }

        private void uppdateraRegister()
        {
            listBoxRegister.Items.Clear();

            foreach(Anställd nuvarande in allaAnställda)
            {
                listBoxRegister.Items.Add(nuvarande.ToString());
            }
        }

        private void uppdateraLöneutbetalningar()
        {
            listBoxLöneutbetalningar.Items.Clear();

            foreach (Anställd nuvarande in allaAnställda)
            {
                listBoxLöneutbetalningar.Items.Add(nuvarande.ToString() + ", " + nuvarande.BeräknaLön() + " kr");
            }
        }

        private void buttonBeräknaLöner_Click(object sender, EventArgs e)
        {
            uppdateraLöneutbetalningar();

            double total = 0;

            foreach (Anställd nuvarande in allaAnställda)
            {
                total += nuvarande.BeräknaLön();
            }

            textBoxTotalLönekostnad.Text = total.ToString() + " kr";
        }
    }
}
