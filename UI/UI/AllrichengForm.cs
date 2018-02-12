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
using Model;
namespace UI
{
    public partial class AllrichengForm : Skin_DevExpress
    {
        public AllrichengForm()
        {
            InitializeComponent();
            ////关闭自动生成列
            skinDataGridView1.AutoGenerateColumns = false;
            bind();
            //这是格式
            dateTimePicker1.CustomFormat = "HH:mm:ss";//HH大写表示24小时制
            dateTimePicker1.ShowUpDown = true;
             dateTimePicker1.Format= System.Windows.Forms.DateTimePickerFormat.Custom; ;
            comboxImportant.SelectedIndex = 0;
            skinTextBox1.Text = "";
        }
        public void bind()
        {//绑定数据源
            this.skinDataGridView1.DataSource = BLL.richengBLL.selectAllByUid(Local.getCurrentUid());
        }
        private void skinDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //改变显示格式
            if (this.skinDataGridView1.Columns[e.ColumnIndex].Name == "Columnisfinished" && e.Value != null)
            {
                if (e.Value.ToString() == "True")
                {
                    e.Value = "已完成";
                }
                else {
                    e.Value = "待完成";
                }
            }
            if (this.skinDataGridView1.Columns[e.ColumnIndex].Name == "columnLevel" && e.Value != null)
            {
                if (e.Value.ToString() == "1")
                {
                    e.Value = "一般";
                }
                else if (e.Value.ToString() == "2")
                {
                    e.Value = "一般重要";
                }
                else if (e.Value.ToString() == "3")
                {
                    e.Value = "非常重要";
                }
            }
        }

        private void 查看详情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //查看详情
            int rowindex = this.skinDataGridView1.CurrentRow.Index;
            int rid = Convert.ToInt32(this.skinDataGridView1.Rows[rowindex].Cells[0].Value);
            new richengdetailsmallForm(rid,this).ShowDialog();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            //提交日程
            string datetime = this.skinDateTimePicker1.Text+" "+ this.dateTimePicker1.Text;
            int important = this.comboxImportant.SelectedIndex+1;
            string detail = this.skinTextBox1.Text;
            richeng r = new richeng();
            r.Uid = Local.getCurrentUid();
            r.Detail = detail;
            r.Time = datetime;
            r.IsFinished = 0;
            r.ZyLevel = important;
            if (BLL.richengBLL.add(r) == 1)
            {
                MessageBox.Show("提交成功");
                bind();
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //删除日程
            int rowindex = this.skinDataGridView1.CurrentRow.Index;
            int rid = Convert.ToInt32(this.skinDataGridView1.Rows[rowindex].Cells[0].Value);
            if (BLL.richengBLL.deleteByRID(rid) == 1)
            {

                MessageBox.Show("删除成功");
                bind();
            }
        }
    }
}
