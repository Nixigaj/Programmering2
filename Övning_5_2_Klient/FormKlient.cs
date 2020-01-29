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


namespace Övning_5_2_Klient
{
    public partial class FormKlient : Form
    {
        public FormKlient()
        {
            InitializeComponent();
        }

        private void buttonSkicka_Click(object sender, EventArgs e)
        {

            byte[] message = Encoding.UTF8.GetBytes(textBoxData.Text);

            string[] adress = textBoxIP.Text.Split(':');

            if (adress.Length != 2)
            {
                MessageBox.Show("IP och port anges som \"IP:PORT\"");
                return;
            }

            IPEndPoint destination;
            try
            {
                IPAddress serverIP = IPAddress.Parse(adress[0]);
                destination = new IPEndPoint(serverIP, Convert.ToInt32(adress[1]));
            }
            catch (Exception)
            {
                MessageBox.Show("Fel vid inmatning av IP-Adress.\nKontrollera att du faktiskt har matat in en IP-Adress");
                return;
            }

            UdpClient klient = new UdpClient();
            klient.Send(message, message.Length, destination);
        }
    }
}
