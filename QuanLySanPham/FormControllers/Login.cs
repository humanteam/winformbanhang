using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace QuanLySanPham
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string _user_name = edt_username.Text;
            string _pass_word = edt_password.Text;
            if (_user_name == ""|| _pass_word==""||_user_name.Length>30||_pass_word.Length>15)
            {
                DialogResult result = MessageBox.Show("User name or password not found !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            string postData = "username=" + edt_username.Text + "&password=" + edt_password.Text;
            RequestAPI.RequestApiControllers._check_request(postData, RequestAPI.APILink._Adress + RequestAPI.APILink._Login,"Đăng nhập thành công","Tài khoản hoặc mật khẩu không chính xác");
           
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
