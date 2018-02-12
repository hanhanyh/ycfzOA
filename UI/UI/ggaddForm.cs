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
namespace UI
{
    public partial class ggaddForm : Skin_DevExpress
    {
        public ggaddForm()
        {
            InitializeComponent();
            //
            this.skinProgressBar1.Visible = false;//默认为关闭显示
            //init skinprogressbar
            this.skinProgressBar1.Step = 5;
            this.skinProgressBar1.Maximum = 100;
            this.skinProgressBar1.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  this.timer1.Start();
            if (txtContent.Text == "" || txtTitle.Text == "")
            {
                MessageBox.Show("没有填写完整");
            }
            else
            {

                if (MessageBox.Show("确定发布", "确定发布", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (this.checkBox1.Checked == true)//启用推送
                    {
                        this.skinProgressBar1.Visible = true;//显示进度条
                        this.timer1.Start();//开始进度条
                    }
                    else      //直接插入数据库
                    {
                        Gonggao gg = new Gonggao();
                        gg.Title = txtTitle.Text;
                        gg.Detail = txtContent.Text;
                        gg.Uid = Local.getCurrentUid();
                        gg.Datetime = DateTime.Now.ToLocalTime().ToString();
                        BLL.gonggaoBLL.add(gg);
                        MessageBox.Show("公告发布成功！");
                        this.Close();
                    }
                }
            }
            
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.skinProgressBar1.PerformStep();//按照设置的Step进行一步一步增加
            if (this.skinProgressBar1.Value >= 100)//进度条跑满
            {
                Gonggao gg = new Gonggao();
                gg.Title = txtTitle.Text;
                gg.Detail = txtContent.Text;
                gg.Uid = Local.getCurrentUid();
                gg.Datetime = DateTime.Now.ToLocalTime().ToString();
                BLL.gonggaoBLL.add(gg);
                this.timer1.Stop();//关闭定时器
                Local.getClientInstance().sendData(gg.Detail);//发送到服务器
                MessageBox.Show("公告发布,并推送到所有客户端！");
                this.Close();
            } 
        }
    }
}
