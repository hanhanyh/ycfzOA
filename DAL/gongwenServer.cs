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
    /// 公文
    /// </summary>
   public  class gongwenServer
    {
        public static string sqltext = "";
        //增加公文
        public static int Insertgw(gongwen gw)
        {
            sqltext = "insert into gongwen (uid,season,time,isaccept,hk) values('" + gw.Uid + "','" + gw.Season + "','" + gw.Datetime + "','" + gw.Isaccept + "','" + gw.Hk + "')";
            return Convert.ToInt32(DAL.SQLHELPER.ExecuteNonQuery(sqltext));
        }
        //已审批公文
        public static DataSet Selectgwnotaccept()
        {
            sqltext = "select UserInfo.name as 员工,gongwen.qid as 公文编号, UserInfo.uid as 员工编号,gongwen.season as 公文,gongwen .time as 申请时间 from UserInfo, gongwen WHERE UserInfo.uid=gongwen.uid AND gongwen.isaccept='0' AND DATALENGTH(gongwen.hk)=0";
            return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        }
        //更新公文（审核）
        public static int Updategongwen(int qid, int isaccept, String hk)
        {
            sqltext = "UPDATE gongwen SET isaccept='" + isaccept + "',hk='" + hk + "' WHERE qid='" + qid + "'";
            return (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);

        }
        //反馈
        public static DataSet Selectfeedback()
        {
            sqltext = "SELECT qid as 公文ID ,isaccept as 是否通过,hk as 反馈 FROM gongwen  where uid='1' AND DATALENGTH(hk)!=0 ";
            return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        }
        //根据公文ID查询公文内容
        public static string SelectgwContent(int id)
        {
            sqltext = "select gongwen.[season] FROM gongwen WHERE qid='" + id + "'";
            return (string)DAL.SQLHELPER.ExecuteScalar(sqltext);
        }
        //根据uid查询 所有公文
        public static DataSet selectAllGwByuid(int UID)
        {
            sqltext = "select * from [gongwen] where uid='" + UID + "'";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
        /****************************************************************************8
         * ********************************************************************
         * ******************************************2018年1月5日19:03:40
         * ************************2018年1月5日19:03:2
         * *************
         * 2018-1-5 19:03:04
         * 2018年1月5日19:03:06
         * 2018年1月5日19:03:08
         * 邱于涵
         * **
         * **
         * */
        //查询所有公文（所有部门）
        public static DataSet SelectallDepart()
        {
            sqltext = "select [dbo].[gongwen].[qid] as 公文ID,[dbo].[gongwen].[season] as 详情,[dbo].[gongwen].[time] as 时间,[isaccept] as 是否同意 from [dbo].[gongwen] ,[dbo].[UserInfo] where [dbo].[UserInfo].uid=[dbo].[gongwen].uid  order by qid desc";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
        //查询所有已审核公文(所有部门)
        public static DataSet selectallaccepted()
        {
            sqltext = "select [dbo].[gongwen].[qid] as 公文ID,[dbo].[gongwen].[season] as 详情,[dbo].[gongwen].[time] as 时间,[isaccept] as 是否同意 from [dbo].[gongwen] ,[dbo].[UserInfo] where [dbo].[UserInfo].uid=[dbo].[gongwen].uid and  [dbo].[gongwen].isaccept='1' order by qid desc";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
        //查询所有未审核公文(所有部门)
        public static DataSet selectAllunaccept()
        {
            sqltext = "select [dbo].[gongwen].[qid] as 公文ID,[dbo].[gongwen].[season] as 详情,[dbo].[gongwen].[time] as 时间,[isaccept] as 是否同意 from [dbo].[gongwen] ,[dbo].[UserInfo] where [dbo].[UserInfo].uid=[dbo].[gongwen].uid and  [dbo].[gongwen].isaccept='0' order by qid desc";
            return
                SQLHELPER.ExecuteDataSet(sqltext);
        }
        //查询某一部门下的所有未审核的记录
        public static DataSet selectAllunSHBydid(int did)
        {
            sqltext = "select [dbo].[gongwen].[qid] as 公文ID,[dbo].[gongwen].[season] as 详情,[dbo].[gongwen].[time] as 时间,[isaccept] as 是否同意 from [dbo].[gongwen] ,[dbo].[UserInfo], [dbo].[department],[dbo].[departjob] where [dbo].[UserInfo].uid=[dbo].[gongwen].uid  and [dbo].[UserInfo].jobid= [dbo].[departjob].jobid and [dbo].[departjob].did = [dbo].[department].did and [dbo].[department].did='"+did+"' and  [dbo].[gongwen].isaccept='0' order by qid desc";
            return
                SQLHELPER.ExecuteDataSet(sqltext);
        }
        //查询某一部门下所有已审核的记录
        public static DataSet selectAllacceptedBydid(int did)
        {
            sqltext = "select [dbo].[gongwen].[qid] as 公文ID,[dbo].[gongwen].[season] as 详情,[dbo].[gongwen].[time] as 时间,[isaccept] as 是否同意 from [dbo].[gongwen] ,[dbo].[UserInfo], [dbo].[department],[dbo].[departjob] where [dbo].[UserInfo].uid=[dbo].[gongwen].uid  and [dbo].[UserInfo].jobid= [dbo].[departjob].jobid and [dbo].[departjob].did = [dbo].[department].did and [dbo].[department].did='" + did + "' and  [dbo].[gongwen].isaccept='1' order by qid desc";
            return
                SQLHELPER.ExecuteDataSet(sqltext);
        }

    }
}
