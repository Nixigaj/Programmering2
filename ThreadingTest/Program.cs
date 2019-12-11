// WARNING
// This program will use all of your disk and create gigantic files in a short time

using System.IO;
using System.Threading;

namespace ThreadingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t2 = new Thread(second);
            Thread t3 = new Thread(third);
            Thread t4 = new Thread(forth);
            Thread t5 = new Thread(fifth);
            Thread t6 = new Thread(sixth);

            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();

            StreamWriter sw = new StreamWriter(@"../../writeTest\a.txt");
            for (; ; ) sw.WriteLine("a");
        }

        static void second()
        {
            StreamWriter sw = new StreamWriter(@"../../writeTest\b.txt");
            for (; ; ) sw.WriteLine("b");
        }

        static void third()
        {
            StreamWriter sw = new StreamWriter(@"../../writeTest\c.txt");
            for (; ; ) sw.WriteLine("c");
        }

        static void forth()
        {
            StreamWriter sw = new StreamWriter(@"../../writeTest\d.txt");
            for (; ; ) sw.WriteLine("d");
        }

        static void fifth()
        {
            StreamWriter sw = new StreamWriter(@"../../writeTest\e.txt");
            for (; ; ) sw.WriteLine("e");
        }

        static void sixth()
        {
            StreamWriter sw = new StreamWriter(@"../../writeTest\f.txt");
            for (; ; ) sw.WriteLine("f");
        }
    }
}
