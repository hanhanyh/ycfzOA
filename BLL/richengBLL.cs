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
    public class richengBLL
    {
        //添加
        public static int add(richeng r)
        {
            return Convert.ToInt32(DAL.richengServer.add(r));
        }
        //查询未完成日程
        public static DataTable selectUnFinishedBYUID(int uid)
        {
            return DAL.richengServer.selectUnFinishedBYUID(uid).Tables[0];
        }
        //查询所有日程
        public static DataTable selectAllByUid(int uid)
        {
            return DAL.richengServer.selectAllByUid(uid).Tables[0];
        }
        //设置为完成
        public static int setFinished(int rid)
        {
            return Convert.ToInt32(DAL.richengServer.setFinished(rid));
        }
        //删除日程
        public static int deleteByRID(int rid)
        {
            return Convert.ToInt32(DAL.richengServer.deleteByRID(rid));
        }
        //查询日程详情
        public static string selectDetailByRID(int rid)
        {
            return DAL.richengServer.selectDetailByRID(rid).ToString();
        }
    }
}
