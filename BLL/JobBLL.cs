using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Model;
namespace BLL
{
    public  class JobBLL
    {
        //根据jobid 修改底薪
        public static int UpdateDxById(Model.UserInfo uinfo, int dx)
        {
            return DAL.JobServer.UpdateDxById(uinfo, dx);
        }
        //查询员工 员工编号 职务 底薪 返回DataSet
        public static DataSet SelectAStaffJobDxById(Model.UserInfo uinfo)
        {
            return DAL.JobServer.SelectAStaffJobDxById(uinfo);
        }
        //查询所有职务表
        public static DataSet SelectAllJob()
        {
            return DAL.JobServer.SelectAllJob();
        }
        //底薪修改 
        public static int UpdateDx(int jobbid, int dx)
        {
            return DAL.JobServer.UpdateDx(jobbid, dx);
        }
        //查询员工 员工编号 职务 底薪 返回DataSet
        public static DataSet SelectAllStaffJobDx()
        {
            return DAL.JobServer.SelectAllStaffJobDx();
        }
        //通过用户ID查询职位
        public static String SelectJobByUid(UserInfo uinfo)
        {
            return DAL.JobServer.SelectJobByUid(uinfo);
        }
        //修改员工部门+职务
        public static int UpdateStaffDepartmentJob(UserInfo userinfo)
        {
            return DAL.JobServer.UpdateStaffDepartmentJob(userinfo);
        }
        //职位表添加
        public static object jobadd(departjob de)
        {
            return DAL.JobServer.jobadd(de);
        }
        //职位表假删除
        public static int jobdeletefalse(UserInfo uf)
        {
            return DAL.JobServer.jobdeletefalse(uf);

        }
        //职位表的查询(通过部门ID)
        public static DataSet selectallbyDID(departjob de)
        {
            return DAL.JobServer.selectallbyDID(de);
        }
        //职位表的所有信息
        public static DataSet selectall()
        {
            return DAL.JobServer.selectall();
        }
        /// <summary>
        /// 职位删除
        /// </summary>
        /// <param name="uf"></param>
        /// <returns></returns>
        public static int delete(int jid)
        {
            return  Convert.ToInt32( DAL.JobServer.delete(jid));
        }
    }
}
