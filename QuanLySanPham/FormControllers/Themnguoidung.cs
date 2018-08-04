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
    public partial class Themnguoidung : Form
    {
        public Themnguoidung()
        {
            InitializeComponent();
        }

        private void edt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // string postData = "username=" + edt_username.Text + "&password=" + edt_password.Text;
            DialogResult result;
            if (edt_UserID.Text.Length <= 0)
            {
                result = MessageBox.Show("Tên tài khoản không bỏ trống", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string bodyrequest = "username="+edt_UserID.Text+"&pass="+edt_password.Text;
           bool result_request = RequestAPI.RequestApiControllers._check_request(bodyrequest, RequestAPI.APILink._Adress + RequestAPI.APILink._Insert_User);
            if (result_request == false)
            {
                //Insert that bai
            }
            else
            {
                //Thong bao them tai khoan thanh cong
            }

        }
    }
}
