namespace QuanLySanPham.FormControllers
{
    partial class Themsanpham
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
            this.label1 = new System.Windows.Forms.Label();
            this.edt_tensp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_anhsp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_gia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edt_thongtin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_theloai = new System.Windows.Forms.ComboBox();
            this.xacnhan = new System.Windows.Forms.Button();
            this.huybo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // edt_tensp
            // 
            this.edt_tensp.Location = new System.Drawing.Point(180, 40);
            this.edt_tensp.Margin = new System.Windows.Forms.Padding(4);
            this.edt_tensp.MaxLength = 60;
            this.edt_tensp.Name = "edt_tensp";
            this.edt_tensp.Size = new System.Drawing.Size(399, 20);
            this.edt_tensp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hình Ảnh SP";
            // 
            // edt_anhsp
            // 
            this.edt_anhsp.Location = new System.Drawing.Point(180, 103);
            this.edt_anhsp.Margin = new System.Windows.Forms.Padding(4);
            this.edt_anhsp.Name = "edt_anhsp";
            this.edt_anhsp.Size = new System.Drawing.Size(399, 20);
            this.edt_anhsp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá Sản Phẩm";
            // 
            // edt_gia
            // 
            this.edt_gia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.edt_gia.Location = new System.Drawing.Point(180, 171);
            this.edt_gia.Margin = new System.Windows.Forms.Padding(4);
            this.edt_gia.MaxLength = 15;
            this.edt_gia.Name = "edt_gia";
            this.edt_gia.Size = new System.Drawing.Size(399, 20);
            this.edt_gia.TabIndex = 5;
            this.edt_gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_gia_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thông Tin SP";
         
            // 
            // edt_thongtin
            // 
            this.edt_thongtin.Location = new System.Drawing.Point(180, 234);
            this.edt_thongtin.Margin = new System.Windows.Forms.Padding(4);
            this.edt_thongtin.Name = "edt_thongtin";
            this.edt_thongtin.Size = new System.Drawing.Size(399, 20);
            this.edt_thongtin.TabIndex = 7;
         
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 302);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Thể Loại SP";
           
            // 
            // cbx_theloai
            // 
            this.cbx_theloai.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cbx_theloai.Items.AddRange(new object[] {
            "Mỹ Phẩm",
            "Sản Phẩm Tóc",
            "Thiết Bị"});
            this.cbx_theloai.Location = new System.Drawing.Point(180, 299);
            this.cbx_theloai.Name = "cbx_theloai";
            this.cbx_theloai.Size = new System.Drawing.Size(399, 21);
            this.cbx_theloai.TabIndex = 2;
         
            // 
            // xacnhan
            // 
            this.xacnhan.ForeColor = System.Drawing.Color.Black;
            this.xacnhan.Image = global::QuanLySanPham.Properties.Resources.Accept_icon;
            this.xacnhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xacnhan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.xacnhan.Location = new System.Drawing.Point(390, 371);
            this.xacnhan.Margin = new System.Windows.Forms.Padding(4);
            this.xacnhan.Name = "xacnhan";
            this.xacnhan.Size = new System.Drawing.Size(129, 28);
            this.xacnhan.TabIndex = 10;
            this.xacnhan.Text = "Xác Nhận";
            this.xacnhan.UseVisualStyleBackColor = true;
            this.xacnhan.Click += new System.EventHandler(this.xacnhan_Click);
            // 
            // huybo
            // 
            this.huybo.ForeColor = System.Drawing.Color.Black;
            this.huybo.Image = global::QuanLySanPham.Properties.Resources.Actions_window_close_icon;
            this.huybo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.huybo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.huybo.Location = new System.Drawing.Point(228, 371);
            this.huybo.Margin = new System.Windows.Forms.Padding(4);
            this.huybo.Name = "huybo";
            this.huybo.Size = new System.Drawing.Size(119, 28);
            this.huybo.TabIndex = 11;
            this.huybo.Text = "Hủy Bỏ";
            this.huybo.UseVisualStyleBackColor = true;
          
            // 
            // Themsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 433);
            this.Controls.Add(this.huybo);
            this.Controls.Add(this.xacnhan);
            this.Controls.Add(this.cbx_theloai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edt_thongtin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edt_gia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edt_anhsp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edt_tensp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Themsanpham";
            this.Text = "Themsanpham";
            this.Load += new System.EventHandler(this.Themsanpham_Load);
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edt_tensp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edt_anhsp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edt_gia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edt_thongtin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button xacnhan;
        private System.Windows.Forms.Button huybo;
        private System.Windows.Forms.ComboBox cbx_theloai;
    }
}