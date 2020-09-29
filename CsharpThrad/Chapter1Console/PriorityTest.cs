using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1Console
{
    /// <summary>
    /// 线程传递参数
    /// </summary>
    class PriorityTest
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main";

            //1.使用相同的间接方式把参数从一个线程传给另一个线程
            var sample = new ThreadSample(10);
            Console.WriteLine("1.使用对象构造函数初始的间接方式把参数从一个线程传给另一个线程，在{0}线程中，传递给线程ThreadOne", Thread.CurrentThread.Name);
            var threadOne = new Thread(sample.CountNumbers);
            threadOne.Name = "ThreadOne";
            threadOne.Start();
            threadOne.Join();

            Console.WriteLine("--------------------------");

            Console.WriteLine("2.使用ParameterizedThreadStart传递参数");
            var threadTwo = new Thread(Count);
            threadTwo.Name = "ThreadTwo";
            threadTwo.Start(8);
            threadTwo.Join();

            var threadSix = new Thread(new ParameterizedThreadStart(Count))
            {
                Name = "ThreadSix"
            };
            threadSix.Start(10);
            threadSix.Join();
            Console.WriteLine("--------------------------");

            Console.WriteLine("3.使用lamada表达式传递参数");
            var threadThree = new Thread(() => CountNumbers(12));
            threadThree.Name = "ThreadThree";
            threadThree.Start();
            threadThree.Join();
            Console.WriteLine("--------------------------");

            Console.WriteLine("4.如果在多个lamada表达式中使用相同的变量，多个线程会共享该变量");
            int i = 10;
            var threadFour = new Thread(() => PrintNumber(i));
            i = 20;
            var threadFive = new Thread(() => PrintNumber(i));
            threadFour.Start();
            threadFive.Start();
            Console.WriteLine("--------------------------");
            Console.ReadLine();

        }

        static void Count(object iterations)
        {
            CountNumbers((int)iterations);
        }

        static void CountNumbers(int iterations)
        {
            for (int i = 1; i <= iterations; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(0.5));
                Console.WriteLine("{0} prints {1}", Thread.CurrentThread.Name, i);
            }
        }

        static void PrintNumber(int number)
        {
            Console.WriteLine(number);
        }

        static void PrintPamaesNumber(object number)
        {
            int len = 10;
            int.TryParse(number.ToString(), out len);
            for (int i = 0; i < len; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(0.5));
                Console.WriteLine("{0} prints {1}", Thread.CurrentThread.Name, i);
            }
        }

        class ThreadSample
        {
            private readonly int _iterations;

            public ThreadSample(int iterations)
            {
                _iterations = iterations;
            }
            public void CountNumbers()
            {
                for (int i = 1; i <= _iterations; i++)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(0.5));
                    Console.WriteLine("{0} prints {1}", Thread.CurrentThread.Name, i);
                }
            }
        }
    }
}
