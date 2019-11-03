using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Övning_2._8
{
    public partial class FormStart : Form
    {
        List<Vara> allaVaror = new List<Vara>();
        bool sorteraEfterPris = false;

        public FormStart()
        {
            InitializeComponent();
        }

        public void UppdateraVy()
        {
            listViewInköpslista.Items.Clear();

            foreach (Vara nuvarande in allaVaror)
            {
                listViewInköpslista.Items.Add(new ListViewItem(nuvarande.GetValues()));
            }
        }

        public double TotalPris()
        {
            double total = 0;

            foreach (Vara nuvarande in allaVaror)
            {
                total += nuvarande.BeräknaPris();
            }

            return total;
        }

        private void buttonLäggTill_Click(object sender, System.EventArgs e)
        {
            if (radioButtonLösvikt.Checked) allaVaror.Add(new LösVikt(
                textBoxVara.Text,
                Convert.ToDouble(numericUpDownPris.Value),
                Convert.ToDouble(numericUpDownMängd.Value)));

            else if (radioButtonStycksak.Checked) allaVaror.Add(new StyckSak(
                textBoxVara.Text,
                Convert.ToDouble(numericUpDownPris.Value),
                Convert.ToInt32(numericUpDownMängd.Value)));

            // Om man försöker sortera fler än 15 varor med 0 i pris får man ett fel i IComparable som jag ej förstår
            if (sorteraEfterPris) allaVaror.Sort();
            UppdateraVy();
            ResetFält();
            textBoxSumma.Text = Convert.ToString(TotalPris());
        }

        public void ResetFält()
        {
            textBoxVara.Text = "";
            numericUpDownPris.Value = 0;
            numericUpDownMängd.Value = 0;
        }

        private void buttonSortera_Click(object sender, EventArgs e)
        {
            buttonSortera.Enabled = false;
            sorteraEfterPris = true;
            allaVaror.Sort();
            UppdateraVy();
        }
    }
}
