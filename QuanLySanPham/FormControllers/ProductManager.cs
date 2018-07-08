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
            foreach(Module.SanPham sp in Module.SanPhams.listsp)
            {
                listItem.Items.Add(new ListViewItem(new string[] { sp.MaSP, sp.TenSP, sp.AnhSP, sp.ChiTietSP, sp.GiaSP, "  ", "   " }));
                listItem.GridLines = true;
            }
            listItem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
        }

        private void btn_themuser_Click(object sender, EventArgs e)
        {
            Themnguoidung frmThemnguoidung = new Themnguoidung();
            frmThemnguoidung.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ProductManager_Load(object sender, EventArgs e)
        {

        }

        private void btn_xoasp_Click(object sender, EventArgs e)
        {
            Xoasanpham frmXoasanpham = new Xoasanpham();
            frmXoasanpham.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_themsp_Click(object sender, EventArgs e)
        {
            Themsanpham frmThemsanpham = new Themsanpham();
            frmThemsanpham.Show();
        }

        private void btn_suasp_Click(object sender, EventArgs e)
        {
            Sua frmSua = new Sua();
            frmSua.Show();

        }
    }
}
