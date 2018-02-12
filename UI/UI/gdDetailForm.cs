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
    public partial class gdDetailForm : Skin_DevExpress
    {
        public gdDetailForm(int gid)
        {
            InitializeComponent();
            //设置Enable
            this.skinTextBox1.Enabled = false;
            this.skinTextBox1.Text = BLL.gonggaoBLL.selectDetail(gid);
        }
    }
}
