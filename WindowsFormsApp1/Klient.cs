using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5_2
{
    public partial class Klient : Form
    {
        public Klient()
        {
            InitializeComponent();
        }

        TcpClient klient;
        int port = 8080;
    }
}
