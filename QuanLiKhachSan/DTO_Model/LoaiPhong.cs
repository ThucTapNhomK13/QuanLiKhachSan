using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Model
{
    public class LoaiPhong
    {
        public int maloaiphong { get; set; }
        public string tenloaiphpng { get; set; }
        public string trangbi { get; set; }
        public int soluong { get; set; }
        public string tinhtrang { get; set; }
        public LoaiPhong(int maloaiphong, string tenloaiphong, string trangbi , int soluong , string tinhtrang)
        {
            this.maloaiphong = maloaiphong;
            this.tenloaiphpng = tenloaiphong;
            this.trangbi = trangbi;
            this.soluong = soluong;
            this.tinhtrang = tinhtrang;
        }
    }
}