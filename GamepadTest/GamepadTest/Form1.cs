using OpenJigWare;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Text;


namespace GamepadTest
{
    public partial class Form1 : Form
    {
        Socket socket;
        public Form1()
        {

            InitializeComponent();
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("192.168.43.240", 8000);
                Console.WriteLine("Connect successful ! \n");
                Thread t1 = new Thread(new ThreadStart(Read_Data));
                t1.Start();
            }
            catch
            {
                Console.WriteLine("server: " + "192.168.43.240" + "  port: " + 8000 + " can't connect \r\n");
                //tb_show.AppendText("server: " + tb_ip.Text + "  port: " + tb_port.Text + " can't connect \r\n");
                return;
            }
        }
        void Read_Data()
        {
            while (true)
            {
                try
                {
                    int dataLenght;
                    byte[] myBufferBytes = new byte[1024];
                    dataLenght = socket.Receive(myBufferBytes);
                    Array.Resize(ref myBufferBytes, dataLenght);
                    //BeginInvoke(new MethodInvoker(() =>
                    //{
                    //tb_show.AppendText("[" + System.DateTime.Now + "] Server : " + Encoding.ASCII.GetString(myBufferBytes, 0, dataLenght) + "\r\n");
                    //tb_show.AppendText(Encoding.ASCII.GetString(myBufferBytes, 0, dataLenght) + "\r\n");
                    //}));
                    Console.WriteLine("[" + System.DateTime.Now + "] Server : " + Encoding.ASCII.GetString(myBufferBytes, 0, dataLenght) + "\r\n");
                    //Console.WriteLine(Encoding.ASCII.GetString(myBufferBytes, 0, dataLenght) + "\r\n");
                }
                catch (SocketException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        ////搖桿位置座標
        float x1 = 115;     //極限100*更號2=114.14
        float y1 = 115;
        float x2 = 115;
        float y2 = 115;
        private void Form1_Load(object sender, EventArgs e)     //搖桿位置圖
        {
            Ojw.CMessage.Init(txtMessage);
            panel1.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton2);
            panel3.Controls.Add(radioButton3);

            timer1.Enabled = true;
            radioButton1.Location = new Point((int)x1, (int)y1);
            radioButton2.Location = new Point((int)x2, (int)y2);
        }

        private float[] m_afAngle = new float[20];

        private Ojw.CJoystick m_CJoy = new Ojw.CJoystick(Ojw.CJoystick._ID_0); // 搖桿宣告
        private Ojw.CTimer m_CTmr_Joystick = new Ojw.CTimer(); // 計時器定期檢查操縱桿的連接狀況
        ///////////////////  連線部分  ///////////////////  
        private void FJoystick_Check_Alive()
        {
            #region Joystick Check

            Color m_colorLive = Color.Green; // 已經連線
            Color m_colorDead = Color.Gray;  // 尚未連線
            if (m_CJoy.IsValid == false)
            {
                # region 表示未連接操縱桿
                if (lbJoystick.ForeColor != m_colorDead)
                {
                    lbJoystick.Text = "Joystick (No Connected)";
                    lbJoystick.ForeColor = m_colorDead;
                }
                #endregion 表示操縱桿未連接

                #region 每3    秒嘗試重新連接一次
                if (m_CTmr_Joystick.Get() > 3000) // Joystic 是否死掉
                {
                    Ojw.CMessage.Write("Joystick Check again");
                    m_CJoy = new Ojw.CJoystick(Ojw.CJoystick._ID_0);

                    if (m_CJoy.IsValid == false)
                    {
                        Ojw.CMessage.Write("But we can't find a joystick device in here. Check your joystick device");
                        m_CTmr_Joystick.Set(); //重新設定計時器
                    }
                    else Ojw.CMessage.Write("Joystick is Connected");
                }
                #endregion 嘗試每3秒重新連接一次
            }
            else
            {
                #region 連線
                if (lbJoystick.ForeColor != m_colorLive)
                {
                    lbJoystick.Text = "Joystick (Connected)";
                    lbJoystick.ForeColor = m_colorLive;
                }
                #endregion 已經連線
            }
            #endregion Joystick Check
        }
        string DpadKorean = "";
        string DpadEnglish = "";

        private void FJoystick_Check_Data()
        {
            /////////////////  左上的方向鍵  ///////////////////
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.POVLeft) == true)
            {
                DpadKorean = "左 ";
                DpadEnglish = "Left ";
            }
            else if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.POVRight) == true)
            {
                DpadKorean = "右 ";
                DpadEnglish = "Right ";
            }
            else
            {
                DpadKorean = "";
                DpadEnglish = "";
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.POVUp) == true)
            {
                DpadKorean += "上";
                DpadEnglish += "Up";
            }
            else if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.POVDown) == true)
            {
                DpadKorean += "下";
                DpadEnglish += "Down";
            }
            if (DpadKorean == "")
            {
                DpadKorean = "中間";
                DpadEnglish = "Not pressed";
            }

            ///////////////////  右上的按鈕  ///////////////////         
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button4) == true)    //Y
            {
                lblY.ForeColor = Color.Red;     //按下顯示紅色字體
            }
            else
            {
                lblY.ForeColor = Color.Black;   //沒有按下則黑色字體
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button3) == true)    //X
            {
                lblX.ForeColor = Color.Red;
            }
            else
            {
                lblX.ForeColor = Color.Black;
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button2) == true)    //B
            {
                lblB.ForeColor = Color.Red;
            }
            else
            {
                lblB.ForeColor = Color.Black;
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button1) == true)    //A
            {
                lblA.ForeColor = Color.Red;
            }
            else
            {
                lblA.ForeColor = Color.Black;
            }

            ///////////////////  前方的按鈕  ///////////////////    
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button5) == true)    //左前方(上)
            {
                lblLeft.ForeColor = Color.Red;
            }
            else
            {
                lblLeft.ForeColor = Color.Black;
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button6) == true)    //右前方(上)
            {
                lblRight.ForeColor = Color.Red;
            }
            else
            {
                lblRight.ForeColor = Color.Black;
            }




            if (radioButton3.Location.X < 84)    //左前方(下)
            {
                lblLeft2.ForeColor = Color.Red;
            }
            else
            {
                lblLeft2.ForeColor = Color.Black;
            }
            if (radioButton3.Location.X > 84)    //右前方(下)
            {
                lblRight2.ForeColor = Color.Red;
            }
            else
            {
                lblRight2.ForeColor = Color.Black;
            }




            ///////////////////  中間的按鈕  ///////////////////    
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button7) == true)    //BACK
            {
                back.ForeColor = Color.Red;
            }
            else
            {
                back.ForeColor = Color.Black;
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button8) == true)    //START
            {
                start.ForeColor = Color.Red;
            }
            else
            {
                start.ForeColor = Color.Black;
            }

            ///////////////////  搖桿的按鈕  ///////////////////    
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button9) == true)    //LC
            {
                LC.ForeColor = Color.Red;
            }
            else
            {
                LC.ForeColor = Color.Black;
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button10) == true)    //RC
            {
                RC.ForeColor = Color.Red;
            }
            else
            {
                RC.ForeColor = Color.Black;
            }

            //if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.StickUp) == true)    //RC
            //{
            //    byte[] data = { (byte)'S', (byte)'F', 10, (byte)'E' };
            //    socket.Send(data);
            //}
            //else
            //{
            //    byte[] data = { (byte)'S', (byte)'L', 0, (byte)'E' };
            //    socket.Send(data);
            //}


            label1.Text = DpadKorean + "\r\n" + DpadEnglish;
            radioButton1.Location = new Point((int)(x1 * 1.8 * m_CJoy.dX0), (int)(y1 * 1.8 * m_CJoy.dY0));      //介面搖桿部分
            radioButton2.Location = new Point((int)(x2 * 1.8 * m_CJoy.dX1), (int)(y2 * 1.8 * m_CJoy.dY1));
            //txt顯示絕對位置的距離
            //textBox1.Text = Convert.ToString("X = " + (40 * m_CJoy.dX0 - 20) + "\r\nY = " + (-10 * m_CJoy.dY0 + 5));        
            //textBox2.Text = Convert.ToString("X = " + (40 * m_CJoy.dX1-20)+ "\r\nY = " + (-10 * m_CJoy.dY1+5));
            textBox1.Text = Convert.ToString("X = " + m_CJoy.dX0 + "\r\nY = " + m_CJoy.dY0);
            textBox2.Text = Convert.ToString("X = " + m_CJoy.dX1 + "\r\nY = " + m_CJoy.dY1);
            radioButton3.Location = new Point((int)(168 - m_CJoy.Slide * 168), 10);

            byte[] data_1 = { (byte)'S', (byte)'F', (byte)(255 - m_CJoy.dY0 * 255), (byte)'E' };
            socket.Send(data_1);
            byte[] data_2 = { (byte)'S', (byte)'L', (byte)(m_CJoy.dX1 * 255), (byte)'E' };
            socket.Send(data_2);

            //Console.WriteLine(m_CJoy.Slide);

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //更新搖桿信息
            m_CJoy.Update();
            //檢查搖桿是否連線的功能
            FJoystick_Check_Alive();
            //得到搖桿數據
            FJoystick_Check_Data();             
        }
    }
}
