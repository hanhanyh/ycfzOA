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
    public partial class addUserForm : Skin_DevExpress
    {
        private List<int> _listJobs;
        public UserMansubForm _f;
        public addUserForm(UserMansubForm f)
        {
            InitializeComponent();
            //职位id列表
            _listJobs = new List<int>();
            _f = f;
            txtAddress.Text = "";
            txtIDCARD.Text = "";
            txtName.Text = "";
            txtPwd.Text = "";
            txtQQ.Text = "";
            txtphone.Text = "";
            ////查询所有职业
            DataTable dtJobs = JobBLL.SelectAllJob().Tables[0];
            for (int i = 0; i < dtJobs.Rows.Count; i++)
            {
                this.comboxJob.Items.Add(dtJobs.Rows[i][2].ToString());
                _listJobs.Add(Convert.ToInt32(dtJobs.Rows[i][0]));
            }
            this.comboxJob.SelectedIndex = 0;
            //
            this.comboxISadmin.SelectedIndex = 0;
            comboxsex.SelectedIndex = 0;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //添加按钮点击
            UserInfo u = new UserInfo();
            u.Name = txtName.Text;
            u.Sex = comboxsex.SelectedIndex;
            u.Jobid = _listJobs[comboxJob.SelectedIndex];
            u.Password = txtPwd.Text;
            u.IsManager = comboxISadmin.SelectedIndex;
            u.Qq = txtQQ.Text;
            u.Address = txtAddress.Text;
            u.IdCard = txtIDCARD.Text;
            u.Phone = txtphone.Text;
            u.Birthday = skinDateTimePicker1.Text;
        
                if (UserBLL.reg(u) == 1)
                {
                    MessageBox.Show("添加成功");
                    _f.bind();//刷新
                    this.Close();
                }
            
            
        }
    }
}
