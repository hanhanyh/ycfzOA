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
    /// <summary>
    /// 员工
    /// </summary>
    public class UserBLL
    {
        /// <summary>
        /// 登录操作
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static int login(UserInfo u)
        {
            return DAL.UserServer.Login(u);
        }
        /// <summary>
        /// 添加员工（用户）
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static int reg(UserInfo u)
        {
            return Convert.ToInt32( DAL.UserServer.Register(u));
        }
        /// <summary>
        /// 查询所有员工信息
        /// </summary>
        /// <returns></returns>
        public static DataSet selectAllUsers()
        {
            return DAL.UserServer.staffAll();
        }
        /// <summary>
        /// 通过ID精确查找
        /// </summary>
        /// <param name="UID"></param>
        /// <returns></returns>
        public static DataSet selectOneByUID(UserInfo u)
        {
            return DAL.UserServer.selectOneByUID(u);
        }
        /// <summary>
        /// 模糊查询 通过名称
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataSet SelectStaffByLikeName(string name)
        {
            return DAL.UserServer.SelectStaffByLikeName(name);
        }
        /// <summary>
        /// 真删除
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public static int deleteStaffTrue(UserInfo userinfo)
        {
            return DAL.UserServer.deleteStaffTrue(userinfo);
        }
        /// <summary>
        /// 更新员工信息
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static int updateJobByUid(UserInfo u)
        {
            return DAL.UserServer.updateJobByUid(u);
        }
        //查询自己的资料
        public static DataTable selectMYInfo(int uid)
        {
            return DAL.UserServer.selectMYInfo(uid).Tables[0];
        }
        //更新自己的资料
        public static int updateMYInfo(UserInfo uinfo)
        {
            return Convert.ToInt32( DAL.UserServer.updateMYInfo(uinfo));
        }
        /// <summary>
        /// 查看一个用户的头像
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public static string  selectMyHeader(int uid)
        {
            return DAL.UserServer.selectMyHeader(uid).ToString();
        }
        //更新头像
        public static int updateMyHeader(UserInfo info)
        {
            return Convert.ToInt32(DAL.UserServer.updateMyHeader(info));
        }
        //查询所有用户的通讯录
        public static DataTable selectallComm()
        {
            return DAL.UserServer.selectallComm();
        }
        //模糊查询通讯录
        public static DataTable selectCommLike(string key)
        {
            return DAL.UserServer.selectCommLike(key);
        }
    }
}
