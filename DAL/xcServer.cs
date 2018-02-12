using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace DAL
{
    //薪酬管理
   public  class xcServer
    {
        public static string  sqltext="";
        //查询所有（当月的工资情况）
        public static DataSet selectall()
        {
            sqltext = "select [dbo].[departjob].dx as 底薪, sum(0.05*[yj]) as 提成,[dbo].[departjob].dx+sum(0.05*[yj]) as 总工资,[dbo].[UserInfo].name as 员工名称 from [dbo].[departjob],[dbo].[UserInfo],[dbo].[Jxgl] where [dbo].[UserInfo].jobid=[dbo].[departjob].jobid and [dbo].[Jxgl].uid=[dbo].[UserInfo].uid and  month([Jxgl].time)=MONTH(GETDATE()) group   by [dbo].[UserInfo].name,[dbo].[departjob].dx";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
        //查询某一个人当月的工资
        public static DataSet selectone(int uid)
        {
            sqltext = "select [dbo].[departjob].dx as 底薪, sum(0.05*[yj]) as 提成,[dbo].[departjob].dx+sum(0.05*[yj]) as 总工资,[dbo].[UserInfo].name as 员工名称 from [dbo].[departjob],[dbo].[UserInfo],[dbo].[Jxgl] where [dbo].[UserInfo].jobid=[dbo].[departjob].jobid and [dbo].[Jxgl].uid=[dbo].[UserInfo].uid and  month([Jxgl].time)=MONTH(GETDATE()) and [dbo].[UserInfo].uid='" + uid + "' group   by [dbo].[UserInfo].name,[dbo].[departjob].dx";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
    }
}
