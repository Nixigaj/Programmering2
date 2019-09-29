using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._1
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();

            // Kopplar innehållet av fordonsTyp enumet till
            comboBoxUpplösning.DataSource = Enum.GetValues(typeof(upplösning));
        }

        List<Media> allMedia = new List<Media>();

        private async System.Threading.Tasks.Task tomTitelMeddelandeAsync()
        {
            // Skapar en ljudspelare för felmeddelanden.
            System.Media.SoundPlayer errorSound = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Background.wav");
            errorSound.Play();

            // Skapar två typsnittsstilar att växla mellan.
            Font underline = new Font(labelTitelTomFel.Font, FontStyle.Underline);
            Font regular = new Font(labelTitelTomFel.Font, FontStyle.Regular);

            // Visuell sekvens:

            labelTitelTomFel.Font = underline;
            labelTitelTomFel.Visible = true;
            await Task.Delay(100);
            labelTitelTomFel.Font = regular;
            await Task.Delay(100);
            labelTitelTomFel.Font = underline;
            await Task.Delay(100);
            labelTitelTomFel.Font = regular;
            await Task.Delay(100);
            labelTitelTomFel.Font = underline;
            await Task.Delay(100);
            labelTitelTomFel.Font = regular;
        }

        private void pictureBoxEJ_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Nixigaj");
        } // Skickar användaren till Github om man klickar på mitt namn.

        private void buttonRegistreraSpara_Click(object sender, EventArgs e)
        {
            upplösning valdUpplösning;
            Enum.TryParse<upplösning>(comboBoxUpplösning.SelectedValue.ToString(), out valdUpplösning);

            if (textBoxTitel.Text.Length != 0)
            {
                // Tar emot bokens egenskaper.
                if (valdTyp() == medieTyp.Bok) allMedia.Add(new Bok(
                    textBoxTitel.Text,
                    valdTyp(),
                    Convert.ToInt32(numericUpDownSidorLrTimmar.Value)
                    ));

                // Tar emot ljudspårets egenskaper.
                else if (valdTyp() == medieTyp.Ljudspår) allMedia.Add(new Ljudspår(
                    textBoxTitel.Text,
                    valdTyp(),
                    Convert.ToInt32(numericUpDownSidorLrTimmar.Value),
                    Convert.ToInt32(numericUpDownMinuter.Value),
                    Convert.ToInt32(numericUpDownSekunder.Value)
                    ));

                // Tar emot ljudspårets egenskaper.
                else if (valdTyp() == medieTyp.Film) allMedia.Add(new Film(
                    textBoxTitel.Text,
                    valdTyp(),
                    Convert.ToInt32(numericUpDownSidorLrTimmar.Value),
                    Convert.ToInt32(numericUpDownMinuter.Value),
                    Convert.ToInt32(numericUpDownSekunder.Value),
                    valdUpplösning
                    ));
                
                if (checkBoxRensa.Checked) textBoxTitel.Text = "";
                updateListView();
            }

            else 
            {
                tomTitelMeddelandeAsync();
            }
        }

        private void updateListView()
        {
            listViewBibliotek.Items.Clear();

            foreach (Media nuvarande in allMedia)
            {
                if(nuvarande.MedieTyp() == medieTyp.Bok)
                {
                    listViewBibliotek.Items.Add(new ListViewItem(((Bok)nuvarande).getValues()));
                }

                else if (nuvarande.MedieTyp() == medieTyp.Ljudspår)
                {
                    listViewBibliotek.Items.Add(new ListViewItem(((Ljudspår)nuvarande).getValues()));
                }

                else if (nuvarande.MedieTyp() == medieTyp.Film)
                {
                    listViewBibliotek.Items.Add(new ListViewItem(((Film)nuvarande).getValues()));
                }
            }
        }

        private medieTyp valdTyp()
        {
            if (radioButtonBok.Checked == true) return medieTyp.Bok;
            else if (radioButtonLjudspår.Checked == true) return medieTyp.Ljudspår;
            else if (radioButtonFilm.Checked == true) return medieTyp.Film;
            else return medieTyp.Bok;
        }

        private void labelTitelTomFel_Click(object sender, EventArgs e)
        {
            labelTitelTomFel.Visible = false;
        }

        private void uppdateraGuiElement()
        {
            if (radioButtonBok.Checked)
            {
                labelLängd.Text = "Sidor";
                buttonRegistreraSpara.Text = "Registrera bok";

                labelTimmar.Enabled = false;
                labelMinuter.Enabled = false;
                labelSekunder.Enabled = false;
                labelUpplösning.Enabled = false;
                numericUpDownMinuter.Enabled = false;
                numericUpDownSekunder.Enabled = false;
                comboBoxUpplösning.Enabled = false;
            }

            else if (radioButtonLjudspår.Checked)
            {
                labelLängd.Text = "Speltid";
                buttonRegistreraSpara.Text = "Registrera ljud";

                labelTimmar.Enabled = true;
                labelMinuter.Enabled = true;
                labelSekunder.Enabled = true;
                labelUpplösning.Enabled = false;
                numericUpDownMinuter.Enabled = true;
                numericUpDownSekunder.Enabled = true;
                comboBoxUpplösning.Enabled = false;
            }

            else if (radioButtonFilm.Checked)
            {
                labelLängd.Text = "Speltid";
                buttonRegistreraSpara.Text = "Registrera film";

                labelTimmar.Enabled = true;
                labelMinuter.Enabled = true;
                labelSekunder.Enabled = true;
                labelUpplösning.Enabled = true;
                numericUpDownMinuter.Enabled = true;
                numericUpDownSekunder.Enabled = true;
                comboBoxUpplösning.Enabled = true;
            }
        }

        private void radioButtonBok_CheckedChanged(object sender, EventArgs e)
        {
            uppdateraGuiElement();
        }

        private void radioButtonLjudspår_CheckedChanged(object sender, EventArgs e)
        {
            uppdateraGuiElement();
        }

        private void radioButtonFilm_CheckedChanged(object sender, EventArgs e)
        {
            uppdateraGuiElement();
        }
    }
}
