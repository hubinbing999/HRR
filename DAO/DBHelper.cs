using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class DBHelper
    {
        public static int InsertDeleteUpdate(string sql, params SqlParameter[] ps)
        {
            int result = 0;
            SqlConnection cn = CreateConnection();
            //把用户名和密码添加到数据库中

            SqlCommand cmd = new SqlCommand(sql, cn);
            if (ps != null)
            {
                cmd.Parameters.AddRange(ps);
            }
            try
            {
                cn.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                WriteLog(ex);

            }
            finally
            {
                cn.Close();
            }
            return result;
        }

        private static SqlConnection CreateConnection()
        {
            string conStr = @"Data Source=DESKTOP-5R3I0RP;Initial Catalog=HR_DB;Persist Security Info=True;User ID=sa;Password=123";
            SqlConnection cn = new SqlConnection(conStr);
            return cn;
        }

        private static void WriteLog(Exception ex)
        {
            //using (StreamWriter sw = new StreamWriter("错误日志.txt", true))
            //{
            //    sw.WriteLine("错误的时间:" + DateTime.Now);
            //    sw.WriteLine("错误的信息:" + ex.Message);
            //}
            //LogHelper.WriteLog(typeof(DBHelper), ex.Message);
        }

        public static object SelectSinger(string sql, params SqlParameter[] ps)
        {
            object obj = null;
            SqlConnection cn = CreateConnection();
            //根据用户名和密码来判断是否可以登录

            SqlCommand cmd = new SqlCommand(sql, cn);
            if (ps != null)
            {
                cmd.Parameters.AddRange(ps);
            }
            try
            {
                cn.Open();
                obj = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                WriteLog(ex);

            }
            finally
            {
                cn.Close();
            }
            return obj;
        }

        public static SqlDataReader SelectReader(string sql, params SqlParameter[] ps)
        {
            SqlDataReader reader = null;
            SqlConnection cn = CreateConnection();
            //读取学生表的信息 

            SqlCommand cmd = new SqlCommand(sql, cn);
            if (ps != null)
            {
                cmd.Parameters.AddRange(ps);
            }
            try
            {
                cn.Open();
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {

                WriteLog(ex);
            }
            return reader;
        }

        public static DataTable SelectTable(string sql, params SqlParameter[] ps)
        {
            SqlConnection cn = CreateConnection();
            //读取学生表的信息
            SqlDataAdapter ad = new SqlDataAdapter(sql, cn);
            if (ps != null)
            {
                ad.SelectCommand.Parameters.AddRange(ps);
            }
            DataTable dt = new DataTable();
            try
            {
                ad.Fill(dt);
            }
            catch (Exception ex)
            {

                WriteLog(ex);
            }
            return dt;
        }


        public static DataTable SelectFenYe(string sql, params SqlParameter[] ps)
        {
            SqlConnection cn = CreateConnection();
            //读取学生表的信息
            SqlDataAdapter ad = new SqlDataAdapter(sql, cn);
            if (ps != null)
            {
                //把参数对象放入命令对象中
                ad.SelectCommand.Parameters.AddRange(ps);
            }
            //执行的是存储过程
            ad.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
                ad.Fill(dt);
            }
            catch (Exception ex)
            {

                WriteLog(ex);
            }
            return dt;
        }
    }
}
