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
using System.Data;
using BLL;
using Model;
namespace UI
{
    public partial class EmailForm : Skin_DevExpress
    {
        private List<int> _uids;//comboxrecvperson对应的uid;
        public EmailForm()
        {
            InitializeComponent();
            this.txtemailcontent.Text = "";
            this.txtemailtitle.Text = "";
            _uids = new List<int>();
            //初始化收件人combox
            DataTable dtusers = BLL.UserBLL.selectAllUsers().Tables[0];
            this.comboxrecvperson.Items.Clear();
            this._uids.Clear();
            for (int i = 0; i <dtusers.Rows.Count;i++)
            {
                this.comboxrecvperson.Items.Add(dtusers.Rows[i]["员工名字"].ToString());
                this._uids.Add(Convert.ToInt32(dtusers.Rows[i]["员工编号"].ToString()));
            }
            this.comboxrecvperson.SelectedIndex = 0;
            this.skinDataGridViewsjx.AutoGenerateColumns = false;
            this.skinDataGridViewfjx.AutoGenerateColumns = false;
            this.skinDataGridViewljx.AutoGenerateColumns = false;
            //绑定所有表格
            bindAllDataView();
        }
        public void bindAllDataView()
        {
            //绑定收件箱
            DataView dvsjx = BLL.ycEmailBLL.selectAllMyReceivedEmial(Local.getCurrentUid()).DefaultView;
            for (int k = 0; k < dvsjx.Count; k++)
            {
                if (dvsjx[k]["detail"].ToString().Length > 5)
                {
                    dvsjx[k]["detail"] = dvsjx[k]["detail"].ToString().Substring(0, 4) + "...";
                }
            }
            this.skinDataGridViewsjx.DataSource = dvsjx;
            //发件箱
            DataView dvsfajx = BLL.ycEmailBLL.selectAllSentEmail(Local.getCurrentUid()).DefaultView;
            for (int j = 0; j < dvsfajx.Count; j++)
            {
                if (dvsfajx[j]["detail"].ToString().Length > 5)
                {
                    dvsfajx[j]["detail"] = dvsfajx[j]["detail"].ToString().Substring(0, 4) + "...";
                }
            }
            this.skinDataGridViewfjx.DataSource = dvsfajx;

            //垃圾箱
           DataView dvLJX= BLL.ycEmailBLL.selectAllMyfalseDel(Local.getCurrentUid()).DefaultView;
            for (int q = 0; q < dvLJX.Count; q++)
            {
                if (dvLJX[q]["detail"].ToString().Length > 5)
                {
                    dvLJX[q]["detail"] = dvLJX[q]["detail"].ToString().Substring(0, 4) + "...";
                }
            }
            this.skinDataGridViewljx.DataSource = dvLJX;
        }
        private void btnEmailSubmit_Click(object sender, EventArgs e)
        {
            //提交邮件
            string title = this.txtemailtitle.Text.Trim();
            string content = this.txtemailcontent.Text.Trim();
            int senderid = Local.getCurrentUid();
            int receiveerid = this._uids[this.comboxrecvperson.SelectedIndex];
            if (title == "" || title == null || content == "" || content == null)
            {
                MessageBox.Show("没有输入完整！");
                this.bindAllDataView();
                return;
            }
            ycEmail email = new ycEmail();
            email.Detail = content;
            email.Title = title;
            email.Receiver = receiveerid;
            email.Writer = senderid;

            if (BLL.ycEmailBLL.sendEmai(email) == 1)
            {
                MessageBox.Show("邮件发送成功！");
                this.bindAllDataView();
            }
        }

        private void 查看详情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowindex = this.skinDataGridViewsjx.CurrentRow.Index;
            int eid = Convert.ToInt32(this.skinDataGridViewsjx.Rows[rowindex].Cells[0].Value);
            new EmailDetailForm(eid,this).ShowDialog();
        }

        private void 查看详情ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int rowindex = this.skinDataGridViewfjx.CurrentRow.Index;
            int eid = Convert.ToInt32(this.skinDataGridViewfjx.Rows[rowindex].Cells[0].Value);
            new EmailDetailForm(eid,this).ShowDialog();
        }

        private void 查看详情ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int rowindex = this.skinDataGridViewljx.CurrentRow.Index;
            int eid = Convert.ToInt32(this.skinDataGridViewljx.Rows[rowindex].Cells[0].Value);
            new EmailDetailForm(eid,this).ShowDialog();
        }
    }
}
