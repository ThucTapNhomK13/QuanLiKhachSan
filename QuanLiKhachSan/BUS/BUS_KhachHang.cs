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
    public class BUS_KhachHang
    {
        Connector connector = null;

        public BUS_KhachHang()
        {
            connector = new Connector();
        }

        public DataTable DSKhachHang()
        {
            DataTable tbl = new DataTable();
            try
            {
                tbl = connector.getDataTable("KhachHang");
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return tbl;
        }

        public bool ThemkH(List<string> kh)
        {
            try
            {
                string str = " N'" + kh[0].ToString() + "' , N'" + kh[1].ToString() + "' , '" + kh[2].ToString() +
                    "' , '" + kh[3].ToString() + "' , '" + kh[4].ToString() + "' , '" + kh[5].ToString() + "' , '" + kh[6].ToString()
<<<<<<< HEAD
                    +  "' , '" + kh[7].ToString() + "' ";
=======
                    + "' , '" + kh[7].ToString() + "' ";
>>>>>>> origin/master
                //string str = "N'Nguyễn Tuấn Anh' , N'Nam' , '01216416268' , '032562563' , '202' , '5/13/2017' , '6/2/2017','1000000'";
                connector.openConnection();
                connector.InsertsData("KhachHang", str);
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }

        public bool SuaKh(List<string> kh, string codeId)
        {
            try
            {
                string str = "hoten = N'" + kh[0].ToString() + "' , gioitinh = N'" + kh[1].ToString() + "' , sdt = '" + kh[2].ToString() +
<<<<<<< HEAD
                    "' , socmnd = '" + kh[3].ToString() + "' , maphong = '" + kh[4].ToString()  + "' , ngaydangki = '" + kh[5].ToString()
=======
                    "' , socmnd = '" + kh[3].ToString() + "' , maphong = '" + kh[4].ToString() + "' , ngaydangki = '" + kh[5].ToString()
>>>>>>> origin/master
                    + "' ,  ngaytra = '" + kh[6].ToString() + "' , tratruoc = '" + kh[7].ToString() + "'";
                connector.openConnection();
                connector.ModifyData("KhachHang", str, " makhachhang = '" + codeId + "'");
                connector.closeConnection();
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public bool XoaKh(string codeId)
        {
            try
            {
                connector.openConnection();
                connector.DeleteData("KhachHang", " makhachhang = '" + codeId + "'");
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
