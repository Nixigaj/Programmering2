using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5_2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Startar klient och server på varsin tråd
            Thread t1 = new Thread(F1);
            Thread t2 = new Thread(F2);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            //Application.Run(new Form1());
            //Application.Run(new Form2());
        }

        static void F1()
        {
            Application.Run(new Klient());
        }

        static void F2()
        {
            Application.Run(new Server());
        }
    }
}
