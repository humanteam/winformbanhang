using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham.RequestAPI
{
    class APILink
    {
        public static string _Adress = "http://192.168.0.168";
        public static string _Login = "/WebServices/AuthenCation.asmx/authencation";
        public static string _Insert = "/WebServices/AuthenCation.asmx/insert_sanpham";
        public static string _SanPham = "/api/sanpham";
    }
}
