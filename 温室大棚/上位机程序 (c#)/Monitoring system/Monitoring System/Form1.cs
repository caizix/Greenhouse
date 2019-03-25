using System;
using System.IO.Ports;//串口
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Timers;  
using System.Windows.Forms;
using System.Media; 

namespace Monitoring_System
{
    public partial class Form1 : Form
    {
        private SerialPort COMM = new SerialPort();
        private StringBuilder builder_temp = new StringBuilder();//处理字符串
        private string send_data;
        private byte flag = 0;
        static byte i = 0;
        int minutes = 0, flag_timer = 0;

        byte[] SendBuf = new byte[4];//定义串口发送字符串变量
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ports.Items.Add("COM1"); //ports为串口下拉组合框
            ports.Items.Add("COM2");
            ports.Items.Add("COM3");
            ports.Items.Add("COM4");
            ports.Items.Add("COM5");

            botelu.Items.Add("4800"); //botelu为波特率下拉组合框
            botelu.Items.Add("9600");
            botelu.Items.Add("19200");
            botelu.Items.Add("38400");
            botelu.Items.Add("57600");
            botelu.Items.Add("115200");
            comboBox1.Items.Add("5");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("7");
            comboBox1.Items.Add("8");

            comboBox2.Items.Add("1");
            comboBox2.Items.Add("1.5");
            comboBox2.Items.Add("2");

            comboBox3.Items.Add("无");
            comboBox3.Items.Add("奇校验");
            comboBox3.Items.Add("偶校验");

            ports.SelectedIndex = ports.Items.IndexOf("COM1"); //comboBox1.SelectedIndex = 0;
            botelu.SelectedIndex = botelu.Items.IndexOf("9600"); // comboBox2.SelectedIndex =1;
            comboBox1.SelectedIndex = 3;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

            // COMM.NewLine = "/r/n";
            this.COMM.RtsEnable = true;//根据实际情况吧。
            //添加事件注册
            COMM.DataReceived += COMM_DataReceived;


            System.Timers.Timer aTimer = new System.Timers.Timer();

            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            aTimer.Interval = 1000;//1s
            aTimer.Enabled = true;
            GC.KeepAlive(aTimer);

            this.textBox7.Text = "60";//湿度
            liang.Enabled = false;

            this.textBox6.Text = "2000";//光照
            button3.Enabled = false;

        }

        /// <summary>
        /// 串口接收数据处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void COMM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = this.COMM.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致  
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据 
            this.COMM.Read(buf, 0, n);//读取缓冲数据  
            //因为要访问ui资源，所以需要使用invoke方式同步ui。  
            this.Invoke((EventHandler)(delegate
            {
                byte flag_judge = 0;
                //直接按ASCII规则转换成字符串  
                string rece_temp = Encoding.ASCII.GetString(buf);
                builder_temp.Append(rece_temp);
                while (flag_judge < n)
                {
                    if (buf[flag_judge] == 0x68)
                    {
                        flag++;
                        int length = builder_temp.Length;
                        string temp_data = builder_temp.ToString();
                        send_data = temp_data.Remove(length - 1);
                        builder_temp.Clear();
                        break;
                    }
                    flag_judge++;
                }
                for (int i = 0; i < n; i++)
                {
                    buf[i] = 0;
                }
                if (flag >= 2)
                {
                    if (flag >= 100)
                    {
                        flag = 0;
                    }
                    deal_value(send_data);
                }

            }));
        }

        /// <summary>
        /// 处理接收的数据
        /// </summary>
        /// <param name="value"></param>
        private void deal_value(string value)
        {
            byte[] RxdBuf = System.Text.Encoding.Default.GetBytes(value);
            if (RxdBuf[0] == 0x01)//采集的传感器值
            {
                if (RxdBuf[1] == 0x03)
                {
                    this.textBox1.Text = RxdBuf[2].ToString() + RxdBuf[3].ToString();//温度
                    this.textBox3.Text = RxdBuf[4].ToString() + RxdBuf[5].ToString();//湿度
                    this.textBox2.Text = RxdBuf[6].ToString() + RxdBuf[7].ToString() + RxdBuf[8].ToString() + RxdBuf[9].ToString();//一氧化碳 
                }
                if ( RxdBuf[1] == 0x05 )
                {
                    minutes = 0;
                    flag_timer = 0;
                    MessageBox.Show("参数下发成功");
                }

            }

            if (RxdBuf[0] == 0x02)//采集的传感器值
            {
                if (RxdBuf[1] == 0x03)
                {
                    this.textBox10.Text = RxdBuf[2].ToString() + RxdBuf[3].ToString() + RxdBuf[4].ToString() + RxdBuf[5].ToString();//烟雾
                    if (RxdBuf[6] =='1')
                    {
                        this.textBox12.Text = "有人靠近";
                        Playmusic();
                    }
                    else
                    {
                        this.textBox12.Text = "正常";
                    }
                }
                if (RxdBuf[1] == 0x04 || RxdBuf[1] == 0x05)
                {
                    minutes = 0;
                    flag_timer = 0;
                    MessageBox.Show("参数下发成功");
                }
            }




        }

        private void open_Click(object sender, EventArgs e)
        {
            this.COMM.PortName = ports.Text;
            this.COMM.BaudRate = int.Parse(botelu.Text);
            this.COMM.Parity = Parity.None;
            this.COMM.StopBits = StopBits.One;
            this.COMM.DataBits = 8;
            try
            {
                this.COMM.Open();
            }
            catch (Exception ex)
            {
                //捕获到异常信息，创建一个新的comm对象，之前的不能用了。  
                this.COMM = new SerialPort();
                //现实异常信息给客户。  
                MessageBox.Show(ex.Message);
            }
            close.Enabled = this.COMM.IsOpen;
            open.Enabled = !this.COMM.IsOpen;
            liang.Enabled = this.COMM.IsOpen;
            button3.Enabled = this.COMM.IsOpen;

        }

        private void close_Click(object sender, EventArgs e)
        {
            if (this.COMM.IsOpen)
            {
                this.COMM.Close();
            }
            open.Enabled = !this.COMM.IsOpen;
            close.Enabled = this.COMM.IsOpen;
            // liang.Enabled = this.COMM.IsOpen;

        }

        private void clone_Click(object sender, EventArgs e)//湿度参数下发
        {
            if (textBox7.Text != "")
            {
                byte canshu = Convert.ToByte(textBox7.Text);//
                if (canshu >= 0 && canshu <= 100)
                {
                    SendBuf[0] = 0x01;//地址
                    SendBuf[1] = 0x05;//功能码
                    SendBuf[2] = 0x00;//
                    SendBuf[3] = canshu;
                    COMM.Write(SendBuf, 0, 4);
                    flag_timer = 1;//定时标志
                }
                else
                {
                    MessageBox.Show("湿度下限设置错误,正确范围为0-100");
                }
            }
            else
            {
                MessageBox.Show("请先输入湿度下限值");
            }

        }


        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {

            Control.CheckForIllegalCrossThreadCalls = false;
            if (flag_timer == 1)
            {
                minutes++;
                if (minutes >= 3)
                {
                    minutes = 0;
                    flag_timer = 0;
                    MessageBox.Show("参数下发失败，请重新下发！");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                int set_gz = Convert.ToInt16(textBox6.Text);//
                if (set_gz >= 0 && set_gz <= 3500)
                {
                    SendBuf[0] = 0x02;//地址
                    SendBuf[1] = 0x04;//功能码
                    SendBuf[2] = (byte)(set_gz / 256);
                    SendBuf[3] = (byte)(set_gz % 256);
                    COMM.Write(SendBuf, 0, 4);
                    flag_timer = 1;//定时标志
                }
                else
                {
                    MessageBox.Show("光照下限设置错误,正确范围为0-3500");
                }
            }
            else
            {
                MessageBox.Show("请先输入光照下限值");
            }
        }
        //音乐函数
        public static void Playmusic()
        {
            try
            {
                SoundPlayer filew = new SoundPlayer();
                filew.SoundLocation = @"F:\air.wav";
                filew.Load();
                filew.Play();//播放一次

            }
            catch (Exception)
            { MessageBox.Show("音效初始化失败！"); }
        }


    }
}
