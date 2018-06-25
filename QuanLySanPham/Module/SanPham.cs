using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham.Module
{
    class SanPham
    {
       public string MaSP { get; set; }
       public string TenSP { get; set; }
        public string AnhSP { get; set; }
        public string GiaSP { get; set; }
        public string ChiTietSP { get; set; }
        public string MaTheLoai { get; set; }
        public string MaUserName { get; set; }
        public Account Account { get; set; }
        public TheLoai TheLoai { get; set; }
    }
}
