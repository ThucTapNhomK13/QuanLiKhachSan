using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
using DAO;
using DTO_Model;
using System.Data;
using System.Data.SqlClient;

=======
>>>>>>> origin/master
namespace BUS
{
    public class BUS_NhanVien
    {
<<<<<<< HEAD
        Connector connector = null;

        public BUS_NhanVien()
        {
            connector = new Connector();
        }
        public DataTable DSNhanVien()
        {
            DataTable tbl = new DataTable();
            try
            {
                tbl = connector.getDataTable("NhanVien");
                connector.closeConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tbl;
        }

        public bool ThemNv(List<string> nv)
        {
            try
            {
                string str = " '" + nv[0].ToString() + "' , N'" + nv[1].ToString() + "', '" + nv[2].ToString() +
                    "', N'" + nv[3].ToString() + "', '" + nv[4].ToString() + "', N'" + nv[5].ToString() +
                    "', '" + nv[6].ToString() + "' ";
                connector.openConnection();
                connector.InsertsData("NhanVien", str);
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }

        public bool XoaNv(string codeId)
        {
            try
            {
                connector.openConnection();
                connector.DeleteData("NhanVien", "manhanvien = '" + codeId + "'");
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }

        public bool SuaNv(List<string> nv, string codeId)
        {
            try
            {
                string query = "tennhanvien = N'" + nv[1].ToString() + "' , machucvu = '" + nv[2].ToString() + "' , gioitinh = N'" + nv[3].ToString() +
                    "' , ngaysinh = '" + nv[4].ToString() + "' , diachi = N'" + nv[5].ToString() + "' , sdt = '" + nv[6].ToString() + "'";
                connector.openConnection();
                connector.ModifyData("NhanVien", query, "manhanvien = '" + codeId + "'");
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }
=======
>>>>>>> origin/master
    }
}
