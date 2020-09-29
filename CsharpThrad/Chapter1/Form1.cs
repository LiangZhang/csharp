using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter1
{
    /// <summary>
    /// 官方文档：https://docs.microsoft.com/zh-cn/
    /// 线程: https://docs.microsoft.com/zh-cn/dotnet/api/system.threading.thread?view=netcore-3.1
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 1.正常主线程调用:单线程访问
        /// <summary>
        /// 单线程：程序假死情况，在主线程执行完的情况下，你不能执行其他事情，比如拖动窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNormal_Click(object sender, EventArgs e)
        {
            printNumbers();
        }
        #endregion

        #region 2.多线程调用:无参数
        /// <summary>
        /// 不带参数的线程调用：
        /// 
        /// 异常1：System.InvalidOperationException:“线程间操作无效: 从不是创建控件“txtRead”的线程访问它。”
        /// 原因：txtRead控件是主线程创建的，printNumbers在另一个线程t1中执行，修改主线程的控件，跨线程操作，异常
        /// 解决方案：c#竞争跨线程访问，让主窗体不检查
        /// 
        /// 工作原理：
        ///  当我们构建一个线程tl的时候，ThreadStart或者ParameterizedThreadStart的实例委托会传给线程的构造函数，
        ///  我们仅仅只需要指定在线程运行的方法名称(printNumbers),  
        ///  c#编译器会自动创建创建这个对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSingleThread_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(printNumbers);
            thread.Name = "t1";
            thread.IsBackground = true;
            thread.Start();
        }
        #endregion

        #region 3.多线程调用：有参数
        private void btnParamsThread_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(this.printParamsNumbers))
            {
                Name = "t2",
                IsBackground = true
            };
            thread.Start(10);
        }
        #endregion

        #region 4.线程等待、线程同步
        private void btnSleepThread_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(this.printParamsSleepNumbers))
            {
                Name = "t3",
                IsBackground = true
            };
            thread.Start(10);
        }
        private void btnSync_Click(object sender, EventArgs e)
        {
            printMsg("主线程开始运行...");
            Thread t3 = new Thread(new ParameterizedThreadStart(this.printParamsSleepNumbers))
            {
                Name = "t3",
                IsBackground = true
            };
            t3.Start(10);
            printMsg("等待子线程运行结束.");
            t3.Join();
            printMsg("子线程运行结束.");
        }
        #endregion

        #region 6.线程终止
        /// <summary>
        /// Thread.Abort():
        ///  a.一般不适用该停止该线程方案
        ///  b.该方法执行立即终止线程
        ///  c.该方法不一定能终止线程，目标线程可以通过Thread.ResetAbort()取消线程结束
        ///  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.Name = "Main Thread";
            printMsg("主程序开始执行...");

            Thread t1 = new Thread(new ParameterizedThreadStart(this.printParamsNumbers))
            {
                Name = "t4",
                IsBackground = true
            };
            
            t1.Start(10);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            t1.Abort();

            Thread t2 = new Thread(new ParameterizedThreadStart(this.printParamsNumbers))
            {
                Name = "t5",
                IsBackground = true
            };
            t2.Start(10);
        }
        #endregion

        #region 7.线程优先等级
        private void btnPriority_Click(object sender, EventArgs e)
        {
            printMsg("Current thread priority: " + Thread.CurrentThread.Priority);
            printMsg("Running on all cores available");
            RunThreads();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Running on a single core");
            //让操作系统把所有的线程运行在单个CPU核心上（第一个CPU）
            Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(1);
            RunThreads();
        }
        private void RunThreads()
        {
            //var sample = new ThreadSample();
            //var threadOne = new Thread(sample.CountNumbers)
            //{
            //    Name = "ThreadOne"
            //};
            //var threadTwo = new Thread(sample.CountNumbers)
            //{
            //    Name = "ThreadTwo"
            //};

            //threadOne.Priority = ThreadPriority.Highest;
            //threadTwo.Priority = ThreadPriority.Lowest;
            //threadOne.Start();
            //threadTwo.Start();

            //Thread.Sleep(TimeSpan.FromSeconds(2));
            //sample.Stop();
        }
        #endregion

        #region 前台、后台线程

        #endregion

        #region public method
        /// <summary>
        /// 无参打印
        /// </summary>
        private void printNumbers()
        {
            printMsg("当前运行线程名称：" + Thread.CurrentThread.Name);
            for (int i = 1; i < 10000; i++)
            {
                printMsg(i.ToString());
            }
            txtRead.AppendText("执行完成...");
        }
        /// <summary>
        /// 带参打印
        /// </summary>
        /// <param name="pre"></param>
        private void printParamsNumbers(object pre)
        {
            printMsg("当前运行线程名称：" + Thread.CurrentThread.Name);
            int count = 10;
            int.TryParse(pre.ToString(), out count);//这里采用了TryParse方法，避免不能转换时出现异常

            for (int i = 1; i < count; i++)
            {
                printMsg(i.ToString());
            }
            txtRead.AppendText("执行完成...");
        }
        /// <summary>
        /// 每隔2秒打印一次
        /// </summary>
        /// <param name="pre"></param>
        private void printParamsSleepNumbers(object pre)
        {
            printMsg("当前运行线程名称：" + Thread.CurrentThread.Name);
            int count = 10;
            int.TryParse(pre.ToString(), out count);//这里采用了TryParse方法，避免不能转换时出现异常

            for (int i = 1; i < count; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                printMsg(i.ToString());
            }
            txtRead.AppendText("执行完成...");
        }

        private void printMsg(string msg)
        {
            txtRead.AppendText(DateTime.Now.ToString("HH:mm:ss") + " " + Thread.CurrentThread.Name + "     " + msg + "\r\n");
        }

        #endregion

        #region 全局设置
        /// <summary>
        /// 不让检查跨线程调用：
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        #endregion

        private void btnState_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.Name = "Main Thread";
            printMsg("主程序开始执行...");
            printMsg("主线程状态：" + Thread.CurrentThread.ThreadState);

            Thread t1 = new Thread(new ParameterizedThreadStart(this.printParamsNumbers))
            {
                Name = "t7",
                IsBackground = true
            };
        }

        
    }
}
