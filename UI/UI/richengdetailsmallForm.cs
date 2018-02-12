using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;
using BLL;
using CCWin;
namespace UI
{
    public partial class richengdetailsmallForm :Skin_DevExpress
    {
        private int _rid;
        private AllrichengForm _form;
        public richengdetailsmallForm(int rid, AllrichengForm form)
        {
            InitializeComponent();
            _rid = rid;
            _form = form;
            //绑定数据
            this.skinTextBox1.Text= BLL.richengBLL.selectDetailByRID(rid);
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            BLL.richengBLL.setFinished(_rid);
            _form.bind();
            this.Close();
        }
    }
}
