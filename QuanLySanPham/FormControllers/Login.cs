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
            string base64request = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(edt_username.Text + ":" + edt_password.Text));
            Uri uri = new Uri(RequestAPI.APILink._Adress + RequestAPI.APILink._Login);
            WebRequest request = WebRequest.Create(RequestAPI.APILink._Adress + RequestAPI.APILink._Login);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            Dictionary<String, String> pagram = new Dictionary<string, string>();
            pagram.Add("username", edt_username.Text);
            pagram.Add("password", edt_password.Text);
            request.Headers.Add("Authorization", "Basic " + base64request);
            WebResponse response = request.GetResponse();
            DialogResult dialogResult = MessageBox.Show(response.ToString());
        }
    }
}
