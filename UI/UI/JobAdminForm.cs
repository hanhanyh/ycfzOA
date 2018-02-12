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
    public partial class JobAdminForm : Skin_DevExpress
    {
        private List<int> _listdid;
        public JobAdminForm()
        {
            InitializeComponent();
            _listdid = new List<int>();
           //绑定combobox
            DataTable dtDids = BLL.departmentBLL.selectalldeparts();
            for (int i = 0; i < dtDids.Rows.Count; i++)
            {
                this.skinComboBox1.Items.Add(dtDids.Rows[i]["name"].ToString());
                _listdid.Add(Convert.ToInt32(dtDids.Rows[i]["did"]));
            }
            this.skinComboBox1.SelectedIndex = 0;
            bind();

        }
        void bind()
        {
            /////
            departjob de = new departjob();
            de.Did = _listdid[this.skinComboBox1.SelectedIndex];
            this.skinDataGridView1.DataSource = BLL.JobBLL.selectallbyDID(de).Tables[0];
        }

        private void skinComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string name = this.txtJob.Text;
            int did = _listdid[this.skinComboBox1.SelectedIndex];
            departjob job = new departjob();
            job.Jobname = name;
            job.Did = did;
            job.Dx = Convert.ToInt32(txtDx.Text);
            BLL.JobBLL.jobadd(job);
            bind();

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.skinDataGridView1.CurrentRow.Index;
           int jid=  Convert.ToInt32( this.skinDataGridView1.Rows[index].Cells[0].Value);
            if (MessageBox.Show("确定删除？", "确定删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BLL.JobBLL.delete(jid);
                bind();
            }
        }
    }
}
