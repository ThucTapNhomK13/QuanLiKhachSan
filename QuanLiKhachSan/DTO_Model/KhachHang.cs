using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Model
{
    public class KhachHang
    {
        public string makhachhang { get; set; }
        public string hoten { get; set; }
        public string gioitinh { get; set; }    
        public string sdt { get; set; }
        public string cmnd { get; set; }
        public string maphong { get; set; }
        public DateTime ngaydangki { get; set; }
        public DateTime ngaytra { get; set; }
        public int tratruoc { get; set; }
        public KhachHang(string makhachhang, string hoten, string gioitinh , string sdt, string cmnd, string maphong , DateTime ngaydangki, DateTime ngaytra , int tratruoc)
        {
            this.makhachhang = makhachhang;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.cmnd = cmnd;
            this.sdt = sdt;
            this.maphong = maphong;
            this.ngaydangki = ngaydangki;
            this.ngaytra = ngaytra;
            this.tratruoc = tratruoc;
        }
    }
}
