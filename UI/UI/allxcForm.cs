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
    public partial class allxcForm : Skin_DevExpress
    {
        public allxcForm()
        {
            InitializeComponent();
            this.skinDataGridView1.AutoGenerateColumns = true;
            this.skinDataGridView1.DataSource = BLL.XCBLL.selectall();
            ///查询
           DataTable dt= BLL.XCBLL.selectall();
            //添加数据到集合
            List<string> datax = new List<string>();
            List<int> datay = new List<int>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                datax.Add(dt.Rows[i]["员工名称"].ToString());
                datay.Add(Convert.ToInt32(dt.Rows[i]["总工资"]));
            }
            //设置统计图
            chart1.Titles.Add("工资统计");
            chart1.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            chart1.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
                                                       //柱状图其他设置
            chart1.Series[0]["DrawingStyle"] = "Emboss";   //设置柱状平面形状
            chart1.Series[0]["PointWidth"] = "0.5"; //设置柱状大小
                                                    //折线段配置
            chart1.Series[0].Color = Color.Red;               //线条颜色
            chart1.Series[0].BorderWidth = 3;                 //线条粗细
            chart1.Series[0].MarkerBorderColor = Color.Red;   //标记点边框颜色
            chart1.Series[0].MarkerBorderWidth = 3;             //标记点边框大小
            chart1.Series[0].MarkerColor = Color.Red;       //标记点中心颜色
            chart1.Series[0].MarkerSize = 5;                 //标记点大小
            //chart1.Series[0].MarkerStyle = MarkerStyle.Circle;  //标记点类型
            chart1.Series[0].Points.DataBindXY(datax, datay); //添加数据
        /***********************************
         * 上面是总工资统计
          * 下面是提成统计
          * 
          * 
          * 
          * 
          * 
           * ************************************/
            List<string> datax0 = new List<string>();
            List<int> datay0 = new List<int>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                datax0.Add(dt.Rows[i]["员工名称"].ToString());
                datay0.Add(Convert.ToInt32(dt.Rows[i]["提成"]));
            }
            chart2.Titles.Add("提成统计图");
            chart2.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            chart2.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
                                                       //柱状图其他设置
            chart2.Series[0]["DrawingStyle"] = "Emboss";   //设置柱状平面形状
            chart2.Series[0]["PointWidth"] = "0.5"; //设置柱状大小
                                                    //折线段配置
            chart2.Series[0].Color = Color.Blue;               //线条颜色
            chart2.Series[0].BorderWidth = 3;                 //线条粗细
            chart2.Series[0].MarkerBorderColor = Color.Red;   //标记点边框颜色
            chart2.Series[0].MarkerBorderWidth = 3;             //标记点边框大小
            chart2.Series[0].MarkerColor = Color.Red;       //标记点中心颜色
            chart2.Series[0].MarkerSize = 5;                 //标记点大小
            //chart1.Series[0].MarkerStyle = MarkerStyle.Circle;  //标记点类型
            chart2.Series[0].Points.DataBindXY(datax0, datay0); //添加数据
        }
    }
}
