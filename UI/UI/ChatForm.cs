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
using Model;
using BLL;
using WebSocketSharp;
using System.IO;
namespace UI
{
    public partial class ChatForm : Form
    {
        public  string boxdata="";
         public  string  _uname = "";
        private WebSocket _client;
        public delegate void  recvHandler(string data, string uname);
        public delegate void setBoxHandler(string data);
        public event setBoxHandler setBoxFunctor;
        public void setBoxFun(string data)//消息显示的事件-处理函数
        {
           
            object[] objects = new object[1];
            objects[0] = data;
            this.chatbox.Document.InvokeScript("addMessage", objects);
            this.chatbox.Document.Window.ScrollTo(0, 99999999);//指向最下面scroll
           
        }
        public ChatForm()
        {
            InitializeComponent();
            //  Control.CheckForIllegalCrossThreadCalls = false;//关闭线程安全监测
            _uname = Local._uname;
            _client = new WebSocket("ws://localhost:4649/Chat");
            setBoxFunctor += this.setBoxFun;////设置事件处理函数（多播）
            _client.OnOpen += this.onOpen;
            _client.OnMessage += this.OnMessage;
            this.chatbox.Navigate(Application.StartupPath + "/chatdata.html");
            _client.Connect();
            /***绑定Treeview**/
            //DataTable dtusers = BLL.UserBLL.selectAllUsers().Tables[0];
            //for (int i = 0; i < dtusers.Rows.Count; i++)
            //{
            //    this.skinListView1.Items.Add(dtusers.Rows[i]["员工名字"].ToString());
            //}
            this.dataGridView1.DataSource = BLL.UserBLL.selectallComm();
        }
       
        private void skinButtonSubmit_Click(object sender, EventArgs e)
        {

            string data = this.skinTextBoxdetail.Text;
           //发送数据包
            this._client.Send(data);
            this.skinTextBoxdetail.Text = "";

        }
        private void onOpen(object sender, EventArgs e)
        {
            //发送名称作为标识
            this._client.Send(_uname);
           
        }
        private void OnMessage(object sender, MessageEventArgs e)
        {
            //拆分数据包
            string[] datas = e.Data.Split('|');
            string headpath = Application.StartupPath + "/img/touxiang.png";
            _uname = datas[0];
            string data = "";
            data += "<img src=\"" + headpath + " \"  width=\"40\" height=\"40\">";
            data += "&nbsp" + "<label style=\"font-size=12px;font-weight:bold;\" >" + _uname + "</label>";
            data += "&nbsp " + DateTime.Now.ToLocalTime().ToString() + "<br><br>";
            data += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp" + datas[1] + "<br/><br/><br/>";
            /////调用UI线程的委托
            this.chatbox.Invoke(setBoxFunctor, data);
         
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {

            chatbox.ObjectForScripting = this;
           // setBoxFun("<label style=\"font-size:12px;\">正在连接通信服务器...</label><br/>");
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (this.txtSearch.Text.Trim() == "")
            {
                this.dataGridView1.DataSource = BLL.UserBLL.selectallComm();
            }
            else {
                this.dataGridView1.DataSource = BLL.UserBLL.selectCommLike(this.txtSearch.Text);
            }
        }
    }
}
