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
    public partial class clientRecvForm : Skin_DevExpress
    {
        public clientRecvForm(string data)
        {
            InitializeComponent();
            this.txtDetail.Text = data;
            this.txtDetail.Enabled = false;
            this.StartPosition = FormStartPosition.Manual; //起始位置为Local决定
          // this.Location = new Point(screenheight + this.Height, screenwidth - this.Height);
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }
    }
}
