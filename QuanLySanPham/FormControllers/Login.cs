using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void edt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk_remeber_login_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }
    }
}
