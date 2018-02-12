using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
namespace DAL
{
    /// <summary>
    /// 绩效
    /// </summary>
  public  class jxServer
    {
        public static string sqltext = "";
        ////查询员工，员工编号，业绩，提成百分比
        //public static DataSet Selectjxcx()
        //{
        //    sqltext = "select  a.name as 员工,a.uid as 员工编号,b.yj as 业绩,b.percentage as 提成百分比     from  UserInfo as a    inner    join Jxgl as b     on a.uid=b.uid";
        //    return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //}
        ////通过员工ID查询绩效表内容
        //public static DataSet Selectjxdc(UserInfo userinfo)
        //{
        //    sqltext = "select  a.name as 员工,a.uid as 员工编号,b.yj as 业绩,b.percentage as 提成百分比     from  UserInfo as a    inner    join Jxgl as b     on a.uid=b.uid AND a.uid='" + userinfo.Uid + "'";
        //    return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //}
       
        ////查询用户id 底薪 业绩 提成百分比
        //public static DataSet SelectOneStaffJobDx(UserInfo uin)
        //{
        //    sqltext = "SELECT UserInfo.uid as 用户ID, departjob.dx as 底薪,jxgl.yj as 业绩 ,jxgl.percentage as 提成百分比 FROM departjob,jxgl,UserInfo   WHERE jxgl.uid=UserInfo.uid AND UserInfo.jobid=departjob.jobid And UserInfo.uid='" + uin.Uid + "'";
        //    return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //}
        ////绩效管理查询
        //public static DataSet Jxgl_select(Jxgl jxgl)
        //{
        //    sqltext = "select jid as 员工职务 ,uid as 员工编号, yj as 业绩,detail as 说明 ,time as 时间  from  Jxgl where uid ='" + jxgl.Uid + "'and time='" + jxgl.Datetime + "'";
        //    DataSet jx = DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //    return jx;
        //}
        //绩效管理添加
        public static object Add(Jxgl jxgl)
        {
            sqltext = "insert  into Jxgl( uid,yj,detail,time)values( '" + jxgl.Uid + "','" + jxgl.Yj + "','" + jxgl.Detail + "','" + jxgl.Datetime + "');";
            int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
            return i;
        }
        //查询所有
        public static DataSet selectall()
        {
            sqltext = "  select * from [dbo].[Jxgl] order by jid desc";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
        //查询某人的所有绩效
        public static DataSet selectallBYUID(int uid)
        {
            sqltext = "  select * from [dbo].[Jxgl] where uid ='" + uid + "' order by jid desc";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }

    }
}
