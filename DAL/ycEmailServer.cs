using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using System.Data;
namespace DAL
{

    public class ycEmailServer
    {
        public static string sqltext = "";
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static object sendEmai(ycEmail email)
        {
            sqltext = "insert into [dbo].[ycEmail]([Title],[detail],[sendtime],[writer],[receiver],[isRead],[isdelete],[isOwner])values('" + email.Title + "','" + email.Detail + "',getdate(),'" + email.Writer + "','" + email.Receiver + "','0','0','0')";
            SQLHELPER.ExecuteNonQuery(sqltext);
            sqltext = "insert into [dbo].[ycEmail]([Title],[detail],[sendtime],[writer],[receiver],[isRead],[isdelete],[isOwner])values('" + email.Title + "','" + email.Detail + "',getdate(),'" + email.Writer + "','" + email.Receiver + "','0','0','1')";
            return SQLHELPER.ExecuteNonQuery(sqltext);
        }
        /*


























               */
        //查找收到的邮件
        public static DataSet selectAllMyReceivedEmial(int uid)
        {
            sqltext = "	  select [dbo].[ycEmail].EID as EID, [dbo].[ycEmail].[Title] as Title,[dbo].[ycEmail].detail as detail,[dbo].[ycEmail].sendtime as sendtime,[dbo].[UserInfo].name as '发件人' from [dbo].[ycEmail],[dbo].[UserInfo]where [receiver]='" + uid + "' and [dbo].[ycEmail].writer = [dbo].[UserInfo].[uid]  and isOwner='0' and [isdelete]='0'  order by [EID] desc";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
        //查找收到的未读邮件
        public static DataSet selectAllMyRecvUnReadEmail(int uid)
        {
            sqltext = "	select * from [dbo].[ycEmail] where [receiver]='" + uid + "'and isOwner='0'and isRead='0' and [isdelete]='0'  order by [EID] desc";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
        //查看某一邮件的详细信息
        public static DataSet selectOneByEID(int eid)
        {
            sqltext = "	select * from [dbo].[ycEmail] where [EID]='" + eid + "'";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
        //假删除邮件（放入垃圾箱）
        public static object falsedeleteBYEID(int eid)
        {
            sqltext = "update [dbo].[ycEmail] set [isdelete]='1' where [EID]='" + eid + "'";
            return SQLHELPER.ExecuteNonQuery(sqltext);
        }
        //真删除
        public static object trueDeleteBYEID(int eid)
        {
            sqltext = "	delete from [dbo].[ycEmail] where [EID]='" + eid + "'";
            return SQLHELPER.ExecuteNonQuery(sqltext);
        }
        //查找所有发件箱
        public static DataSet selectAllSentEmail(int uid)
        {
            sqltext = "  select [dbo].[ycEmail].EID as EID, [dbo].[ycEmail].[Title] as Title,[dbo].[ycEmail].detail as detail,[dbo].[ycEmail].sendtime as sendtime,[dbo].[UserInfo].name as '收件人' from [dbo].[ycEmail],[dbo].[UserInfo]where writer='" + uid + "' and [dbo].[ycEmail].receiver = [dbo].[UserInfo].[uid]  and isOwner='1' and [isdelete]='0'  order by [EID] desc";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
        //查找我的所有垃圾箱
        public static DataSet selectAllMyfalseDel(int uid)
        {
            sqltext = "  select * from [dbo].[ycEmail] where ([writer]='" + uid + "' or [receiver]='" + uid + "')and [isdelete]='1'  order by EID desc";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
        //移出垃圾箱
        public static object moveout(int eid)
        {
            sqltext = "update [dbo].[ycEmail] set [isdelete]='0' where [EID]='" + eid + "'";
            return SQLHELPER.ExecuteNonQuery(sqltext);
        }
        //设置为已读
        public static object setisRead(int eid)
        {
            sqltext = "  update [dbo].[ycEmail] set isRead='1' where EID='" + eid + "'";
            return SQLHELPER.ExecuteNonQuery(sqltext);
        }
       
    }
}
