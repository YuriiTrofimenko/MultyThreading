using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultyThreading_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() => {
                Console.Write("A");
                Console.Write("B");
                Console.WriteLine("C");
            });
            // Thread t2 = new Thread(new Worker().DoWork);
            Worker w = new Worker();
            Thread t2 = new Thread(w.DoWork);

            // t1.Start();
            t2.IsBackground = true;
            t2.Start();
            Thread.Sleep(10);
            w.isSuspended = true;
            Thread.Sleep(1000);
            w.isSuspended = false;
            t2.Resume();

            // t1.Suspend();
            // t2.Suspend();
            // t2.Join(1000);

            /* while (t2.IsAlive)
            {
                Thread.Sleep(1);
            } */

            Thread.Sleep(1000);

            w.isFinished = true;
            t2.Join();

            Console.WriteLine("Main is Finished");
        }
    }
}
