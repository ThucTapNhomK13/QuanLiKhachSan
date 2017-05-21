using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using DAO;

namespace BUS
{
    public class BUS_Phong
    {
        Connector connector = null;

        public BUS_Phong()
        {
            connector = new Connector();
        }

        public DataTable DSPhong()
        {
            DataTable tbl = new DataTable();
            try
            {
                tbl = connector.getDataTable("Phong");
                connector.closeConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tbl;
        }

        public DataTable LoaiPhong()
        {
            DataTable tbl = new DataTable();
            try
            {
                tbl = connector.getDataTable("LoaiPhong");
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return tbl;
        }

        public bool NhanTraPhong(string state, string idpeople, string codeId)
        {
            try
            {
                string query = "tinhtrang = '" + state + "', makhachhang = '" + idpeople + "'";

                connector.openConnection();
                connector.ModifyData("Phong", query, "maphong = '" + codeId + "'");
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }

    }
}
