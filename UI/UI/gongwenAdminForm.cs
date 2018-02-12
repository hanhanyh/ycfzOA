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
namespace UI
{
    public partial class gongwenAdminForm : Skin_DevExpress
    {
        public gongwenAdminForm()
        {
            InitializeComponent();
            bind();
        }
        public void bind()
        {
            //设置数据源
            this.skinDataGridView1.DataSource = BLL.gongwenBLL.SelectallDepart();
        }

        private void skinDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //改变数据
            if (this.skinDataGridView1.Columns[e.ColumnIndex].Name == "ColumnAccept" || e.Value != null)
            {
                if (e.Value.ToString() == "True")
                {
                    e.Value = "已审核";
                }
                else if(e.Value.ToString()=="False") {
                    e.Value = "未审核";
                }
            }
        }

        private void 查看详情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowindex = this.skinDataGridView1.CurrentRow.Index;
           int qid= Convert.ToInt32(this.skinDataGridView1.Rows[rowindex].Cells[0].Value);
            new gwdetailForm(qid,this).ShowDialog();
        }
    }
}
