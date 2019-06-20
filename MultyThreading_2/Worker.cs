using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultyThreading_2
{
    class Worker
    {
        public bool isSuspended = false;
        public bool isFinished = false;
        public void DoWork() {

            int i = 0;
            while (i < 10000)
            {
                if (isSuspended)
                {
                    Thread.CurrentThread.Suspend();
                }
                else if (isFinished)
                {
                    break;
                }
                else
                {
                    Console.Write("Hello");
                    Console.Write(" World");
                    Console.WriteLine("!");
                    Console.WriteLine("(" + i + ")");
                    i++;
                }
            }
        }
    }
}
