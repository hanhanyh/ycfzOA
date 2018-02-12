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
    public partial class departAdminForm : Skin_DevExpress
    {
        public departAdminForm()
        {
            InitializeComponent();
            //绑定数据源
            this.skinDataGridView1.DataSource = BLL.departmentBLL.selectalldeparts();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.skinDataGridView1.CurrentRow.Index;
         int did   = Convert.ToInt32(this.skinDataGridView1.Rows[index].Cells[0].Value);
            if (MessageBox.Show("确定删除？", "确定删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BLL.departmentBLL.delete(did);
                //绑定数据源
                this.skinDataGridView1.DataSource = BLL.departmentBLL.selectalldeparts();
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
          string name= this.txtBox.Text;
            department de = new department();
            de.Name = name;
            BLL.departmentBLL.department_ADD(de);
            txtBox.Text = "";
            //绑定数据源
            this.skinDataGridView1.DataSource = BLL.departmentBLL.selectalldeparts();
        }
    }
}
