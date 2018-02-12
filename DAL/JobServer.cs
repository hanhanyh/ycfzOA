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
    /// 职位
    /// </summary>
   public class JobServer
    {
        public static string sqltext = "";
        //根据jobid 修改底薪
        public static int UpdateDxById(Model.UserInfo uinfo, int dx)
        {
            sqltext = "UPDATE departjob SET dx='" + dx + "' WHERE jobid='" + uinfo.Uid + "'";
            return Convert.ToInt32(DAL.SQLHELPER.ExecuteNonQuery(sqltext));
        }
        //查询员工 员工编号 职务 底薪 返回DataSet
        public static DataSet SelectAStaffJobDxById(Model.UserInfo uinfo)
        {
            sqltext = "SELECT UserInfo.name as 员工,UserInfo.uid as 员工编号,departjob.jobname as 职务,departjob.dx as 底薪 FROM UserInfo ,departjob  where UserInfo.jobid=departjob.jobid AND UserInfo.uid='" + uinfo.Uid + "'";
            return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        }
        //查询所有职务表
        public static DataSet SelectAllJob()
        {
            sqltext = "select * from departjob";
            return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        }
        //底薪修改 
        public static int UpdateDx(int jobbid, int dx)
        {
            sqltext = "update departjob SET dx='" + dx + "' WHERE jobid='" + jobbid + "'";
            return Convert.ToInt32(DAL.SQLHELPER.ExecuteNonQuery(sqltext));
        }
        //查询员工 员工编号 职务 底薪 返回DataSet
        public static DataSet SelectAllStaffJobDx()
        {
            sqltext = "SELECT UserInfo.name as 员工,UserInfo.uid as 员工编号,departjob.jobname as 职务,departjob.dx as 底薪 FROM UserInfo ,departjob  where UserInfo.jobid=departjob.jobid";
            return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        }
        //通过用户ID查询职位
        public static String SelectJobByUid(UserInfo uinfo)
        {
            sqltext = "SELECT [jobname] FROM departjob,UserInfo WHERE UserInfo.jobid=departjob.jobid  AND UserInfo.uid='" + uinfo.Uid + "'";
            return Convert.ToString(DAL.SQLHELPER.ExecuteScalar(sqltext));
        }
        //修改员工部门+职务
        public static int UpdateStaffDepartmentJob(UserInfo userinfo)
        {
            sqltext = "update UserInfo set  jobid='" + userinfo.Jobid + "'  ";
            int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
            return i;
        }
        //职位表添加
        public static object jobadd(departjob de)
        {
            sqltext = "insert into departjob(did,jobname,dx)values ('" + de.Did + "','" + de.Jobname + "','" + de.Dx + "')";
            int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
            return i;
        }
        /// <summary>
        /// 职位删除
        /// </summary>
        /// <param name="uf"></param>
        /// <returns></returns>
        public static object delete(int jid)
        {
            sqltext = "delete from [dbo].[departjob] where [jobid]='" + jid + "'";
            return SQLHELPER.ExecuteNonQuery(sqltext);
        }
        //职位表假删除
        public static int jobdeletefalse(UserInfo uf)
        {
            sqltext = "update   UserInfo  set  enable='0' where uid='" + uf.Uid + "'";
            int i = (int)SQLHELPER.ExecuteNonQuery(sqltext);
            return i;

        }
        //职位表的查询(通过部门ID)
        public static DataSet selectallbyDID(departjob de)
        {
            sqltext = "select  jobid as 职务编号,jobname as 职务,dx as 底薪 from departjob where did ='" + de.Did + "'";
            DataSet jb = DAL.SQLHELPER.ExecuteDataSet(sqltext);
            return jb;
        }
        //职位表的所有信息
        public static DataSet selectall()
        {
            sqltext = "select *from departjob";
            return SQLHELPER.ExecuteDataSet(sqltext);


        }
    }
}
