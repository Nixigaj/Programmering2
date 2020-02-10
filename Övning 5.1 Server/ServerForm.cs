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

namespace Övning_5._1_Server
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }

        private void buttonTaEmot_Click(object sender, EventArgs e)
        {
            IPEndPoint klientEndPoint = new IPEndPoint(IPAddress.Any, 0);

            UdpClient client;
            try
            {
                client = new UdpClient(Int32.Parse(textBoxPort.Text));
            }
            catch
            {
                MessageBox.Show("Felinmatad port");
                textBoxPort.Text = "";
                return;
            }

            byte[] inström = client.Receive(ref klientEndPoint);
            textBoxData.Text = Encoding.Unicode.GetString(inström);
        }
    }
}
