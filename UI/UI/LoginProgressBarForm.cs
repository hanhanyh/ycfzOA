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
    public partial class LoginProgressBarForm :Form 
    {
        public LoginProgressBarForm()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
            this.Opacity = 0.5;
        }
    }
}
