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
    public partial class worklogDetailForm : Skin_DevExpress
    {
        private int _logid;
        public worklogDetailForm(int logid)
        {
            InitializeComponent();
            _logid = logid;
            //绑定数据
            skinTextBox1.Text = WorkLogBll.selectworklogDetail(_logid);
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
