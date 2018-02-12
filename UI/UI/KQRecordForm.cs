using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;
using System.Data;
namespace UI
{
    public partial class KQRecordForm : Form
    {
        public KQRecordForm()
        {
            InitializeComponent();
            this.skinDataGridView1.AutoGenerateColumns = false;
            DataTable dt=BLL.KQBLL.SelectAllkq().Tables[0];
            this.skinDataGridView1.DataSource = dt;
            //绑定迟到统计图
            bindcd();
            //绑定出勤统计
            bindcq();

        }
        void bindcq()
        {
            DataTable dtCd = BLL.KQBLL.countcq();
            List<string> datax0 = new List<string>();
            List<int> datay0 = new List<int>();
            for (int i = 0; i < dtCd.Rows.Count; i++)
            {
                datax0.Add(dtCd.Rows[i]["员工姓名"].ToString());
                datay0.Add(Convert.ToInt32(dtCd.Rows[i]["出勤次数"]));
            }
            chartcql.Titles.Add("本月出勤次数统计");
            chartcql.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            chartcql.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
                                                         //柱状图其他设置
            chartcql.Series[0]["DrawingStyle"] = "Emboss";   //设置柱状平面形状
            chartcql.Series[0]["PointWidth"] = "0.5"; //设置柱状大小
                                                      //折线段配置
            chartcql.Series[0].Color = Color.Blue;               //线条颜色
            chartcql.Series[0].BorderWidth = 2;                 //线条粗细
            chartcql.Series[0].MarkerBorderColor = Color.Black;   //标记点边框颜色
            chartcql.Series[0].MarkerBorderWidth = 3;             //标记点边框大小
            chartcql.Series[0].MarkerColor = Color.Blue;       //标记点中心颜色
            chartcql.Series[0].MarkerSize = 5;                 //标记点大小
            //chart1.Series[0].MarkerStyle = MarkerStyle.Circle;  //标记点类型
            chartcql.Series[0].Points.DataBindXY(datax0, datay0); //添加数据
        }
        void bindcd()
        {
            DataTable dtCd = BLL.KQBLL.signinTimeOut();
            List<string> datax0 = new List<string>();
            List<int> datay0 = new List<int>();
            for (int i = 0; i < dtCd.Rows.Count; i++)
            {
                datax0.Add(dtCd.Rows[i]["员工名称"].ToString());
                datay0.Add(Convert.ToInt32(dtCd.Rows[i]["迟到次数"]));
            }
            chartCD.Titles.Add("本月迟到次数统计");
            chartCD.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            chartCD.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
                                                        //柱状图其他设置
            chartCD.Series[0]["DrawingStyle"] = "Emboss";   //设置柱状平面形状
            chartCD.Series[0]["PointWidth"] = "0.5"; //设置柱状大小
                                                     //折线段配置
            chartCD.Series[0].Color = Color.Red;               //线条颜色
            chartCD.Series[0].BorderWidth = 3;                 //线条粗细
            chartCD.Series[0].MarkerBorderColor = Color.Black;   //标记点边框颜色
            chartCD.Series[0].MarkerBorderWidth = 3;             //标记点边框大小
            chartCD.Series[0].MarkerColor = Color.Red;       //标记点中心颜色
            chartCD.Series[0].MarkerSize = 5;                 //标记点大小
            //chart1.Series[0].MarkerStyle = MarkerStyle.Circle;  //标记点类型
            chartCD.Series[0].Points.DataBindXY(datax0, datay0); //添加数据
        }
        private void skinDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.skinDataGridView1.Columns[e.ColumnIndex].Name == "columnType"&&e.Value!=null)
            {
                if (Convert.ToString(e.Value) == "True")
                {
                    e.Value = "签到";
                }
                else if (Convert.ToString(e.Value) == "False")
                {
                    e.Value = "签退";
                }
            }
        }
    }
}
