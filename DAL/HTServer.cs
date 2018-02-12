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
    /// 合同管理
    /// </summary>
    public   class HTServer
    {
        public static string sqltext="";
        //根据用户uid编号 查询合同
        public static DataSet searchAllHt(int uid)
        {
            sqltext = "  SELECT  u.name as 员工姓名,h.detail as 合同编号,h.hid as 合同ID,h.endTime as 失效时间,h.[startTime] as 生效时间,h.[writeTime] as 签署时间 from UserInfo as u,Htgl as h WHere h.uid=u.uid AND u.uid= '" + uid + "'";
            return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        }
        //增加合同
        public static int addHt(Htgl h)
        {
            sqltext = "  insert into Htgl(htbh,uid,startTime,endTime,Detail,writeTime)values('"+h.Htbh+"','"+h.Uid+"','"+h.StartTime+"','"+h.Time+"','"+h.Detail+"','"+h.WriteTime+"')";
            return (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
        }
        //查询所有合同
        public static DataSet SelectAllHt()
        {
            sqltext = "SELECT   UserInfo.name as 员工名字,htbh as 合同编号,Htgl.detail as 合同详情,Htgl.writeTime as 签署时间,Htgl.startTime as 生效时间,Htgl.endTime as 失效时间 FROM Htgl,UserInfo where Htgl.uid=UserInfo.uid";
            return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        }
        /// <summary>
        /// 通过合同编号删除合同
        /// </summary>
        /// <param name="htbh"></param>
        /// <returns></returns>
        public static object deleteHTbyhtbh(string  htbh)
        {
            sqltext = "  DELETE from Htgl where htbh='" + htbh + "'";
            return SQLHELPER.ExecuteNonQuery(sqltext);
        }
        /// <summary>
        /// 查询合同详情
        /// </summary>
        /// <param name="hid"></param>
        /// <returns></returns>
        public static string detail(int hid)
        {
            sqltext = "select [Detail] from  [dbo].[Htgl] where [hid]='"+hid+"'";
            return SQLHELPER.ExecuteScalar(sqltext).ToString();
        }

    }
}
