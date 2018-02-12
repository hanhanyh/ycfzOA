using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;
using System.Data;
namespace UI
{
    public partial class HomeSubForm : Form
    {

        //WeatherForm _weatherform = null;
        public HomeSubForm()
        {
            InitializeComponent();

            // this.picHeader.ImageLocation = "1.jpg";
            //init header初始化头像
            //string headurl = BLL.UserBLL.selectMyHeader(Local.getCurrentUid());
            //if (headurl == null || headurl == "")
            //{
            //    this.picHeader.Load("img/touxiang.png");
            //}
            //else
            //{
            //    this.picHeader.Load(headurl);
            //}
            //绑定最新一条公告
            txtGonggao.Enabled = false;
            txtGonggao.Text = BLL.gonggaoBLL.selectLastOne().Rows[0]["detail"].ToString(); ;
            bindHead();
            //
            //bind  sign btn
            if (BLL.KQBLL.isSignIned(Local.getCurrentUid()) == 1)
            {
              //  this.btnsignin.Text = "签退";
            }
            if (BLL.KQBLL.isSignOut(Local.getCurrentUid()) >0)
            {
               this.btnsignin.Text = "您已签退";
                this.btnsignin.Enabled = false;
            }
            /////绑定日程
            bindRicheng();
            //未读邮件
            skinDataGridViewemail.AutoGenerateColumns = false;
            skinDataGridViewemail.DataSource = BLL.ycEmailBLL.selectAllMyRecvUnReadEmail(Local.getCurrentUid());
            if (Local.authLevel == 1) this.btnaddgg.Visible = false;
           
        }
        public void bindRicheng()
        {
            //日程表格
            this.skinDataGridViewricheng.AutoGenerateColumns = false;
            this.skinDataGridViewricheng.DataSource = BLL.richengBLL.selectUnFinishedBYUID(Local.getCurrentUid());
        }
       public void bindHead()
        {
            //绑定头像
            string headurl = BLL.UserBLL.selectMyHeader(Local.getCurrentUid());
            if (headurl == null || headurl == "")
            {
                this.picHeader.Load("img/touxiang.png");
            }
            else
            {
                this.picHeader.Load(headurl);
            }

        }
        private void HomeSubForm_Load(object sender, EventArgs e)
        {
            //查询员工信息
            UserInfo ui = new UserInfo();
            ui.Uid = Local.getCurrentUid();
           DataTable dt=  BLL.UserBLL.selectOneByUID(ui).Tables[0];
            labID.Text = dt.Rows[0]["员工编号"].ToString();
            labName.Text= dt.Rows[0]["员工名字"].ToString();
            labJob.Text = dt.Rows[0]["职务"].ToString();
            labSex.Text=dt.Rows[0]["性别"].ToString()=="True"?"男":"女";
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            //签到按钮
            if (BLL.KQBLL.isSignIned(Local.getCurrentUid()) >0)//已签到了 就执行签退
            {
                UserInfo uinfo = new UserInfo();
                uinfo.Uid = Local.getCurrentUid();

                if (BLL.KQBLL.signOut(uinfo) == 1)
                {
                    MessageBox.Show("签退成功！");
                   this.btnsignin.Text = "已签退";
                    this.btnsignin.Enabled = false;
                    return;
                }
            }
            if (BLL.KQBLL.isSignOut(Local.getCurrentUid()) > 0)//已签退了
            {
                MessageBox.Show("已签退！");
                return;
            }
            if (BLL.KQBLL.isSignIned(Local.getCurrentUid()) == 0)//未签到
            {
                UserInfo uinfo = new UserInfo();
                uinfo.Uid = Local.getCurrentUid();

                if (BLL.KQBLL.signIn(uinfo) == 1)
                {
                    MessageBox.Show("签到成功！");
               //     this.btnsignin.Text = "签退";
                    return;
                }
            }
        }

        private void btnmyinfo_Click(object sender, EventArgs e)
        {
            //我的信息对话框
            new MySelfInfoForm(this).ShowDialog();
        }

        private void btnricehng_Click(object sender, EventArgs e)
        {
            new AllrichengForm().ShowDialog();
        }

        private void skinDataGridViewricheng_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //数据转换
            if (this.skinDataGridViewricheng.Columns[e.ColumnIndex].Name == "zyLevel" && e.Value != null)
            {
                if (e.Value.ToString() == "1")
                {
                    e.Value = "一般";
                }
                else if (e.Value.ToString() == "2")
                {
                    e.Value = "一般重要";
                }
                else if (e.Value.ToString() == "1")
                {
                    e.Value = "非常重要";
                }
            }
            if (this.skinDataGridViewricheng.Columns[e.ColumnIndex].Name == "isFinished" && e.Value != null)
            {
                if (e.Value.ToString() == "True")
                {
                    e.Value = "已完成";
                }
                else {
                    e.Value = "待完成";
                }
            }
        }

        private void 查看详情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //查看详情
            int rowindex = this.skinDataGridViewricheng.CurrentRow.Index;
            int rid = Convert.ToInt32(this.skinDataGridViewricheng.Rows[rowindex].Cells[0].Value);
            AllrichengForm f = new AllrichengForm();
            new richengdetailsmallForm(rid, f).ShowDialog();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //删除
            int rowindex = this.skinDataGridViewricheng.CurrentRow.Index;
            int rid = Convert.ToInt32(this.skinDataGridViewricheng.Rows[rowindex].Cells[0].Value);
            if (MessageBox.Show("确定删除?", "确认删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (BLL.richengBLL.deleteByRID(rid) == 1)
                {

                    MessageBox.Show("删除成功");
                    bindRicheng();
                }
            }
            
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            new EmailForm().ShowDialog();
        }
        //显示时间
        private void timer1time_Tick(object sender, EventArgs e)
        {
            this.labelTime.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void 查看详情ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int rowindex = this.skinDataGridViewemail.CurrentRow.Index;
            int eid = Convert.ToInt32(this.skinDataGridViewemail.Rows[rowindex].Cells[0].Value);
            new EmailDetailForm(eid, new EmailForm()).Show();
        }

        private void btnmoregg_Click(object sender, EventArgs e)
        {
            new ggAdminForm().ShowDialog();
        }

        private void btnaddgg_Click(object sender, EventArgs e)
        {
            new ggaddForm().ShowDialog();
        }

        

        private void btnWeather_Click(object sender, EventArgs e)
        {
            WeatherForm _weatherform = new WeatherForm();
            _weatherform.ShowDialog();
        }
    }
}
