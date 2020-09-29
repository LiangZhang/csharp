using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    /// <summary>
    /// 线程例子样品
    /// </summary>
    class ThreadSample
    {
        private bool _isStopped = false;

        public void Stop()
        {
            _isStopped = true;
        }

        public void CountNumbers()
        {
            long counter = 0;

            while (!_isStopped)
            {
                counter++;
            }
            Console.WriteLine("{0} with {1,11} priority " +
                        "has a count = {2,13}", Thread.CurrentThread.Name,
                        Thread.CurrentThread.Priority,
                        counter.ToString("N0"));
        }
    }
}
