using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using DAL;
namespace BLL
{
    public class KQBLL
    {
        //签到功能
        public static int signIn(UserInfo uin)
        {
            return DAL.kqServer.signIn(uin);
        }
        //签退
        public static int signOut(UserInfo uin)
        {
            return DAL.kqServer.signOut(uin);
        }
        //判断用户ID为xx  用户今天是否签到 如果为0表示没有  1表示有
        public static int isSignIned(int uid)
        {
            //根据TOP 1查询上一次签到记录
            //根据datediff 与现在时间比较 判断当天是否签到
            return DAL.kqServer.isSignIned(uid);
        }
        //判断当天是否签退 是就返回1
        public static int isSignOut(int uid)
        {
            //根据TOP 1查询上一次签到记录
            //根据datediff 与现在时间比较 判断当天是否签到
            return DAL.kqServer.isSignOut(uid);
        }
        //-----------------------
        ///查询所有考勤
        public static DataSet SelectAllkq()
        {
            return DAL.kqServer.SelectAllkq();
        }
        //签到
        public static object Signln(SignIn si)
        {
            return DAL.kqServer.Signln(si);
        }
        //迟到次数统计
        public static DataTable signinTimeOut()
        {
            return DAL.kqServer.signinTimeOut().Tables[0];
        }
        //出勤排行
        public static DataTable countcq()
        {
            return DAL.kqServer.countcq().Tables[0];
        }
    }
}
