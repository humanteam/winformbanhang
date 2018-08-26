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
    public partial class Sua : Form
    {
        public Sua()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        DialogResult rest;

        private void ShowDialogInputError(DialogResult result, string message, string title)
        {
            result = MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DialogResult rest;
           
            if (edt_msp.Text.Length <= 0)
            {
                ShowDialogInputError(rest, "Mã sản phẩm không hợp lệ", "");
                return;
            }
            if (edt_tsp.Text.Length <= 0)
            {
                ShowDialogInputError(rest, "Tên sản phẩm không hợp lệ", "");
                return;
            }
            if (edt_asp.Text.Length <= 0)
            {
                ShowDialogInputError(rest, "Link ảnh không hợp lệ", "");
                return;
            }
            if (edt_gsp.Text.Length <= 0)
            {
                ShowDialogInputError(rest, "Giá không hợp lệ", "");
                return;
            }
            if (edt_ctsp.Text.Length <= 0)
            {
                ShowDialogInputError(rest, "Thông tin sản phẩm không hợp lệ", "");
                return;
            }
            try
            {
                String body_request = "ma=" + edt_msp.Text + "&" +
                    "ten=" + edt_tsp.Text + "&" +
                    "anh=" + edt_asp.Text + "&" +
                    "giasp=" + edt_gsp.Text + "&" +
                    "chitietsp=" + edt_ctsp.Text + "&";

                bool result_requests = RequestAPI.RequestApiControllers._check_request(body_request, RequestAPI.APILink._Adress + RequestAPI.APILink._editSanPham);
                if (result_requests)
                {
                    ShowDialogInputError(rest, "Đã sửa sản phẩm thành công", "");
                }
                else
                {
                    ShowDialogInputError(rest, "Sửa sản phẩm thất bại .Xin vui lòng thử lại", "");
                }

            }
            catch (Exception ex)
            {
                ShowDialogInputError(rest, "Có lỗi khi kết nối server , vui lòng thử lại sau!", "");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Sua_Load(object sender, EventArgs e)
        {

        }
    }
}
