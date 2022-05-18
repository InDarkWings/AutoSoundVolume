using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutoSoundVolume2
{
	internal static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
	class control
	{
		public double Volume { get; set; }
		[DllImport("user32.dll")]
		public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

		public void SetVol()
		{
			p = Process.GetCurrentProcess();
			for (int i = 0; i < 5; i++)
			{
				SendMessageW(p.Handle, WM_APPCOMMAND, p.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
			}
		}

		private Process p;
		private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
		private const int APPCOMMAND_VOLUME_UP = 0x0a0000;
		private const int APPCOMMAND_VOLUME_DOWN = 0x090000;
		private const int WM_APPCOMMAND = 0x319;
		public void InitializeControls()
		{
			// Set up the status bar.
			StatusBarPanel panel = new StatusBarPanel();
			panel.BorderStyle = StatusBarPanelBorderStyle.Sunken;
			panel.Text = "Ready.";
			panel.AutoSize = StatusBarPanelAutoSize.Spring;
			this.toolStripProgressBar.ShowPanels = true;
			this.statusStrip.Panels.Add(panel);
		}
	}
	
}
