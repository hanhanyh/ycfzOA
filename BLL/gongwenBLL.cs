using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL;
using Model;
namespace BLL
{
    public class gongwenBLL
    {
        /// <summary>
        /// 添加公文
        /// </summary>
        /// <param name="gw"></param>
        /// <returns></returns>
        public static int Insertgw(gongwen gw)
        {
            return Convert.ToInt32(DAL.gongwenServer.Insertgw(gw));
        }
        //已审批公文
        public static DataSet Selectgwnotaccept()
        {
            return DAL.gongwenServer.Selectgwnotaccept();
        }
        //更新公文
        public static int Updategongwen(int qid, int isaccept, String hk)
        {
            return DAL.gongwenServer.Updategongwen(qid, isaccept, hk);
        }
        //反馈
        public static DataSet Selectfeedback()
        {
            return DAL.gongwenServer.Selectfeedback();
        }
        //根据公文ID查询公文内容
        public static string SelectgwContent(int id)
        {
            return DAL.gongwenServer.SelectgwContent(id);
        }
        //根据uid查询 所有公文
        public static DataTable selectAllGwByuid(int UID)
        {
            return DAL.gongwenServer.selectAllGwByuid(UID).Tables[0];
        }
        /********
         * ********************************************************************************
         * **************************************************
         * **********************8
         * ****************8
         * *****************************************8
         * ********************************
         * *************/
        //查询所有公文（所有部门）
        public static DataTable SelectallDepart()
        {
            return  DAL.gongwenServer.SelectallDepart().Tables[0];
        }
        //查询所有已审核公文(所有部门)
        public static DataTable selectallaccepted()
        {
            return DAL.gongwenServer.selectallaccepted().Tables[0];
        }
        //查询所有未审核公文(所有部门)
        public static DataTable selectAllunaccept()
        {
            return DAL.gongwenServer.selectAllunaccept().Tables[0];
        }
        //查询某一部门下的所有未审核的记录
        public static DataTable selectAllunSHBydid(int did)
        {
            return DAL.gongwenServer.selectAllunSHBydid(did).Tables[0];
        }
        //查询某一部门下所有已审核的记录
        public static DataTable selectAllacceptedBydid(int did)
        {
            return DAL.gongwenServer.selectAllacceptedBydid(did).Tables[0];
        }

    }
}
