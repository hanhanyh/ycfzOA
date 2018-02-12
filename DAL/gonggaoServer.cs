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
    /// 公告
    /// </summary>
   public  class gonggaoServer
    {
        public static string sqltext = "";
        //添加
        public static object add(Gonggao gonggao)
        {
            sqltext = "insert into Gongggao(uid,title,detail,time)values('" + gonggao.Uid + "','" + gonggao.Title + "','" + gonggao.Detail + "','" + gonggao.Datetime + "')";
            int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
            return i;
        }
        //查询一个
        public static DataSet selectLastOne()
        {
            sqltext = "  select top 1 * from [dbo].[Gongggao] order by [gid] desc";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
        //查询一个
        public static string selectDetail(int gid)
        {
            sqltext = "  select [detail] from [dbo].[Gongggao] where gid='" + gid + "'";
            return SQLHELPER.ExecuteScalar(sqltext).ToString() ;
        }
        //删除
        public static object delete(int gid)
        {
            sqltext = "  delete from [dbo].[Gongggao] where gid='" + gid + "'";
            return SQLHELPER.ExecuteNonQuery(sqltext);
        } //查询所有
        public static DataSet all()
        {

            sqltext = "  select * from [dbo].[Gongggao] order by gid desc";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
    }
}
