using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fordon_Improved
{
    public partial class Form1 : Form
    {
        List<Fordon> allaFordon = new List<Fordon>();

        public Form1()
        {
            InitializeComponent();

            // Kopplar innehållet av fordonsTyp enumet till
            typComboBox.DataSource = Enum.GetValues(typeof(fordonsTyp));

            //visaAllaButton.Checked = true;

            errorMessageLabel.Text = "";
        }

        private void registreraButton_Click(object sender, EventArgs e)
        {
            errorMessageLabel.Text = "";

            fordonsTyp valdTyp;
            Enum.TryParse<fordonsTyp>(typComboBox.SelectedValue.ToString(), out valdTyp);

            if (Fordon.GodkännRegNr(regNrBox.Text))
            {
                if (!finnsTidigare())
                {
                    allaFordon.Add(new Fordon(regNrBox.Text, märkeBox.Text, modellBox.Text, valdTyp));
                    rensaFält();
                    autoUppdatera();
                }
                else errorMessageLabel.Text = "Felmeddelande: Detta fordon är redan tillagt";
            }
            else errorMessageLabel.Text = "Felmeddelande: Ange Reg-nr på formatet ABC123";
        }

        private void autoUppdatera()
        {
            errorMessageLabel.Text = "";

            if (visaAllaButton.Checked) uppdateraListBox();
            else if (visaBilarButton.Checked) uppdateraListBoxSpecifik(fordonsTyp.Bil);
            else if (visaMCButton.Checked) uppdateraListBoxSpecifik(fordonsTyp.MC);
        }

        private void uppdateraListBox()
        {
            listViewRegister.Items.Clear();

            foreach (Fordon nuvarande in allaFordon)
            {
                string typToList = "null";

                if (nuvarande.FordonsTyp == fordonsTyp.Bil) typToList = "Bil";
                else if (nuvarande.FordonsTyp == fordonsTyp.MC) typToList = "MC";

                listViewRegister.Items.Add(new ListViewItem(new string[]
                {
                    nuvarande.RegNr, nuvarande.Märke, nuvarande.Modell, typToList
                }));
            }

            // v Gammal kod v
            /*
            registerListBox.Items.Clear();

            foreach (Fordon nuvarande in innehåll)
            {
                registerListBox.Items.Add(innehåll.ToString());
            }
            */
        }

        private void uppdateraListBoxSpecifik(fordonsTyp valdVisaTyp)
        {
            listViewRegister.Items.Clear();

            foreach (Fordon nuvarande in allaFordon)
            {
                string typToList = "null";

                if (nuvarande.FordonsTyp == fordonsTyp.Bil) typToList = "Bil";
                else if (nuvarande.FordonsTyp == fordonsTyp.MC) typToList = "MC";

                if (nuvarande.FordonsTyp == valdVisaTyp)
                {
                    listViewRegister.Items.Add(new ListViewItem(new string[]
                    {
                        nuvarande.RegNr, nuvarande.Märke, nuvarande.Modell, typToList
                    }));
                }
            }
        }

        private void VisaAllaButton_CheckedChanged(object sender, EventArgs e)
        {
            errorMessageLabel.Text = "";
            uppdateraListBox();
        }

        private void VisaBilarButton_CheckedChanged(object sender, EventArgs e)
        {
            errorMessageLabel.Text = "";
            uppdateraListBoxSpecifik(fordonsTyp.Bil);
        }

        private void VisaMCButton_CheckedChanged(object sender, EventArgs e)
        {
            errorMessageLabel.Text = "";
            uppdateraListBoxSpecifik(fordonsTyp.MC);
        }

        private bool finnsTidigare()
        {
            bool returvärde = false;

            foreach (Fordon nuvarande in allaFordon)
            {
                if (regNrBox.Text.Equals(nuvarande.RegNr)) returvärde = true;
            }

            return returvärde;
        }

        private void ÅngraButton_Click(object sender, EventArgs e)
        {
            errorMessageLabel.Text = "";

            if (allaFordon.Any()) // prevent IndexOutOfRangeException for empty list
            {
                allaFordon.RemoveAt(allaFordon.Count - 1);
            }

            autoUppdatera();
        }

        private void rensaFält()
        {
            errorMessageLabel.Text = "";
            regNrBox.Text = "";
            märkeBox.Text = "";
            modellBox.Text = "";
        }




        //////////////////////////////////////////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void GroupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}

/* 
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show ("You are selected Red !! ");
                return;
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("You are selected Blue !! ");
                return;
            }
            else
            {
                MessageBox.Show("You are selected Green !! ");
                return;
            }
        }
    }
}
*/
