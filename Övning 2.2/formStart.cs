using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._2
{
    public partial class formStart : Form
    {
        System.Media.SoundPlayer errorSound = new System.Media.SoundPlayer("C:/Windows/media/Windows Background.wav");
        // C:/Windows/media/Windows Background.wav

        public formStart()
        {
            InitializeComponent();
        }

        private void ButtonRegFörsäljning_Click(object sender, EventArgs e)
        {
            errorSound.Play();
        }

        private void ButtonRegArbetspass_Click(object sender, EventArgs e)
        {
            
        }
    }
}
