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
using BLL;
using Model;
using System.IO;
namespace UI
{
    public partial class loginForm : Skin_DevExpress
    {
        LoginProgressBarForm _progressbar;
        public loginForm()
        {
            InitializeComponent();
            _progressbar = new LoginProgressBarForm();///登录进度
            this.textBoxpwd.PasswordChar = '*';
            //设置焦点事件函数
            this.textBoxpwd.GotFocus += this.OnFocus;
            this.txtID.GotFocus += onIDFouces;
            this.txtID.LostFocus += onlostidfoucus;
            this.textBoxpwd.LostFocus += onlostPwdFouces;
            ////
            if (File.Exists("id.txt") && File.Exists("pwd.txt"))
            {
                this.checkBox1.Checked = true;
                this.txtID.Text = readid();
                this.textBoxpwd.Text = readpwd();
            }
            
        }
        public void onlostPwdFouces(object sender, EventArgs e)
        {
            if (this.textBoxpwd.Text == "")
            {
                this.textBoxpwd.Text = "请输入密码";
               // this.textBoxpwd.UseSystemPasswordChar = false;
            }
        }
        public void onlostidfoucus(object snder, EventArgs E)
        {
            if (this.txtID.Text == "")
            {
                this.txtID.Text = "请输入ID";
            }

        }
        public void onIDFouces(object sender, EventArgs e)
        {
            if (this.txtID.Text== "请输入ID" || this.txtID.Text=="")
            this.txtID.Text = "";
        }
        public void OnFocus(object sender, EventArgs e)
        {
            if (this.textBoxpwd.Text == "请输入密码" || this.textBoxpwd.Text == "")
                this.textBoxpwd.Text = "";
            this.textBoxpwd.PasswordChar = '*';
           
        }
      

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            int uid = Convert.ToInt32(txtID.Text);
            string pwd = textBoxpwd.Text;
            UserInfo u = new UserInfo();
            u.Uid = uid;
            u.Password = pwd;
            if (BLL.UserBLL.login(u) == 1)
            {
                //设置权限
                setAuth(uid); //鉴权

                //保存密码
                if (this.checkBox1.Checked==true)
                savepwd(uid.ToString(), pwd);//保存密码
                //设置全局变量
                Local.setCurrentUid(uid);
                Local._uname = BLL.UserBLL.selectOneByUID(u).Tables[0].Rows[0]["员工名字"].ToString();
              //  this.Hide();
                _progressbar.Show();
                timer1.Start();
                //this.DialogResult = DialogResult.OK;
                //this.Close();
            }
            else {
                MessageBox.Show("账号和或密码错误");
            }
        }
        //保存id和密码
        public void savepwd(string id, string pwd)
        {
            if (File.Exists("id.txt")) File.Delete("id.txt");
            if (File.Exists("pwd.txt")) File.Delete("pwd.txt");
            ////
            FileStream idfs = new FileStream("id.txt", FileMode.OpenOrCreate);
            StreamWriter idsw = new StreamWriter(idfs);
            idsw.Write(id);
            idsw.Flush();
            idsw.Close();
            idfs.Close();
            //

            FileStream pwdfs = new FileStream("pwd.txt", FileMode.OpenOrCreate);
            StreamWriter pwdsw = new StreamWriter(pwdfs);
            pwdsw.Write(pwd);
            pwdsw.Flush();
            pwdsw.Close();
            pwdfs.Close();
            ///
        }
        //读取id
        public string readid()
        {
            if (!File.Exists("id.txt")) return "0";
            FileStream fs = new FileStream("id.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
           string data= sr.ReadToEnd();
            sr.Close();
            fs.Close();
            return data;
        }
        //读取密码
        public string readpwd()
        {
            if (!File.Exists("pwd.txt")) return "0";
            FileStream fs = new FileStream("pwd.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string data = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            return data;
        }
        //设置权限
        public void setAuth(int uid)
        {
            UserInfo u = new UserInfo();
            u.Uid = uid;
            DataTable dt=BLL.UserBLL.selectOneByUID(u).Tables[0];
            int jobid = Convert.ToInt32(dt.Rows[0]["职位ID"]);//根据职位去设置权限
            if (jobid == 2 || jobid == 5 || jobid == 7 || jobid == 10 || jobid == 11 || jobid == 13)
            {
                Local.authLevel = 2;
            }
            else {
                Local.authLevel = 1;
            }
        }
        //定时器处理
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Stop();
             this.DialogResult = DialogResult.OK;
            _progressbar.Close();
             this.Close();
        }
    }
}
