using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DAO
{
    public class DBHaipu
    {
        public static DataTable Select(string sql, string fileName, params SqlParameter[] ps)
        {
            SqlConnection cn = GetConnection();

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

                WRZ(fileName, ex);
            }
            return dt;
        }

        private static SqlConnection GetConnection()
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=112;Integrated Security=True");
            return cn;
        }

        public static int InsertUpdateDelte(string sql, string fileName, params SqlParameter[] ps)
        {
            SqlConnection cn = GetConnection();

            SqlCommand cmd = new SqlCommand(sql, cn);
            if (ps != null)
            {
                cmd.Parameters.AddRange(ps);
            }
            int result = 0;
            try
            {
                cn.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                WRZ(fileName, ex);
            }
            finally
            {
                cn.Close();
            }
            return result;
        }

        public static object SelectSinger(string sql, string fileName, params SqlParameter[] ps)
        {
            SqlConnection cn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, cn);
            if (ps != null)
            {
                cmd.Parameters.AddRange(ps);
            }
            object obj = null;
            try
            {
                cn.Open();
                obj = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                WRZ(fileName, ex);

            }
            finally
            {
                cn.Close();
            }

            return obj;
        }

        public static SqlDataReader SelectReader(string sql, string fileName, params SqlParameter[] ps)
        {
            SqlConnection cn = GetConnection();

            SqlCommand cmd = new SqlCommand(sql, cn);
            if (ps != null)
            {
                cmd.Parameters.AddRange(ps);
            }
            SqlDataReader reader = null;
            try
            {
                cn.Open();
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                WRZ(fileName, ex);

            }
            return reader;
        }

        private static void WRZ(string fileName, Exception ex)
        {
            //LogHelper.WriteLog(typeof(DBHaipu), ex.Message);

        }


        public static DataTable SelectProc(string sql,SqlParameter[] ps, string fileName)
        {
            SqlConnection cn = GetConnection();
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

                WRZ("",ex);
            }
            return dt;
        }
    }
}