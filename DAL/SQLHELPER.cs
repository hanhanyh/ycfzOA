using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DAL
{
   public class SQLHELPER
    {
        /********
         * ConfigurationManager 需要添加引用 System.Configuration
         * *********/
        public static string configuration = ConfigurationManager.ConnectionStrings["MYSQL"].ConnectionString;
         /// <summary>
         /// 返回首行首列的值
         /// </summary>
         /// <param name="sqltext">待执行的SQL语句</param>
         /// <returns>返回一个首行首列值object</returns>
        public static object  ExecuteScalar(string sqltext)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(configuration))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sqltext, conn);
                    return comm.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
           
        }
        /// <summary>
        /// 返回受影响行数
        /// </summary>
        /// <param name="sqltext">执行的sql语句</param>
        /// <returns>返回受影响行数，数据类型为object</returns>
        public static object ExecuteNonQuery(String sqltext)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(configuration))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sqltext, conn);
                    return comm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
           
        }
        /// <summary>
        /// 返回DataSet集合
        /// </summary>
        /// <param name="sqltext">待执行的SQL语句</param>
        /// <returns>返回dataset集合</returns>
        public static DataSet ExecuteDataSet(string sqltext)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(configuration))
                {
                    conn.Open();
                    /***************
                     * 
                     * DataSet需要SQLDataAdapter 适配器要去填充
                     * ****************/
                    SqlDataAdapter adapter = new SqlDataAdapter(sqltext, conn);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);
                    return dataset;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new DataSet();
            }
           
        }
    }
}
