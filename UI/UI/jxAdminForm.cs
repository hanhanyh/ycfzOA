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
    public partial class jxAdminForm : Skin_DevExpress
    {
        private List<int> _idlist;
        private jxForm _f;
        public jxAdminForm(jxForm f)
        {
            InitializeComponent();
            _f = f;
            _idlist = new List<int>();
            txtjx.Text = "";
            txtsm.Text = "";
            //查询所有用户
            DataTable dtusers = BLL.UserBLL.selectAllUsers().Tables[0];
            for (int i = 0; i < dtusers.Rows.Count; i++)
            {
                _idlist.Add(Convert.ToInt32(dtusers.Rows[i]["员工编号"].ToString()));
                this.skinComboBox1.Items.Add(dtusers.Rows[i]["员工名字"].ToString());
            }
            //设置默认选择
            this.skinComboBox1.SelectedIndex = 0;
            /// 设置数据源
            this.skinDataGridView1.DataSource = BLL.JXBLL.selectall();

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            //添加
            Jxgl jx = new Jxgl();
            jx.Uid = this._idlist[this.skinComboBox1.SelectedIndex];
            jx.Detail = this.txtsm.Text;
            jx.Yj =Convert.ToInt32( this.txtjx.Text.ToString());
            if (BLL.JXBLL.Add(jx) == 1)
            {
                MessageBox.Show("添加成功");
                _f.bind();
                this.Close();
            }
        }
    }
}
