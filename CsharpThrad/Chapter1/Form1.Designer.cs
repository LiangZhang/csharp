namespace Chapter1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRead = new System.Windows.Forms.TextBox();
            this.btnParamsThread = new System.Windows.Forms.Button();
            this.btnSingleThread = new System.Windows.Forms.Button();
            this.btnSleepThread = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNormal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSync = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(25, 370);
            this.txtRead.Multiline = true;
            this.txtRead.Name = "txtRead";
            this.txtRead.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRead.Size = new System.Drawing.Size(683, 154);
            this.txtRead.TabIndex = 13;
            // 
            // btnParamsThread
            // 
            this.btnParamsThread.Location = new System.Drawing.Point(15, 112);
            this.btnParamsThread.Name = "btnParamsThread";
            this.btnParamsThread.Size = new System.Drawing.Size(135, 23);
            this.btnParamsThread.TabIndex = 7;
            this.btnParamsThread.Text = "3、线程调用（有参）";
            this.btnParamsThread.UseVisualStyleBackColor = true;
            this.btnParamsThread.Click += new System.EventHandler(this.btnParamsThread_Click);
            // 
            // btnSingleThread
            // 
            this.btnSingleThread.Location = new System.Drawing.Point(15, 72);
            this.btnSingleThread.Name = "btnSingleThread";
            this.btnSingleThread.Size = new System.Drawing.Size(135, 23);
            this.btnSingleThread.TabIndex = 0;
            this.btnSingleThread.Text = "2、线程调用（无参）";
            this.btnSingleThread.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSingleThread.UseVisualStyleBackColor = true;
            this.btnSingleThread.Click += new System.EventHandler(this.btnSingleThread_Click);
            // 
            // btnSleepThread
            // 
            this.btnSleepThread.Location = new System.Drawing.Point(15, 151);
            this.btnSleepThread.Name = "btnSleepThread";
            this.btnSleepThread.Size = new System.Drawing.Size(135, 23);
            this.btnSleepThread.TabIndex = 6;
            this.btnSleepThread.Text = "4、等待线程";
            this.btnSleepThread.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSleepThread.UseVisualStyleBackColor = true;
            this.btnSleepThread.Click += new System.EventHandler(this.btnSleepThread_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSync);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNormal);
            this.groupBox1.Controls.Add(this.btnParamsThread);
            this.groupBox1.Controls.Add(this.btnSingleThread);
            this.groupBox1.Controls.Add(this.btnSleepThread);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 317);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "线程的基础操作：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "多线程执行（子线程），在执行过程不执行其他操作，比如拖动窗体，解决程序假死";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "单线程执行（主线程），在执行过程不能执行其他操作，比如拖动窗体，造成程序假死";
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(15, 29);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(135, 23);
            this.btnNormal.TabIndex = 8;
            this.btnNormal.Text = "1、普通调用";
            this.btnNormal.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "响应结果：";
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(15, 190);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(135, 23);
            this.btnSync.TabIndex = 14;
            this.btnSync.Text = "5、线程同步";
            this.btnSync.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 558);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "线程的基本操作";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.Button btnParamsThread;
        private System.Windows.Forms.Button btnSingleThread;
        private System.Windows.Forms.Button btnSleepThread;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSync;
    }
}

