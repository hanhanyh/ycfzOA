using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
namespace BLL
{
    public class HTBLL
    {
        //根据用户uid编号 查询合同
        public static DataSet searchAllHt(int uid)
        {
            return DAL.HTServer.searchAllHt(uid);
        }
        //增加合同
        public static int addHt(Htgl h)
        {
            return DAL.HTServer.addHt(h);
        }
        //查询所有合同
        public static DataSet SelectAllHt()
        {
            return DAL.HTServer.SelectAllHt();
        }
        /// <summary>
        /// 通过合同编号删除合同
        /// </summary>
        /// <param name="htbh"></param>
        /// <returns></returns>
        public static int deleteHTbyhtbh(string htbh)
        {
            return Convert.ToInt32(DAL.HTServer.deleteHTbyhtbh(htbh));
        }
        //查询合同详情
        public static string detail(int hid)
        {
            return DAL.HTServer.detail(hid);

        }
    }
}
