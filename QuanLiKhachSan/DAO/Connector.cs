using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class Connector
    {
        public string strConn = @"Data Source=MRKCUONG\MKCUONG;Initial Catalog=QuanLiKhachSan;Integrated Security=True";
        private SqlCommand cmd;
        private SqlConnection conn;
        private DataTable tbl;
        private SqlDataAdapter com;

        public Connector()
        {
            conn = new SqlConnection(strConn);

        }

        public void openConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void closeConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable getDataTable(string table)
        {
            try
            {
                string sql = "select * from " + table;
                com = new SqlDataAdapter(sql, strConn);
                tbl = new DataTable();
                com.Fill(tbl);
            }
            catch (Exception)
            {
                throw;
            }
            return tbl;
        }

        public void InsertsData(string table, string query)
        {
            try
            {
                string sql = " insert into " + table + " values ( " + query + " ) ";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteData(string table, string codeId)
        {
            try
            {
                string sql = " delete from " + table + " where " + codeId;
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ModifyData(string table, string query, string codeId)
        {
            try
            {
                string sql = "update " + table + " set " + query + " where " + codeId;
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable dangnhap(string column)
        {
            try
            {
                openConnection();
                string sql = " select " + column + " from DangNhap ";
                tbl = new DataTable();
                //cmd = new SqlCommand(sql);
                com = new SqlDataAdapter(sql, strConn);
                com.Fill(tbl);
            }
            catch (Exception)
            {
                throw;
            }
            return tbl;
        }


    }
}
