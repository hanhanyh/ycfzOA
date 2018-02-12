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
using System.Data;
namespace UI
{
    public partial class gongwenForm : Form
    {
        public gongwenForm()
        {
            InitializeComponent();
            txtDetail.Text = "";
            this.skinDataGridView1.AutoGenerateColumns = false;//关闭自动生成列
                                                               //  BLL.gongwenBLL.
            bind();
            auth();//权限验证



        }
        public void auth()
        {
            if (Local.authLevel == 1)
            {
                this.btnsh.Visible = false;
            }
        }
        public void bind()
        {
            DataView dv = BLL.gongwenBLL.selectAllGwByuid(Local.getCurrentUid()).DefaultView;
            this.skinDataGridView1.DataSource = dv;
           //DataGridViewColumn column = new DataGridViewColumn();
           
           // this.skinDataGridView1.Columns.Add(column);
           // for (int i = 0; i < dv.Count; i++)
           // {

           //     if (Convert.ToBoolean(dv[i]["isaccept"]) == true)
           //     {
           //         this.skinDataGridView1.Rows[i].Cells[3].Value = "批准";
           //     }
           //     else
           //     {
           //         this.skinDataGridView1.Rows[i].Cells[3].Value = "未批准";
           //     }
           // }
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            gongwen gw = new gongwen();
            gw.Uid = Local.getCurrentUid();
            gw.Season = txtDetail.Text.Trim();
            gw.Datetime = DateTime.Now.ToLocalTime().ToString();
            gw.Isaccept = 0;

            if (BLL.gongwenBLL.Insertgw(gw) == 1)
            {
                MessageBox.Show("提交成功，请等待审核！");
            }
        }
        //类型转换时
        private void skinDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //判断column的Name,然后进行转换
            if (skinDataGridView1.Columns[e.ColumnIndex].Name == "Columnisaccept" && e.Value != null)
            {
                if (Convert.ToBoolean(e.Value)==true)
                {
                    e.Value = "已批准";
                }
                else {
                    e.Value = "未批准";
                }
            }
        }

        private void 查看详情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = this.skinDataGridView1.CurrentRow.Index;
            //查看详情
            int gwid = Convert.ToInt32(this.skinDataGridView1.Rows[row].Cells[0].Value);
            string data = BLL.gongwenBLL.SelectgwContent(gwid);
            new gongwendetailForm(data).ShowDialog();
        }

        private void btnsh_Click(object sender, EventArgs e)
        {
            new gongwenAdminForm().Show();
        }
    }
}
