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
using System.Data;
namespace UI
{
    public partial class WorklogForm : Form
    {
        public WorklogForm()
        {
            InitializeComponent();
        }

        private void WorklogForm_Load(object sender, EventArgs e)
        {
            txtWorklog.Text = "";
            bind();


        }
        //绑定数据源
        public void bind()
        {
            this.skinDataGridView1.DataSource = WorkLogBll.SelectAllWorklog().Tables[0];
            
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //提交
            worklog w = new worklog();
            w.Detail = this.txtWorklog.Text;
            w.Uid = Local.getCurrentUid();
            w.Datetime = DateTime.Now.ToLocalTime().ToString();//YYYY-MM-dd  hh:mm::ss
            if(WorkLogBll.addWorklog(w)==1)
            {
                MessageBox.Show("提交成功");
                bind();
            }
        }
        //删除
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.skinDataGridView1.CurrentRow.Index;
            int lid = Convert.ToInt32(this.skinDataGridView1.Rows[index].Cells[0].Value);
            if (MessageBox.Show("确定删除？", "确定删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (BLL.WorkLogBll.deleteWorklog(lid)==1)
                {
                    MessageBox.Show("删除成功！");
                    bind();
                }
            }
        }

        private void 查看详情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.skinDataGridView1.CurrentRow.Index;
            int lid = Convert.ToInt32(this.skinDataGridView1.Rows[index].Cells[0].Value);
            new worklogDetailForm(lid).ShowDialog();
        }
    }
}
