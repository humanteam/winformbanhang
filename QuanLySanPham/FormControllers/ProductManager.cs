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
    public partial class ProductManager : Form
    {
        public ProductManager()
        {
            InitializeComponent();
            RequestAPI.RequestApiControllers.reponse_json(RequestAPI.APILink._Adress + RequestAPI.APILink._SanPham);
            listItem.View = View.Details;
            if (AppController.username != null)
            {
                txt_tenuser.Text = AppController.username;
                if (String.Compare(AppController.username, "adminstrator") != 0)
                {
                    btn_themuser.Visible = false;
                }
            }
            foreach(Module.SanPham sp in Module.SanPhams.listsp)
            {
                listItem.Items.Add(new ListViewItem(new string[] { sp.MaSP, sp.TenSP, sp.AnhSP, sp.ChiTietSP, sp.GiaSP,sp.TheLoai.TenTheLoai,sp.Account.UserName }));
                listItem.GridLines = true;
            }
        }

        private void btn_themuser_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thoát chương trình", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ProductManager_Load(object sender, EventArgs e)
        {

        }

        private void btn_xoasp_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductManager_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }

        private void ProductManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Thoát chương trình","", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btn_themsp_Click(object sender, EventArgs e)
        {
            Themsanpham themsanpham = new Themsanpham();
            themsanpham.Show();
        }
    }
}
