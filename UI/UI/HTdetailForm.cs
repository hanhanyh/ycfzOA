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
    public partial class HTdetailForm : Skin_DevExpress
    {
        public HTdetailForm(int hid)
        {
            InitializeComponent();
            this.textBox1.Text = BLL.HTBLL.detail(hid);
            this.textBox1.Enabled = false;
        }
    }
}
