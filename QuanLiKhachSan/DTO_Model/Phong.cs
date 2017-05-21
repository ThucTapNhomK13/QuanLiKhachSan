using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Model
{
    public class Phong
    {
        public string maphong { get; set; }
        public string tinhtrang { get; set; }
        public int giaphong { get; set; }
        public int loaiphong { get; set; }      
        public string makhachhang { get; set; }
        public Phong(string maphong, string tinhtrang,  int giaphong , int loaiphong, string makhachhang)
        {
            this.maphong = maphong;
            this.tinhtrang = tinhtrang;
            this.loaiphong = loaiphong;
            this.giaphong = giaphong;      
            this.makhachhang = makhachhang;
        }

    }
}
