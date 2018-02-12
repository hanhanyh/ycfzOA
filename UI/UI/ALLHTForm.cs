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
namespace UI
{
    public partial class ALLHTForm : Skin_DevExpress
    {
        public ALLHTForm()
        {
            InitializeComponent();
            //设置数据源
            this.skinDataGridView1.DataSource = BLL.HTBLL.SelectAllHt().Tables[0];
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {//关闭
            this.Close();
        }
    }
}
