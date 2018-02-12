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
   public class JXBLL
    {
        //绩效管理添加
        public static int Add(Jxgl jxgl)
        {
            return Convert.ToInt32(DAL.jxServer.Add(jxgl));
           
        }
        //查询所有
        public static DataTable selectall()
        {
            return DAL.jxServer.selectall().Tables[0];
        }
        //查询某人的所有绩效
        public static DataTable selectallBYUID(int uid)
        {
            return DAL.jxServer.selectallBYUID(uid).Tables[0];
        }
    }
}
