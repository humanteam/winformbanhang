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
        
        private void edt_username_TextChanged(object sender, EventArgs e)
        {
            if (edt_username.Text == "")
            {

            }
        }
    }
}
