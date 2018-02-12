using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;
namespace BLL
{
    public class WorkLogBll
    {
        //查询所有工作日志 （简约）
        public static DataSet SelectAllWorklog()
        {
            return DAL.WorklogServercs.SelectAllWorklog();
        }
        //添加工作日志
        public static int addWorklog(worklog log)
        {
            return DAL.WorklogServercs.addWorklog(log);
        }
        //查询工作日志详情
        public static string selectworklogDetail(int id)
        {
            return DAL.WorklogServercs.selectworklogDetail(id);
        }
        /// <summary>
        /// 精确查找工作日志 BYWID
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        public static DataSet selectWorkLogByWid(worklog log)
        {
            return DAL.WorklogServercs.selectWorkLogByWid(log);

        }
        /// <summary>
        /// 工作日志添加
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        public static object workLogAdd(worklog log)
        {
            return DAL.WorklogServercs.workLogAdd(log);
        }
        //删除工作日志
        public static int deleteWorklog(int logid)
        {
            return Convert.ToInt32(DAL.WorklogServercs.deleteWorklog(logid));
        }
       
    }
}
