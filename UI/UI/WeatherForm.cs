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
    public partial class WeatherForm : Skin_DevExpress
    {
        public WeatherForm()
        {
          string str=  Application.StartupPath;
            InitializeComponent();
            this.cont.Navigate(str+"/weather.html");
        }

        private void cont_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.skinProgressIndicator1.Stop();
            this.skinProgressIndicator1.Visible = false;
        }
    }
}
