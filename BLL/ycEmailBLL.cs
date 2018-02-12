using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using DAL;
namespace BLL
{
    public class ycEmailBLL
    {
        //发邮件

        public static int sendEmai(ycEmail email)
        {
            return Convert.ToInt32(DAL.ycEmailServer.sendEmai(email));
        }
        //查找收到的邮件
        public static DataTable selectAllMyReceivedEmial(int uid)
        {
            return DAL.ycEmailServer.selectAllMyReceivedEmial(uid).Tables[0];
        }
        //查找收到的未读邮件
        public static DataTable selectAllMyRecvUnReadEmail(int uid)

        {
            return DAL.ycEmailServer.selectAllMyRecvUnReadEmail(uid).Tables[0];
        }
        //查看某一邮件的详细信息
        public static DataTable selectOneByEID(int eid)
        {
            return DAL.ycEmailServer.selectOneByEID(eid).Tables[0];
        }
        //假删除邮件（放入垃圾箱）
        public static int falsedeleteBYEID(int eid)
        {
            return Convert.ToInt32(DAL.ycEmailServer.falsedeleteBYEID(eid));
        }
        //真删除
        public static int trueDeleteBYEID(int eid)
        {
            return Convert.ToInt32(DAL.ycEmailServer.trueDeleteBYEID(eid));
        }
        //查找所有发件箱
        public static  DataTable selectAllSentEmail(int uid)
        {
            return DAL.ycEmailServer.selectAllSentEmail(uid).Tables[0];
        }
        //查询我的所有垃圾箱
        public static DataTable selectAllMyfalseDel(int uid)
        {
            return DAL.ycEmailServer.selectAllMyfalseDel(uid).Tables[0];
        }
        //移出垃圾箱
        public static int moveout(int eid)
        {
            return Convert.ToInt32(DAL.ycEmailServer.moveout(eid));
        }
        //设置为已读
        public static int setisRead(int eid)
        {
            return Convert.ToInt32(DAL.ycEmailServer.setisRead(eid));
        }
    }
}
