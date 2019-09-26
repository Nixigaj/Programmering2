using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROV_KAP_1_ERIK_JUNSVED
{
    public partial class Form1 : Form
    {
        List<Bostad> allaBostäder = new List<Bostad>();

        public Form1()
        {
            InitializeComponent();

            // Stoppar in enumet i comboboxen
            cbxBostadstyp.DataSource = Enum.GetValues(typeof(bostadsTyp));
        }

        private void ButtonLäggTill_Click(object sender, EventArgs e)
        {
            // Tar emot valda bostadstypen på variabeln valdTyp
            bostadsTyp valdTyp;
            Enum.TryParse<bostadsTyp>(cbxBostadstyp.SelectedValue.ToString(), out valdTyp);

            if (accON(tbxObjektnummer.Text))
            {
                try
                {
                    // Tilldelar objektet
                    Bostad tilldeladBostad = new Bostad(tbxObjektnummer.Text, int.Parse(tbxBoyta.Text), int.Parse(tbxPris.Text), valdTyp);

                    // Stoppar in det ny objektet på listan
                    allaBostäder.Add(tilldeladBostad);

                    uppdateraListBox();
                    ränsaFält();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Boyta eller pris är felangivet eller får inte lämmnas tomt.");
                }
                catch (System.OverflowException)
                {
                    MessageBox.Show("Ett för stort värde har angetts.");
                }
            }

            else MessageBox.Show("Objektnummret innehåller ej 4 tecken");
        }

        // Kollar ifall objektnummret är accepterat
        private bool accON(string analyseras)
        {
            // ...alltså har 4 tecken
            return analyseras.Length == 4;
        }

        private void uppdateraListBox()
        {
            // Tar först bort allt ur listBoxen
            lbxBostäder.Items.Clear();

            // Lägger till varje värde var för sig från listan allaBostäder
            foreach (Bostad nuvarande in allaBostäder)
            {
                lbxBostäder.Items.Add(nuvarande.ToString());
            }
        }

        private void ränsaFält()
        {
            tbxObjektnummer.Clear();
            tbxBoyta.Clear();
            tbxPris.Clear();
        }
    }
}
