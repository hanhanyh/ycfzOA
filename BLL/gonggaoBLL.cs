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
   public  class gonggaoBLL
    {
        /// <summary>
        /// 增加公告
        /// </summary>
        /// <param name="gg"></param>
        /// <returns></returns>
        public static int add(Gonggao gg)
        {
            return Convert.ToInt32( DAL.gonggaoServer.add(gg));
        }
        //public static int add(Gonggao gonggao)
        //{
        //    return Convert.ToInt32(DAL.gonggaoServer.add(gonggao));
        //}
        //查询一个
        public static DataTable selectLastOne()
        {
            return DAL.gonggaoServer.selectLastOne().Tables[0];
        }
        //查询
        public static string selectDetail(int gid)
        {
            return DAL.gonggaoServer.selectDetail(gid);
        }
        //删除
        public static int delete(int gid)
        {
            return Convert.ToInt32(DAL.gonggaoServer.delete(gid));
        }
        //查询所有
        public static DataTable all()
        {
            return DAL.gonggaoServer.all().Tables[0];
        }
    }
}
