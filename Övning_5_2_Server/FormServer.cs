using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Övning_5_2_Server
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
        }

        private void buttonTaEmot_Click(object sender, EventArgs e)
        {
            IPEndPoint klientEndPoint = new IPEndPoint(IPAddress.Any, 0);
            UdpClient client = new UdpClient(Convert.ToInt32(textBoxPort.Text));
            byte[] inström = client.Receive(ref klientEndPoint);
            textBoxData.Text = Encoding.Unicode.GetString(inström);
        }
    }
}
