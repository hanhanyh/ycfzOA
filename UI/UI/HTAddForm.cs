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
    public partial class HTAddForm : Skin_DevExpress
    {
        private List<int> _uids;
        private HTGLsubForm _f;
        public HTAddForm(HTGLsubForm f)
        {
            InitializeComponent();
            txthtBH.Text = "";
            _uids = new List<int>();
            _f = f;
            ///数据源
            DataTable dt=UserBLL.selectAllUsers().Tables[0];
            //赋值
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.comboxUser.Items.Add(dt.Rows[i][1].ToString());
                _uids.Add(Convert.ToInt32(dt.Rows[i][0]));
            }
            ////
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Htgl ht = new Htgl();
            ht.Detail = txtDetail.Text;//详细
            ht.Htbh = txthtBH.Text;//合同编号
            ht.Time = datetimeEnd.text;//结束时间
            ht.WriteTime = datetimeWrite.text;//签署时间
            ht.StartTime = dateTimeStart.text;//生效时间
            ht.Uid = _uids[this.comboxUser.SelectedIndex];
            if (HTBLL.addHt(ht) == 1)
            {
                MessageBox.Show("添加成功");
                _f.bind();
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
