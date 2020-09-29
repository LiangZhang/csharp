using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        #region 正常主线程调用:单线程访问
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

        #region 多线程调用
        /// <summary>
        /// 单线程访问：
        /// 异常：System.InvalidOperationException:“线程间操作无效: 从不是创建控件“txtRead”的线程访问它。”
        /// 原因：txtRead是主线程创建的，printNumbers在另一个线程t1中执行，修改主线程的控件，跨线程操作，异常
        ///       c#竞争跨线程访问
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSingleThread_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.Name = "Main";
            printNumbers();

            Thread thread = new Thread(printNumbers);
            thread.Name = "t1";
            thread.IsBackground = true;
            thread.Start();
        }
        #endregion

        #region 前台、后台线程

        #endregion



        #region public method
        /// <summary>
        /// 输出数字
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

        private void printMsg(string msg)
        {
            txtRead.AppendText(DateTime.Now.ToString("HH:mm:ss") + " " + Thread.CurrentThread.Name + "     " + msg + "\r\n");
        }

        #endregion

        /// <summary>
        /// 不让检查跨线程调用：
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
