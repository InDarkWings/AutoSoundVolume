using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoSoundVolume2;

namespace AutoSoundVolume2
{
	public partial class Form1 : Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox filepathTextbox;
		private System.Windows.Forms.Button playOnceSyncButton;
		private System.Windows.Forms.Button playOnceAsyncButton;
		private System.Windows.Forms.Button playLoopAsyncButton;
		private System.Windows.Forms.Button selectFileButton;

		private System.Windows.Forms.Button stopButton;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Button loadSyncButton;
		private System.Windows.Forms.Button loadAsyncButton;
		private SoundPlayer player;
		public Form1()	  //窗体运行时需要调用的函数可以在这里调用
		{
			InitializeComponent();
			//EnablePlaybackControls(false);
			var Inzcs = new control();
			Inzcs.InitializeControls();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SystemSounds.Hand.Play();
		}
		public void Play() 
		{
		}

		private void toolStripProgressBar1_Click(object sender, EventArgs e)
		{

		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{

		}
	}
}
