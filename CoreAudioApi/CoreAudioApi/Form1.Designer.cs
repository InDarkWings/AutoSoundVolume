namespace CoreAudioApi
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.label4 = new System.Windows.Forms.Label();
			this.progressBar3 = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 86);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "当前音量：";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(44, 115);
			this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(151, 19);
			this.progressBar1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 118);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "主：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 162);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "左：";
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(44, 159);
			this.progressBar2.Margin = new System.Windows.Forms.Padding(2);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(151, 19);
			this.progressBar2.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 206);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 6;
			this.label4.Text = "右：";
			// 
			// progressBar3
			// 
			this.progressBar3.Location = new System.Drawing.Point(44, 203);
			this.progressBar3.Margin = new System.Windows.Forms.Padding(2);
			this.progressBar3.Name = "progressBar3";
			this.progressBar3.Size = new System.Drawing.Size(151, 19);
			this.progressBar3.TabIndex = 5;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 200;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(14, 54);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 14);
			this.label5.TabIndex = 11;
			this.label5.Text = "锁定音量：";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(99, 51);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 21);
			this.textBox1.TabIndex = 13;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(99, 12);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 21);
			this.textBox2.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(4, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 12);
			this.label6.TabIndex = 15;
			this.label6.Text = "当前锁定音量：";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(112, 86);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 12);
			this.label7.TabIndex = 16;
			this.label7.Text = "当前音量：";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(234, 341);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.progressBar3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.progressBar2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "听歌神器";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}

