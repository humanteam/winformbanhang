using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanPham.FormControllers
{
    public partial class Xoasanpham : Form
    {
        public Xoasanpham()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bodyrequest = "ma=" + edt_MaSP.Text;
            DialogResult result;
            if (edt_MaSP.Text.Length <= 0)
            {
                result = MessageBox.Show("Mã sản phẩm không bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool result_request = RequestAPI.RequestApiControllers._check_request(bodyrequest, RequestAPI.APILink._Adress + RequestAPI.APILink._DeleteSP);
            if (result_request == false)
            {
                //Insert that bai
                DialogResult dalogresult = MessageBox.Show("Xóa sản phẩm thất bại", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else
            {
                //Thong bao them tai khoan thanh cong
                DialogResult dialogresult = MessageBox.Show("Xóa sản phẩm thành công", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }
    }
}
