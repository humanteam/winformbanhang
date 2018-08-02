﻿namespace QuanLySanPham.FormControllers
{
    partial class ProductManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.InactiveCaptionText, System.Drawing.Color.Empty, null);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tenuser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listItem = new System.Windows.Forms.ListView();
            this.clMaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clHinhAnh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clChiTiet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenTheLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenNguoiDang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_thoat = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_themuser = new System.Windows.Forms.Button();
            this.btn_xoasp = new System.Windows.Forms.Button();
            this.btn_suasp = new System.Windows.Forms.Button();
            this.btn_themsp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tenuser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(466, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // txt_tenuser
            // 
            this.txt_tenuser.AutoSize = true;
            this.txt_tenuser.Location = new System.Drawing.Point(98, 35);
            this.txt_tenuser.Name = "txt_tenuser";
            this.txt_tenuser.Size = new System.Drawing.Size(0, 13);
            this.txt_tenuser.TabIndex = 1;
            this.txt_tenuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người dùng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listItem);
            this.groupBox2.Location = new System.Drawing.Point(2, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 300);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // listItem
            // 
            this.listItem.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listItem.AllowColumnReorder = true;
            this.listItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMaSP,
            this.clTenSP,
            this.clHinhAnh,
            this.clChiTiet,
            this.clGia,
            this.clTenTheLoai,
            this.clTenNguoiDang});
            this.listItem.GridLines = true;
            this.listItem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listItem.HideSelection = false;
            this.listItem.HotTracking = true;
            this.listItem.HoverSelection = true;
            this.listItem.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listItem.Location = new System.Drawing.Point(2, 19);
            this.listItem.Name = "listItem";
            this.listItem.Size = new System.Drawing.Size(686, 281);
            this.listItem.TabIndex = 4;
            this.listItem.UseCompatibleStateImageBehavior = false;
            this.listItem.View = System.Windows.Forms.View.List;
            this.listItem.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clMaSP
            // 
            this.clMaSP.Text = "Mã Sản Phẩm";
            this.clMaSP.Width = 30;
            // 
            // clTenSP
            // 
            this.clTenSP.Text = "Tên Sản Phẩm";
            this.clTenSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTenSP.Width = 120;
            // 
            // clHinhAnh
            // 
            this.clHinhAnh.Text = "Link Hình Ảnh";
            this.clHinhAnh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clHinhAnh.Width = 120;
            // 
            // clChiTiet
            // 
            this.clChiTiet.Text = "Chi Tiết Sản Phẩm";
            this.clChiTiet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clChiTiet.Width = 120;
            // 
            // clGia
            // 
            this.clGia.Text = "Giá";
            // 
            // clTenTheLoai
            // 
            this.clTenTheLoai.Text = "Tên Thể Loại";
            this.clTenTheLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTenTheLoai.Width = 120;
            // 
            // clTenNguoiDang
            // 
            this.clTenNguoiDang.Text = "Tên Người Đăng";
            this.clTenNguoiDang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = global::QuanLySanPham.Properties.Resources.Actions_edit_delete_icon;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(368, 57);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(92, 23);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_themuser
            // 
            this.btn_themuser.Image = global::QuanLySanPham.Properties.Resources.Groups_Meeting_Light_icon;
            this.btn_themuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themuser.Location = new System.Drawing.Point(235, 57);
            this.btn_themuser.Name = "btn_themuser";
            this.btn_themuser.Size = new System.Drawing.Size(127, 23);
            this.btn_themuser.TabIndex = 6;
            this.btn_themuser.Text = "Thêm người dùng";
            this.btn_themuser.UseVisualStyleBackColor = true;
            this.btn_themuser.Click += new System.EventHandler(this.btn_themuser_Click);
            // 
            // btn_xoasp
            // 
            this.btn_xoasp.Image = global::QuanLySanPham.Properties.Resources.eraser_minus_icon;
            this.btn_xoasp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoasp.Location = new System.Drawing.Point(235, 28);
            this.btn_xoasp.Name = "btn_xoasp";
            this.btn_xoasp.Size = new System.Drawing.Size(106, 23);
            this.btn_xoasp.TabIndex = 2;
            this.btn_xoasp.Text = "Xóa sản phẩm";
            this.btn_xoasp.UseVisualStyleBackColor = true;
            this.btn_xoasp.Click += new System.EventHandler(this.btn_xoasp_Click);
            // 
            // btn_suasp
            // 
            this.btn_suasp.Image = global::QuanLySanPham.Properties.Resources.pencil_icon;
            this.btn_suasp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suasp.Location = new System.Drawing.Point(122, 28);
            this.btn_suasp.Name = "btn_suasp";
            this.btn_suasp.Size = new System.Drawing.Size(106, 23);
            this.btn_suasp.TabIndex = 1;
            this.btn_suasp.Text = "Sửa sản phẩm";
            this.btn_suasp.UseVisualStyleBackColor = true;
          
            // 
            // btn_themsp
            // 
            this.btn_themsp.Image = global::QuanLySanPham.Properties.Resources.add_icon;
            this.btn_themsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themsp.Location = new System.Drawing.Point(4, 28);
            this.btn_themsp.Name = "btn_themsp";
            this.btn_themsp.Size = new System.Drawing.Size(112, 23);
            this.btn_themsp.TabIndex = 0;
            this.btn_themsp.Text = "Thêm sản phẩm";
            this.btn_themsp.UseVisualStyleBackColor = true;
            this.btn_themsp.Click += new System.EventHandler(this.btn_themsp_Click);
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 388);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_themuser);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xoasp);
            this.Controls.Add(this.btn_suasp);
            this.Controls.Add(this.btn_themsp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProductManager";
            this.Text = "Quản Lý Sản Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductManager_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductManager_FormClosed);
            this.Load += new System.EventHandler(this.ProductManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_themsp;
        private System.Windows.Forms.Button btn_suasp;
        private System.Windows.Forms.Button btn_xoasp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txt_tenuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_themuser;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListView listItem;
        private System.Windows.Forms.ColumnHeader clMaSP;
        private System.Windows.Forms.ColumnHeader clTenSP;
        private System.Windows.Forms.ColumnHeader clHinhAnh;
        private System.Windows.Forms.ColumnHeader clChiTiet;
        private System.Windows.Forms.ColumnHeader clGia;
        private System.Windows.Forms.ColumnHeader clTenTheLoai;
        private System.Windows.Forms.ColumnHeader clTenNguoiDang;
    }
}