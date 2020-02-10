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

namespace Övning_5._2_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TcpListener lyssnare;
        TcpClient klient;
        int port = 12345;

        private void buttonStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                lyssnare = new TcpListener(IPAddress.Any, port);
                lyssnare.Start();
                // Väntar på Connect i klienten
                klient = lyssnare.AcceptTcpClient();
            }
            catch
            {
                MessageBox.Show("Fel vid anslutning, kontrollera brandväggen");
                try
                {
                    klient.Close();
                    lyssnare.Stop();
                }
                catch { return; }

                return;
            }

            buttonStartServer.Enabled = false;
            buttonTaEmot.Enabled = true;
        }

        private void buttonTaEmot_Click(object sender, EventArgs e)
        {
            byte[] inData = new byte[256];
            // Väntar en Send i klienten
            int antalByte = klient.GetStream().Read(inData, 0, inData.Length);

            textBoxInkorg.Text = Encoding.Unicode.GetString(inData, 0, antalByte);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            klient.Close();
            lyssnare.Stop();
        }
    }
}
