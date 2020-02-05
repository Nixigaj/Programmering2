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

namespace Övning_5_2
{
    public partial class Klient : Form
    {
        TcpClient klient;
        int port = 12345;

        public Klient()
        {
            InitializeComponent();
        }

        private void buttonSkicka_Click(object sender, EventArgs e)
        {
            IPAddress adress = IPAddress.Parse(textBoxIPAdress.Text);
            klient = new TcpClient();
            klient.NoDelay = true;
            klient.Connect(adress, port);

            if (klient.Connected)
            {
                byte[] utData = Encoding.Unicode.GetBytes(textBoxMeddelande.Text);
                klient.GetStream().Write(utData, 0, utData.Length);
                klient.Close();
            }
        }
    }
}
