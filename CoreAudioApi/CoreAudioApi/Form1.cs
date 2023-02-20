using System;
using System.Threading;
using System.Windows.Forms;

namespace CoreAudioApi
{
    public partial class Form1 : Form
    {
        private Thread pro;
       
        public Form1()
        {
            InitializeComponent();
			pro = new Thread(new ThreadStart(autoSetVolume));
        }

        MMDevice device;
        


        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化设备
            MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
            device = devEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);

        }
        

        /// <summary>
        /// 获取当前音量
        /// </summary>
        public int CurrentVolume
        {
            get => Convert.ToInt32(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100.0f);
        }

        /// <summary>
        /// 设置音量
        /// </summary>
        public int SetVolume
        {
            get => CurrentVolume;
            set
            {
                if (value < 0) device.AudioEndpointVolume.MasterVolumeLevelScalar = 0 / 100.0f;
                else if (value > 100) device.AudioEndpointVolume.MasterVolumeLevelScalar = 100 / 100.0f;
                else device.AudioEndpointVolume.MasterVolumeLevelScalar = value / 100.0f;
            }
        }
        /// <summary>
        /// 定时器更新并显示当前音量和峰值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "当前设置音量："+ CurrentVolume;
            label7.Text = "当前实际音量：" + Convert.ToInt32(device.AudioMeterInformation.MasterPeakValue * 100.0f);

            //使用Convert.ToInt32转换没有误差
            progressBar1.Value = Convert.ToInt32(device.AudioMeterInformation.MasterPeakValue * 100.0f);  //获取到的音量值_中
            progressBar2.Value = Convert.ToInt32(device.AudioMeterInformation.PeakValues[0] * 100.0f);    //获取到的音量值_左
            progressBar3.Value = Convert.ToInt32(device.AudioMeterInformation.PeakValues[1] * 100.0f);    //获取到的音量值_右
        }
        private void autoSetVolume()
        {   
           
            textBox2.Text = textBox1.Text;
            while (true)
            {
                float 当前实际音量 = Convert.ToInt32(device.AudioMeterInformation.MasterPeakValue * 100.0f);
                float 用户设置音量 = Convert.ToInt32(textBox1.Text);
                if (当前实际音量 >= 用户设置音量 + 5 || 当前实际音量 <= 用户设置音量 - 5)
                    SetVolume = (int)用户设置音量;
                Thread.Sleep(100); //检测频率
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //每点击一次，音量加10
            SetVolume += 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //每点击一次，音量减10
            SetVolume -= 10;
        }

		private void label5_Click(object sender, EventArgs e)
		{ 
            textBox2.Text  = textBox1.Text;
            autoSetVolume();
           /* while (true)
            {
                if (当前实际音量 >= 用户设置音量 + 5 || 当前实际音量 <= 用户设置音量 - 5)
                    SetVolume = (int)用户设置音量;
                Thread.Sleep(1000);
            }*/

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}
	}
}
