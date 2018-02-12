using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
namespace DAL
{
    public   class departmentServer
    {
        public static string sqltext = "";
        //部门表添加
        public static object department_ADD(department me)
        {
            sqltext = "insert into department (name)values('" + me.Name + "')";
            int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
            return i;
        }
        //部门表假删除
        //部门表查询
        public static DataSet selectByDID(department me)
        {
            sqltext = "select did as 部门编号,name as 部门 from  department where did='" + me.Did + "'";
            DataSet met = DAL.SQLHELPER.ExecuteDataSet(sqltext);
            return met;
        }
        //查询所有部门
        public static DataSet selectalldeparts()
        {
            sqltext = "select  * from [dbo].[department] order by did desc";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
        //删除一个部门
        public static object delete(int did)
        {
            sqltext = "delete from [dbo].[department] where did='" + did + "'";
            return SQLHELPER.ExecuteNonQuery(sqltext);
        }

    }
}
