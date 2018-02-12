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
namespace UI
{
    public partial class ggAdminForm : Skin_DevExpress
    {
        public ggAdminForm()
        {
            InitializeComponent();
            //获取DataView
            DataView dv = BLL.gonggaoBLL.all().DefaultView;
            //过滤较长的字段
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["title"].ToString().Length > 3)
                {
                    dv[i]["title"] = dv[i]["title"].ToString().Substring(0, 3) + "...";
                }
                if (dv[i]["detail"].ToString().Length > 3)
                {
                    dv[i]["detail"] = dv[i]["detail"].ToString().Substring(0, 3) + "...";
                }

            }
            //设置数据源
            this.skinDataGridView1.DataSource = dv;
        }

        private void 查看详情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowindex = this.skinDataGridView1.CurrentRow.Index;
            int gid = Convert.ToInt32(this.skinDataGridView1.Rows[rowindex].Cells[0].Value);
            new gdDetailForm(gid).ShowDialog();
        }

        private void 删除公告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Local.authLevel == 1)
            {
                MessageBox.Show("非管理员不能操作！");
                return;
            }
            int rowindex = this.skinDataGridView1.CurrentRow.Index;
            int gid = Convert.ToInt32(this.skinDataGridView1.Rows[rowindex].Cells[0].Value);
            if (MessageBox.Show("确定删除？", "确定删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BLL.gonggaoBLL.delete(gid);
            }
        }

        //private void 添加公告ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (Local.authLevel == 1)
        //    {
        //        MessageBox.Show("非管理员不能操作！");
        //        return;
        //    }

        //}
    }
}
