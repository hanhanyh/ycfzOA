using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
namespace UI
{
    
    public partial class MainForm : Skin_DevExpress
    {
        public delegate void HandlerShowWindowGG(string data);//公告弹窗委托
        public event HandlerShowWindowGG showWin;//公告弹窗委托 事件（多播）
        //
        GGClient _client;
        //用于拖动窗口
        bool beginMove = false;
        int currentXPosition;
        int currentYPosition;
        public MainForm()
        {
            InitializeComponent();
            ///
            showWin += showGG;
            //初始化网络模块
            initNetWork();
            ///
            HomeSubForm hsf = new HomeSubForm();
            hsf.BackColor = Color.FromArgb(240,240,240);
            hsf.TopLevel = false;//设置不为顶级窗口
            hsf.Size = this.skinPanel1.Size;
            this.skinPanel1.Controls.Add(hsf);
            hsf.Show();
        }
        public void showGG(string data)
        {
            new clientRecvForm(data).Show();
        }
        public void initNetWork()
        {
            _client = Local.getClientInstance();
     //        _client.sendData("xxx");//hello
            _client.eventRecvd += onRecv;
     
        }
    
        //新消息来到！！！
        public void onRecv(string data)
        {
            //   MessageBox.Show("接收数据"+data);
            this.Invoke(showWin, data);//onRecv是子线程调用，这里需要Invoke用主线程调用委托！（！）
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.skinPanel1.Controls.Clear();
            HomeSubForm hsf = new HomeSubForm();
            hsf.BackColor = Color.FromArgb(240, 240, 240);
            hsf.TopLevel = false;
            hsf.Size = this.skinPanel1.Size;
            this.skinPanel1.Controls.Add(hsf);
            hsf.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            
                this.skinPanel1.Controls.Clear();
                UserMansubForm umf = new UserMansubForm();
                umf.BackColor = Color.FromArgb(240, 240, 240);
                umf.TopLevel = false;
                umf.Size = this.skinPanel1.Size;
                this.skinPanel1.Controls.Add(umf);
                umf.Show();
        }

        private void btnHTGL_Click(object sender, EventArgs e)
        {
            this.skinPanel1.Controls.Clear();
            HTGLsubForm hsf = new HTGLsubForm();
            hsf.BackColor = Color.FromArgb(240, 240, 240);
            hsf.TopLevel = false;
            hsf.Size = this.skinPanel1.Size;
            this.skinPanel1.Controls.Add(hsf);
            hsf.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGZRZ_Click(object sender, EventArgs e)
        {
            this.skinPanel1.Controls.Clear();
            WorklogForm wlf = new WorklogForm();
            wlf.BackColor = Color.FromArgb(240, 240, 240);
            wlf.TopLevel = false;
            wlf.Size = this.skinPanel1.Size;
            this.skinPanel1.Controls.Add(wlf);
            wlf.Show();
        }

        private void BTNGWGL_Click(object sender, EventArgs e)
        {

            this.skinPanel1.Controls.Clear();
            gongwenForm gwf = new gongwenForm();
            gwf.BackColor = Color.White;
            gwf.TopLevel = false;
            gwf.Size = this.skinPanel1.Size;
            this.skinPanel1.Controls.Add(gwf);
            gwf.Show();
        }

        private void btnkq_Click(object sender, EventArgs e)
        {
            this.skinPanel1.Controls.Clear();
            KQRecordForm krf = new KQRecordForm();

            krf.BackColor = Color.White;
            krf.TopLevel = false;
            krf.Size = this.skinPanel1.Size;
            this.skinPanel1.Controls.Add(krf);
            krf.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //鼠标按下
        private void skinPictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //将鼠标坐标赋给窗体左上角坐标  
            beginMove = true;
            currentXPosition = MousePosition.X;
            currentYPosition = MousePosition.Y;
            this.Refresh();
        }

        private void skinPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            //设置初始状态  
            currentXPosition = 0;
            currentYPosition = 0;
            beginMove = false;
        }

        private void skinPictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                //根据鼠标X坐标确定窗体X坐标  
                this.Left += MousePosition.X - currentXPosition;
                //根据鼠标Y坐标确定窗体Y坐标  
                this.Top += MousePosition.Y - currentYPosition;
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void skinPictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            beginMove = false;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIM_Click(object sender, EventArgs e)
        {
            this.skinPanel1.Controls.Clear();
          //  this.skinPanel1.BackgroundImage= Image.FromFile("img/chatBkg.jpg");
            ChatForm chat = new ChatForm();
            // chat.BackColor = Color.FromArgb(240, 240, 240);
            //chat.BackColor = Color.Transparent;
            //  chat.BackgroundImage = Image.FromFile("img/chatBkg.jpg");
            chat.TopLevel = false;
            //   chat.Size = this.skinPanel1.Size;
            chat.Top = 10;
            chat.Left = 20;//不晓得为啥要跑，这里把它写死
            this.skinPanel1.Controls.Add(chat);
            chat.Show();
        }

        private void btnXCGL_Click(object sender, EventArgs e)
        {
            this.skinPanel1.Controls.Clear();
            xcForm xcf = new xcForm();

          xcf.BackColor = Color.FromArgb(240, 240, 240);
            xcf.TopLevel = false;
            xcf.Size = this.skinPanel1.Size;
            this.skinPanel1.Controls.Add(xcf);
            xcf.Show();
        }

        private void btnJXGL_Click(object sender, EventArgs e)
        {

            this.skinPanel1.Controls.Clear();
            jxForm jjf = new jxForm();

            jjf.BackColor = Color.White;
            jjf.TopLevel = false;
            jjf.Size = this.skinPanel1.Size;
            this.skinPanel1.Controls.Add(jjf);
            jjf.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;//关闭窗口
            System.Environment.Exit(0);//强制退出所有线程
        }
    }
}
