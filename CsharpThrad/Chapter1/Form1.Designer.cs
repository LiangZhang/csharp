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
            this.button8 = new System.Windows.Forms.Button();
            this.btnSingleThread = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNormal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(15, 124);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "2、暂停线程";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnSingleThread
            // 
            this.btnSingleThread.Location = new System.Drawing.Point(15, 72);
            this.btnSingleThread.Name = "btnSingleThread";
            this.btnSingleThread.Size = new System.Drawing.Size(107, 23);
            this.btnSingleThread.TabIndex = 0;
            this.btnSingleThread.Text = "2、多线程调用";
            this.btnSingleThread.UseVisualStyleBackColor = true;
            this.btnSingleThread.Click += new System.EventHandler(this.btnSingleThread_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 207);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "4、终止线程";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 165);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "3、等待线程";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNormal);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.btnSingleThread);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
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
            this.label3.Location = new System.Drawing.Point(143, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "多线程执行（子线程），在执行过程不执行其他操作，比如拖动窗体，解决程序假死";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "单线程执行（主线程），在执行过程不能执行其他操作，比如拖动窗体，造成程序假死";
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(15, 29);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(107, 23);
            this.btnNormal.TabIndex = 8;
            this.btnNormal.Text = "1、普通调用";
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
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnSingleThread;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Label label1;
    }
}

