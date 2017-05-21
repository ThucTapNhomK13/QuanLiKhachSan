using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO_Model;
using DAO;
using System.Data;

namespace BUS
{
    public class BUS_DichVu
    {
        Connector connector = null;

        public BUS_DichVu()
        {
            connector = new Connector();
        }

        public DataTable DSDichVu()
        {
            DataTable tbl = new DataTable();
            try
            {
                tbl = connector.getDataTable("DichVu");
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return tbl;
        }

        public DataTable DSDichVuSuDung()
        {
            DataTable tbl = new DataTable();
            try
            {
                tbl = connector.getDataTable("DichVuSuDung");
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return tbl;
        }

        public bool ThemDv(string idpeople , int idservice , int count)
        {
            try
            {
                string str = " '" + idpeople + "' , '" + idservice + "' , '" + count + "'";
                connector.openConnection();
                connector.InsertsData("DichVuSuDung", str);
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }

        public bool SuaDv(string idpeople, int idservice, int count)
        {
            try
            {
                string str = "soluong = '" +  count + "'";
                connector.openConnection();
                connector.ModifyData("DichVuSuDung", str, " (makhachhang = '" + idpeople + "' ) and ( madichvu = '" + idservice + "')");
                connector.closeConnection();
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public bool XoaDv(string serviceId)
        {
            try
            {
                connector.openConnection();
                connector.DeleteData("KhachHang", " makhachhang = '" + serviceId + "'");
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
