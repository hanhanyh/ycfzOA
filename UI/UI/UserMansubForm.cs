using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
namespace UI
{
    public partial class UserMansubForm : Form
    {
        public UserMansubForm()
        {
            InitializeComponent();
            init();
            auth();//auth权限
        }
        //权限验证
        public void auth()
        {
            if (Local.authLevel == 1) this.btnadd.Visible = false;
            if (Local.authLevel == 1)
            {
                this.skinDataGridView1.Enabled = false;
                this.btndepartman.Visible = false;
                btnManagejob.Visible = false;
            }
        }
        //初始化控件
        public void init()
        {
            this.txtSearch.Text = "";
            bind();

        }
        //绑定数据源
        public void bind()
        {
            this.skinDataGridView1.DataSource = BLL.UserBLL.selectAllUsers().Tables[0];
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtSearch.Text.Trim() == "")
            {
                init();
            }
            else {
                this.skinDataGridView1.DataSource = BLL.UserBLL.SelectStaffByLikeName(this.txtSearch.Text.Trim()).Tables[0];
            }
        }

        private void 员工详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           
        }

        private void 详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            int index = this.skinDataGridView1.CurrentRow.Index;
            UserInfo u = new UserInfo();
            u.Uid = Convert.ToInt32(this.skinDataGridView1.Rows[index].Cells[0].Value.ToString());

            new UserInfoDetailDLG(u.Uid,this).ShowDialog();
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            new addUserForm(this).ShowDialog();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //删除
            int index = this.skinDataGridView1.CurrentRow.Index;
            UserInfo u = new UserInfo();
            u.Uid = Convert.ToInt32(this.skinDataGridView1.Rows[index].Cells[0].Value.ToString());
            if (MessageBox.Show("确定删除？", "确定删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (BLL.UserBLL.deleteStaffTrue(u) == 1)
                {
                    MessageBox.Show("删除成功！");
                    bind();
                }
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void btndepartman_Click(object sender, EventArgs e)
        {
            new departAdminForm().ShowDialog();
        }

        private void btnManagejob_Click(object sender, EventArgs e)
        {
            new JobAdminForm().ShowDialog();
        }
    }
}
