using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5._1_Klient
{
    public partial class KlientForm : Form
    {
        public KlientForm()
        {
            InitializeComponent();
        }

        private void buttonSkicka_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.Unicode.GetBytes(textBoxData.Text);

            IPEndPoint destination;
            try
            {
                string[] slutpunkt = textBoxIP.Text.Split(':');
                IPAddress serverIP = IPAddress.Parse(slutpunkt[0]);
                destination = new IPEndPoint(serverIP, Int32.Parse(slutpunkt[1]));
            }
            catch
            {
                MessageBox.Show("Felinmatad IP-Adress eller port" +
                    "\nVänligen ange adress som \"IP:PORT\"");
                textBoxIP.Text = "";
                return;
            }

            try
            {
                UdpClient klient = new UdpClient();
                klient.Send(message, message.Length, destination);
            }
            catch
            {
                MessageBox.Show("Fel: Servern lyssnar förmodligen inte på ändpunkten");
            }
        }
    }
}
