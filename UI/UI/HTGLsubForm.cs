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
    public partial class HTGLsubForm : Form
    {
        public HTGLsubForm()
        {
            InitializeComponent();
            bind();
            auth();
        }
        //权限验证
        public void auth()
        {
            if (Local.authLevel == 1)
            { this.btnadd.Visible = false;
                skinButton1.Visible = false;
            }
            if (Local.authLevel == 1)
            {
                this.skinContextMenuStrip1.Enabled = false;
            }
        }
        public void bind()
        {
            //设置数据源
            this.skinDataGridView1.DataSource = BLL.HTBLL.searchAllHt(Local.getCurrentUid()).Tables[0];//查询当前用户的合同
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            new HTAddForm(this).ShowDialog();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //删除合同
            int index = this.skinDataGridView1.CurrentRow.Index;
            string htbh = this.skinDataGridView1.Rows[index].Cells[1].Value.ToString();
            if (MessageBox.Show("确认删除？", "确认删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (BLL.HTBLL.deleteHTbyhtbh(htbh)==1)
                {
                    MessageBox.Show("删除成功");
                    bind();
                }
            }
        }

        private void 查看详情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.skinDataGridView1.CurrentRow.Index;
            int htid= Convert.ToInt32(this.skinDataGridView1.Rows[index].Cells[2].Value.ToString());
            new HTdetailForm(htid).ShowDialog();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            new ALLHTForm().ShowDialog();
        }
    }
}
