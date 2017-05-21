using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
using DAO;
using DTO_Model;
using System.Data;
=======
using System.Data;
using System.Data.SqlClient;

using DAO;
>>>>>>> origin/master

namespace BUS
{
    public class BUS_Phong
    {
        Connector connector = null;
<<<<<<< HEAD
=======

>>>>>>> origin/master
        public BUS_Phong()
        {
            connector = new Connector();
        }
<<<<<<< HEAD
=======

>>>>>>> origin/master
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

<<<<<<< HEAD
        public bool NhanTraPhong(string state, string idpeople , string codeId)
        {
            try
            {
                string query = "tinhtrang = '" + state + "', makhachhang = '" +idpeople +"'";
=======
        public bool NhanTraPhong(string state, string idpeople, string codeId)
        {
            try
            {
                string query = "tinhtrang = '" + state + "', makhachhang = '" + idpeople + "'";
>>>>>>> origin/master

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
<<<<<<< HEAD
=======

>>>>>>> origin/master
    }
}
