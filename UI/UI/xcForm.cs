using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class xcForm : Form
    {
        private int _dx;
        private int _tc;
        public xcForm()
        {
            InitializeComponent();
            //查询设置数据
            DataTable dt = BLL.XCBLL.selectone(Local.getCurrentUid());
            labdx.Text= dt.Rows[0]["底薪"].ToString();
            _dx = Convert.ToInt32(dt.Rows[0]["底薪"].ToString());
           labtc.Text= dt.Rows[0]["提成"].ToString();
            _tc= Convert.ToInt32(Convert.ToDouble(dt.Rows[0]["提成"].ToString().Trim()));
            labzgz.Text= dt.Rows[0]["总工资"].ToString();
           labname.Text  =dt.Rows[0]["员工名称"].ToString();
            ///auth
            if (Local.authLevel == 1) btnview.Visible = false;
            ///初始化饼状图
            bindPie();
            //设置头像
            string headurl = BLL.UserBLL.selectMyHeader(Local.getCurrentUid());
            if (headurl == null || headurl == "")
            {
               pictureBox1.Load("img/touxiang.png");
            }
            else
            {
                pictureBox1.Load(headurl);
            }
        }
        public void bindPie()
        {
            List<string> xData = new List<string>() { "底薪", "提成" };
            List<int> yData = new List<int>() { _dx, _tc };
            
            chart1.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            chart1.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            chart1.Series[0].Points.DataBindXY(xData, yData);
           
        }
        private void btnview_Click(object sender, EventArgs e)
        {
            new allxcForm().ShowDialog();
        }
    }
}
