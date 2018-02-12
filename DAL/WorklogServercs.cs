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
    /// 工作日志
    /// </summary>
     public class WorklogServercs
    {
        public static string sqltext = "";
        //查询所有工作日志 （简约）
        public static DataSet SelectAllWorklog()
        {
            sqltext = "SELECT w.logid as 工作日志ID, u.name as 员工名字,w.time as 时间 from  UserInfo as u,worklog as w WHERE u.uid=w.uid";
            return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        }
        //添加工作日志
        public static int addWorklog(worklog log)
        {
            sqltext = "INSERT INTO worklog(uid,detail,time)VALUES('" + log.Uid + "','" + log.Detail + "','" + log.Datetime + "')";
            return Convert.ToInt32(DAL.SQLHELPER.ExecuteNonQuery(sqltext));
        }
        //查询工作日志详情
        public static string selectworklogDetail(int id)
        {
            sqltext = "SELECT detail FROM worklog where logid='" + id + "'";
            return Convert.ToString(DAL.SQLHELPER.ExecuteScalar(sqltext));
        }
        /// <summary>
        /// 精确查找工作日志 BYWID
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        public static DataSet selectWorkLogByWid(worklog log)
        {
            sqltext = "select  logid as 日志编号,uid as 员工编号,detail as 详细信息 ,time as 时间 from  worklog where  uid='" + log.Uid + "';";
            DataSet work = DAL.SQLHELPER.ExecuteDataSet(sqltext);
            return work;

        }
        /// <summary>
        /// 工作日志添加
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        public static object workLogAdd(worklog log)
        {
            sqltext = "insert  into worklog( uid , detail , time )  values('" + log.Uid + "','" + log.Detail + "','" + log.Datetime + "')";
            int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
            return i;
        }
        //删除工作日志
        public static object deleteWorklog(int logid)
        {
            sqltext = "  delete from [worklog] where logid='"+logid+"'";
            return SQLHELPER.ExecuteNonQuery(sqltext);
        }
    }
}
