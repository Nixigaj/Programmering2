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
    public partial class Server : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
        // Hårdkodad port
        int port = 12345;

        public Server()
        {
            InitializeComponent();
        }

        private void buttonStartaServer_Click(object sender, EventArgs e)
        {

            
            lyssnare = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
            lyssnare.Start();

            klient = lyssnare.AcceptTcpClient();

            byte[] indata = new byte[256];

            int antalbyte = klient.GetStream().Read(indata, 0, indata.Length);

            listBoxMeddelande.Text = Encoding.Unicode.GetString(indata, 0, antalbyte);
            klient.Close();
            lyssnare.Stop();
        }
    }
}
