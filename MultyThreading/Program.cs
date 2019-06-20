using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultyThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart start = new ThreadStart(Program.DoSmth);
            Thread t1 = new Thread(start);
            t1.Start();

            ParameterizedThreadStart start2 = new ParameterizedThreadStart(Program.Say);
            Thread t2 = new Thread(start2);
            t2.Start("Hi!");

            Console.WriteLine("Begin");
            MessageBox.Show("The End");
        }

        static void DoSmth() {
            // Console.WriteLine("Hello World");

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Say(object _phrase)
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(i + " " + _phrase);
            }
        }
    }
}
