using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Model;
namespace BLL
{
   public class departmentBLL
    {
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static int department_ADD(department me)
        {
            return Convert.ToInt32(DAL.departmentServer.department_ADD(me));
        }
        /// <summary>
        /// 根据部门id查询部门信息
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public static DataSet selectByDID(department me)
        {
            return DAL.departmentServer.selectByDID(me);
        }
        //查询所有部门
        public static DataTable selectalldeparts()
        {
            return DAL.departmentServer.selectalldeparts().Tables[0];
        }
        //删除一个部门
        public static int delete(int did)
        {
            return Convert.ToInt32(DAL.departmentServer.delete(did));
        }

    }
}
