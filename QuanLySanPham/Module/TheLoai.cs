using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham.Module
{
    class TheLoai
    {
        private string maTheLoai, tenTheLoai;
        public TheLoai(string maTheLoai,string tenTheLoai)
        {
            this.maTheLoai = maTheLoai;
            this.tenTheLoai = tenTheLoai;
        }
        public string getMaTheLoai()
        {
            return this.maTheLoai;
        }
        public void setMaTheLoai(string maTheLoai)
        {
            this.maTheLoai = maTheLoai;
        }
        public string getTenTheLoai()
        {
            return this.tenTheLoai;
        }
        public void setTenTheLoai(string tenTheLoai)
        {
            this.tenTheLoai = tenTheLoai;
        }
    }
}
