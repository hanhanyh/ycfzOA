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
    public partial class gongwendetailForm : Skin_DevExpress
    {
        public gongwendetailForm(string data)
        {
            InitializeComponent();
            //设置数据
            this.skinTextBox1.Text = data;
            this.skinTextBox1.Enabled = false;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
