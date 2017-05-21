using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Model
{
    public class DangNhap
    {
        public string tendangnhap { get; set; }
        public string matkhau { get; set; }
        public DangNhap(string tendangnhap, string matkhau)
        {
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
        }
    }
}
