using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace UI
{
    public partial class jxForm : Form
    {
        public jxForm()
        {
            InitializeComponent();
            this.skinDataGridView1.AutoGenerateColumns = false;
            //绑定数据源和权限验证
            bind();
            auth();


        }
        public void bind()
        {
            this.skinDataGridView1.DataSource = BLL.JXBLL.selectallBYUID(Local.getCurrentUid());
        }
        public void auth()
        {
            if (Local.authLevel ==1)
            {
                this.btnAdmin.Visible = false;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new jxAdminForm(this).ShowDialog();
        }
    }
}
