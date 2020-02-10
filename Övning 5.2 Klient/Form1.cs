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

namespace Övning_5._2_Klient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TcpClient klient;
        int port = 12345;

        private void buttonAnslut_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress adress = IPAddress.Parse(textBoxIP.Text);
                klient = new TcpClient();
                klient.NoDelay = true;
                klient.Connect(adress, port);
            }
            catch
            {
                try
                {
                    MessageBox.Show("Felaktig anslutning, kontrollera IP-Adress");
                    klient.Close();
                    return;
                }
                catch { return; }
            }

            if (!klient.Connected)
            {
                MessageBox.Show("Anslutning misslyckades");
                klient.Close();
            }
            else
            {
                buttonAnslut.Enabled = false;
                buttonSkicka.Enabled = true;
            }
        }

        private void buttonSkicka_Click(object sender, EventArgs e)
        {
            byte[] utData = Encoding.Unicode.GetBytes(textBoxMeddelande.Text);
            klient.GetStream().Write(utData, 0, utData.Length);
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            klient.Close();
        }
    }
}
