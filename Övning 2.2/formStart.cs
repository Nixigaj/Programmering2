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
            
        }

        private void ButtonRegArbetspass_Click(object sender, EventArgs e)
        {
            
        }
    }
}
