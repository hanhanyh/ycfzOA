using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
namespace DAL
{
    /// <summary>
    /// 考勤
    /// </summary>
    public class kqServer
    {
        public static string sqltext = "";
        //签到功能
        public static int signIn(UserInfo uin)
        {
            String datetime = DateTime.Now.ToString();
            //1是签到 0是签退
            sqltext = "insert into SignIn ( uid,time,type) VALUES ('" + uin.Uid + "','" + datetime + "','" + 1 + "'); ";
            return (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
        }
        //签退
        public static int signOut(UserInfo uin)
        {
            String datetime = DateTime.Now.ToString();
            //1是签到 0是签退
            sqltext = "insert into SignIn ( uid,time,type) VALUES ('" + uin.Uid + "','" + datetime + "','" + 0 + "'); ";
            return (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
        }
        //判断用户ID为xx  用户今天是否签到 如果为0表示没有  1表示有
        public static int isSignIned(int uid)
        {
            //根据TOP 1查询上一次签到记录
            //根据datediff 与现在时间比较 判断当天是否签到
            sqltext = "SELECT TOP 1 COUNT(*) FROM SignIn WHERE datediff(day,time,GETDATE())<=0 AND type='1' AND uid='" + uid + "'";
            return (int)DAL.SQLHELPER.ExecuteScalar(sqltext);
        }
        //判断当天是否签退 是就返回1
        public static int isSignOut(int uid)
        {
            //根据TOP 1查询上一次签到记录
            //根据datediff 与现在时间比较 判断当天是否签到
            sqltext = "SELECT TOP 1 COUNT(*) FROM SignIn WHERE datediff(day,time,GETDATE())<=0 AND type='0' AND uid='" + uid + "'";
            return (int)DAL.SQLHELPER.ExecuteScalar(sqltext);
        }
        //-----------------------
        ///查询所有考勤
        public static DataSet SelectAllkq()
        {
            sqltext = "SELECT  u.name as 员工名,u.uid as 用户ID,s.type as 类型,s.time as 时间  FROM UserInfo as u,SignIn as s WHERE u.uid=s.uid ORDER BY s.time desc";
            return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        }
        //签到
        public static object Signln(SignIn si)
        {
            sqltext = "insert into    SignIn(uid,time,type)    values('" + si.Uid + "','" + si.Datetime + "','" + si.Type + "')";
            int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
            return i;
        }
        //迟到次数统计
        public static DataSet signinTimeOut()
        {
            sqltext = " select [dbo].[UserInfo].[uid] as 员工ID,  [dbo].[UserInfo].[name] as 员工名称, count(*) as 迟到次数 from [dbo].[SignIn],[dbo].[UserInfo] where ([dbo].[UserInfo].uid = [dbo].[SignIn].uid) and( (DATEPART(hour,time)=8 and DATEPART(MINUTE,time)>50) or (DATEPART(hour,time)>=9)  )and type=1   and DATEPART(MONTH,time)=DATEPART(month,getdate())  group by  [dbo].[UserInfo].[uid] ,  [dbo].[UserInfo].[name]";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
        //出勤排行
        public static DataSet countcq()
        {
            sqltext = " select [dbo].[UserInfo].[uid] as 员工ID,count(*) 出勤次数,[dbo].[UserInfo].name as 员工姓名 from [dbo].[SignIn],[dbo].[UserInfo] where [dbo].[SignIn].uid=[dbo].[UserInfo].uid and [SignIn].type=1 group by  [dbo].[UserInfo].[uid],[dbo].[UserInfo].name order by count(*) desc";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
    }
}
