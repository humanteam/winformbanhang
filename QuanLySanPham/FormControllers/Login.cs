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
            if (!RequestAPI.RequestApiControllers.CheckForInternetConnection())
            {
                btn_login.Enabled = false;
                DialogResult result = MessageBox.Show("Please check connect internet !","Error", MessageBoxButtons.RetryCancel,MessageBoxIcon.Stop);
                if (result == DialogResult.Retry)
                {
                    new Login();
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            else
            {
                btn_login.Enabled = true;
            }
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
           bool _isCheck= RequestAPI.RequestApiControllers._check_request(postData, RequestAPI.APILink._Adress + RequestAPI.APILink._Login);
            if (_isCheck)
            {
                AppController.username = edt_username.Text;
                 FormControllers.ProductManager manager = new FormControllers.ProductManager();
                 manager.Show();
                 this.Visible = false;
                 this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("Đăng nhập thất bại");
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thoát chương trình", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void chk_remeber_login_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_remeber_login.Checked)
            {
                edt_password.PasswordChar = char.Parse("\0");
            }
            else
            {
                edt_password.PasswordChar = char.Parse("*");
            }
        }
    }
}
