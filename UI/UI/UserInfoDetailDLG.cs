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
    public partial class UserInfoDetailDLG : Skin_DevExpress
    {
        private int _uid;
        private List<int> _listjobid;//绑定职位id
        private UserMansubForm _f;
        public UserInfoDetailDLG(int uid,UserMansubForm f)
        {
            InitializeComponent();
            _f = f;
            _listjobid = new List<int>();
            this._uid = uid;
            binddata();



        }
        void binddata()
        {
            //绑定数据
            UserInfo uinfo = new UserInfo();
            uinfo.Uid = this._uid;
            DataTable dt = BLL.UserBLL.selectOneByUID(uinfo).Tables[0];
            this.labuid.Text = _uid.ToString();
            this.labname.Text = dt.Rows[0][2].ToString();
            //  this.labsex.Text = dt.Rows[0][3].ToString();
            this.labbirth.Text = dt.Rows[0][4].ToString();
            this.labqq.Text = dt.Rows[0][5].ToString();
            this.labphone.Text = dt.Rows[0][6].ToString();
            department de = new department();
            de.Did = Convert.ToInt32(dt.Rows[0][7].ToString());
            this.labdid.Text = departmentBLL.selectByDID(de).Tables[0].Rows[0][1].ToString();
            //  this.labjob.Text = dt.Rows[0][8].ToString();
            this.labaddress.Text = dt.Rows[0][9].ToString();
            //  this.labEnable.Text = dt.Rows[0][10].ToString();

            ////初始化控件
            this.Text = "员工信息管理-" + this.labname.Text;
            this.comboxsex.SelectedIndex = Convert.ToInt32(dt.Rows[0][3]);//男1 女0
            this.comboxEnable.SelectedIndex = Convert.ToInt32(dt.Rows[0][10]);
            ///部门下所有职位
            departjob depart = new departjob();
            depart.Did = Convert.ToInt32(dt.Rows[0][7]);
            DataTable dtAllJobs = JobBLL.selectall().Tables[0];//所有职位（修改职位 的方式可以直接修改所在部门）
            this.comboxjobs.Items.Clear();
            for (int i = 0; i < dtAllJobs.Rows.Count; i++)
            {
                this.comboxjobs.Items.Add(dtAllJobs.Rows[i][2]);
                //保存职位id
                _listjobid.Add(Convert.ToInt32(dtAllJobs.Rows[i][0]));
                if (Convert.ToInt32(dtAllJobs.Rows[i][0]) == Convert.ToInt32(dt.Rows[0][1]))
                {
                    this.comboxjobs.SelectedIndex = i;
                }
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            //资料更新
            UserInfo u = new UserInfo();
            u.Uid = _uid;
            u.Name = this.labname.Text;
            u.Sex = this.comboxsex.SelectedIndex;
            u.Birthday = this.labbirth.Text;
            u.Qq = this.labqq.Text;
            u.Phone = this.labphone.Text;
            u.Address = this.labaddress.Text;
            u.Enable = this.comboxEnable.SelectedIndex;
            u.Jobid = _listjobid[this.comboxjobs.SelectedIndex];
            if (UserBLL.updateJobByUid(u) == 1)
            {
                MessageBox.Show("修改成功");
                _f.bind();
                this.Close();
            }

        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
