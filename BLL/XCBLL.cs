using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
     public  class XCBLL
    {
        //查询所有
        public static DataTable selectall()
        {
            return DAL.xcServer.selectall().Tables[0];
        }
        //查询一个
        public static DataTable selectone(int uid)
        {
            return DAL.xcServer.selectone(uid).Tables[0]; 
        }
       
    }
}
