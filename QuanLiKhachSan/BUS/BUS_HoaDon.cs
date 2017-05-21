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
    public class BUS_HoaDon
    {
        Connector connector = null;

        public BUS_HoaDon()
        {
            connector = new Connector();
        }

        public DataTable DSHoaDon()
        {
            DataTable tbl = new DataTable();
            try
            {
                tbl = connector.getDataTable("HoaDon");
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return tbl;
        }

        public bool ThemHd(List<string> hd)
        {
            try
            {
                string str = " '" + hd[0].ToString() + "' , '" + hd[1].ToString() + "' , '" + hd[2].ToString() +
                    "' , '" + hd[3].ToString() + "' , N'" + hd[4].ToString() + "' , '" + hd[5].ToString() + "'";
                //string str = "'5/25/2017' , '2000000' , '300000' , '1421' , N'Đã thanh toán' , '6'";
                connector.openConnection();
                connector.InsertsData("HoaDon", str);
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }


        public bool XoaHd(string codeId)
        {
            try
            {
                connector.openConnection();
                connector.DeleteData("HoaDon", " mahoadon = '" + codeId + "'");
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
