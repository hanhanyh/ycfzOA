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
namespace UI
{
    public partial class gwdetailForm : Skin_DevExpress
    {
        private int _qid;
        private gongwenAdminForm _f;
        public gwdetailForm(int qid, gongwenAdminForm f)
        {
            InitializeComponent();
            _f = f;
            _qid = qid;
            //设置
            skinTextBox1.Text= BLL.gongwenBLL.SelectgwContent(_qid);
            skinTextBox1.Enabled = false;
            skinComboBox1.SelectedIndex = 0; ;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            //更新
            BLL.gongwenBLL.Updategongwen(_qid, 1, this.textBox1.Text);
            _f.bind();
            this.Close();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
