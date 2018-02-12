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
using Model;
namespace UI
{
    public partial class EmailDetailForm : Skin_DevExpress
    {
        private int _eid;
        private EmailForm _mform;
        public EmailDetailForm(int eid, EmailForm form)
        {
            InitializeComponent();
            _mform = form;
            _eid = eid;
            //设置为已读
            BLL.ycEmailBLL.setisRead(eid);
            //判断是否存在垃圾箱内
            DataTable dtdetail = BLL.ycEmailBLL.selectOneByEID(_eid);
            int isdelete = Convert.ToInt32(dtdetail.Rows[0]["isdelete"]);
            //是否正在垃圾箱内
            if (isdelete == 1)
            {
                this.skinButtonfalseDelete.Text = "移出垃圾箱";
            }
            else
            {
                this.skinButtonfalseDelete.Text = "放入垃圾箱";
            }
            /////
            DataTable dt = BLL.ycEmailBLL.selectOneByEID(_eid);
          int isOwner =Convert.ToInt32(dt.Rows[0]["isOwner"]);
            if (isOwner == 1)//我是发件人
            {
                skinLabelrows2topic.Text = "收件人";
                int uid = Convert.ToInt32(dt.Rows[0]["receiver"]);
                UserInfo u = new UserInfo();
                u.Uid = uid;
               DataTable dtuser= BLL.UserBLL.selectOneByUID(u).Tables[0];
               this.skinLabelAuthor.Text= dtuser.Rows[0]["员工名字"].ToString();
            }
            else
            {
                skinLabelrows2topic.Text = "发件人";
                int uid = Convert.ToInt32(dt.Rows[0]["writer"]);
                UserInfo u = new UserInfo();
                u.Uid = uid;
                DataTable dtuser = BLL.UserBLL.selectOneByUID(u).Tables[0];
                this.skinLabelAuthor.Text = dtuser.Rows[0]["员工名字"].ToString();
            }
            //设置标题
            this.skinLabelTitle.Text = dt.Rows[0]["Title"].ToString();
            this.skinTextBoxContent.Text = dt.Rows[0]["detail"].ToString();
            this.skinTextBoxContent.Enabled = false;
            
        }

        private void skinButtonClose_Click(object sender, EventArgs e)
        {
            //关闭
            this.Close();
        }

        private void skinButtonfalseDelete_Click(object sender, EventArgs e)
        {
            //查询
           DataTable dtdetail= BLL.ycEmailBLL.selectOneByEID(_eid);
           int isdelete=  Convert.ToInt32(dtdetail.Rows[0]["isdelete"]);
            if (isdelete == 0)
            {
                if (BLL.ycEmailBLL.falsedeleteBYEID(_eid) == 1)
                {
                    _mform.bindAllDataView();
                  //  MessageBox.Show("成功放入垃圾箱");
                    this.Close();
                }
            }
            else {
                if (BLL.ycEmailBLL.moveout(_eid) == 1)
                {
                    _mform.bindAllDataView();
                 //   MessageBox.Show("移出垃圾箱成功");
                    this.Close();
                }
            }
            
        }

        private void skinButtontruedel_Click(object sender, EventArgs e)
        {
            //删除
            if (MessageBox.Show("确定删除？", "确定删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {

                if (BLL.ycEmailBLL.trueDeleteBYEID(_eid) == 1)
                {
                    MessageBox.Show("删除成功");
                    this._mform.bindAllDataView();
                    this.Close();
                }
            }
        }
    }
}
