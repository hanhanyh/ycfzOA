using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
namespace DAL
{
    public class richengServer
    {
        public static string  sqltext="";
        /// <summary>
        /// 添加日程
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static object add(richeng r)
        {
            sqltext = "  insert into [dbo].[richeng](uid,detail,zyLevel,time,isFinished)values('" + r.Uid + "','" + r.Detail + "','" + r.ZyLevel +"','"+r.Time+"','0')";
            return SQLHELPER.ExecuteNonQuery(sqltext);
        }
        //查询我的未完成日程
        public static DataSet selectUnFinishedBYUID(int uid)
        {
            sqltext = "  select * from [dbo].[richeng] where ([isFinished]='0' or [isFinished] is null)  and  [uid]='" + uid + "' order by [time] asc";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
        //查询我的所有日程
        public static DataSet selectAllByUid(int uid)
        {
            sqltext = "  select * from [dbo].[richeng] where  [uid]='"+uid+"' order by [time] asc";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
        //标记日程为已完成
        public static object setFinished(int rid)
        {
            sqltext = "  update [dbo].[richeng] set [isFinished]='1' where rid='" + rid + "'";
            return SQLHELPER.ExecuteNonQuery(sqltext);
        }
        //删除日程
        public static object deleteByRID(int rid)
        {
            sqltext = " delete from [dbo].[richeng] where [rid]='" + rid + "'";
            return SQLHELPER.ExecuteNonQuery(sqltext);
        }
        //查询日程详情
        public static object selectDetailByRID(int rid)
        {
            sqltext = "select [detail] from [dbo].[richeng] where [rid]='" + rid + "'";
            return SQLHELPER.ExecuteScalar(sqltext);
        }
    }
}
