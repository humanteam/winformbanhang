using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham.RequestAPI
{
    class APILink
    {
        public static string _Adress = "http://192.168.0.102";
        public static string _Login = "/WebServices/AuthenCation.asmx/authencation";
        public static string _Insert = "/WebServices/AuthenCation.asmx/insert_sanpham";
        public static string _Insert_User = "/WebServices/AuthenCation.asmx/insert_user";
        public static string _SanPham = "/api/sanpham";
        public static string _editSanPham = "/WebServices/AuthenCation.asmx/edit_sanpham";
    }
}
