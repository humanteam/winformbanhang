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
    public partial class Themsanpham : Form
    {
        DialogResult rest;
        String[] arr_values_cbx = { "Mỹ Phẩm", "Sản Phẩm", "TócThiết Bị" };

        public Themsanpham()
        {
            InitializeComponent();
            cbx_theloai.SelectedIndex = 0;
            cbx_theloai.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Themsanpham_Load(object sender, EventArgs e)
        {

        }

        private void xacnhan_Click(object sender, EventArgs e)
        {
            int matheloai = cbx_theloai.SelectedIndex + 1;
           // DialogResult rest;
            if (edt_tensp.Text.Length <= 0)
            {
                ShowDialogInputError(rest, "Tên sản phẩm không hợp lệ", "");
                return;
            }
            if (edt_anhsp.Text.Length <= 0)
            {
                ShowDialogInputError(rest, "Link ảnh không hợp lệ", "");
                return;
            }
            if (edt_gia.Text.Length <= 0)
            {
                ShowDialogInputError(rest, "Giá không hợp lệ", "");
                return;
            }
            if (edt_thongtin.Text.Length <= 0)
            {
                ShowDialogInputError(rest, "Thông tin sản phẩm không hợp lệ", "");
                return;
            }
            try
            {
                String body_request = "tensp=" + edt_tensp.Text + "&" +
                    "anhsp=" + edt_anhsp.Text + "&" +
                    "giasp=" + edt_gia.Text + "&" +
                    "chitietsp=" + edt_thongtin.Text + "&" +
                    "matheloai=" + matheloai + "&" +
                    "mauser=" + 1;
                bool result_request= RequestAPI.RequestApiControllers._check_request(body_request, RequestAPI.APILink._Adress + RequestAPI.APILink._Insert);
                if (result_request)
                {
                    ShowDialogInputError(rest, "Đã thêm thành công sản phẩm", "");
                }
                else
                {
                    ShowDialogInputError(rest, "Thêm sản phẩm thất bại .Xin vui lòng thử lại", "");
                }

            }
            catch(Exception ex)
            {
                
            }
        }

        private void ShowDialogInputError(DialogResult result,string message,string title)
        {
            result = MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        private void edt_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void huybo_Click(object sender, EventArgs e)
        {

        }

        private void edt_tensp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
