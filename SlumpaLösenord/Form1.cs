using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlumpaLösenord
{
    public partial class FormStart : Form
    {
        private Inloggningar inloggningar = new Inloggningar("filväg");

        public FormStart()
        {
            InitializeComponent();
            textBoxLösenord.Text = inloggningar.NästaLösen();
        }

        private void buttonLäggTill_Click(object sender, EventArgs e)
        {
            inloggningar.LäggTill(textBoxAnvändarnamn.Text);

            uppdateraVy();
        }

        private void buttonSkrivTillFil_Click(object sender, EventArgs e)
        {
            inloggningar.SkrivTillFil();
        }

        private void uppdateraVy()
        {
            listBoxInloggningar.Items.Clear();

            foreach (string nuvarande in inloggningar.GetValues())
            {
                listBoxInloggningar.Items.Add(nuvarande);
            }
        }
    }
}
