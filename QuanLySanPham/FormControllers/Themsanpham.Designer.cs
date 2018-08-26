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
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.huybo = new System.Windows.Forms.Button();
            this.xacnhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // edt_tensp
            // 
            this.edt_tensp.Location = new System.Drawing.Point(288, 47);
            this.edt_tensp.Margin = new System.Windows.Forms.Padding(5);
            this.edt_tensp.MaxLength = 60;
            this.edt_tensp.Name = "edt_tensp";
            this.edt_tensp.Size = new System.Drawing.Size(531, 22);
            this.edt_tensp.TabIndex = 1;
            this.edt_tensp.TextChanged += new System.EventHandler(this.edt_tensp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hình Ảnh SP";
            // 
            // edt_anhsp
            // 
            this.edt_anhsp.Location = new System.Drawing.Point(288, 124);
            this.edt_anhsp.Margin = new System.Windows.Forms.Padding(5);
            this.edt_anhsp.Name = "edt_anhsp";
            this.edt_anhsp.Size = new System.Drawing.Size(531, 22);
            this.edt_anhsp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá Sản Phẩm";
            // 
            // edt_gia
            // 
            this.edt_gia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.edt_gia.Location = new System.Drawing.Point(288, 208);
            this.edt_gia.Margin = new System.Windows.Forms.Padding(5);
            this.edt_gia.MaxLength = 15;
            this.edt_gia.Name = "edt_gia";
            this.edt_gia.Size = new System.Drawing.Size(531, 22);
            this.edt_gia.TabIndex = 5;
            this.edt_gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_gia_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thông Tin SP";
            // 
            // edt_thongtin
            // 
            this.edt_thongtin.Location = new System.Drawing.Point(288, 286);
            this.edt_thongtin.Margin = new System.Windows.Forms.Padding(5);
            this.edt_thongtin.Name = "edt_thongtin";
            this.edt_thongtin.Size = new System.Drawing.Size(531, 22);
            this.edt_thongtin.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 369);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
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
            this.cbx_theloai.Location = new System.Drawing.Point(288, 366);
            this.cbx_theloai.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_theloai.Name = "cbx_theloai";
            this.cbx_theloai.Size = new System.Drawing.Size(531, 24);
            this.cbx_theloai.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::QuanLySanPham.Properties.Resources.table_select_row_icon;
            this.pictureBox5.Location = new System.Drawing.Point(59, 352);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 39);
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QuanLySanPham.Properties.Resources.coin_us_dollar_icon;
            this.pictureBox4.Location = new System.Drawing.Point(59, 193);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 39);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanLySanPham.Properties.Resources.Status_dialog_information_icon;
            this.pictureBox3.Location = new System.Drawing.Point(59, 268);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 39);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLySanPham.Properties.Resources.Search_Images_icon;
            this.pictureBox2.Location = new System.Drawing.Point(59, 107);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 39);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLySanPham.Properties.Resources.name_card_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(59, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // huybo
            // 
            this.huybo.ForeColor = System.Drawing.Color.Black;
            this.huybo.Image = global::QuanLySanPham.Properties.Resources.Actions_window_close_icon;
            this.huybo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.huybo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.huybo.Location = new System.Drawing.Point(361, 430);
            this.huybo.Margin = new System.Windows.Forms.Padding(5);
            this.huybo.Name = "huybo";
            this.huybo.Size = new System.Drawing.Size(159, 34);
            this.huybo.TabIndex = 11;
            this.huybo.Text = "Hủy Bỏ";
            this.huybo.UseVisualStyleBackColor = true;
            this.huybo.Click += new System.EventHandler(this.huybo_Click);
            // 
            // xacnhan
            // 
            this.xacnhan.ForeColor = System.Drawing.Color.Black;
            this.xacnhan.Image = global::QuanLySanPham.Properties.Resources.Accept_icon;
            this.xacnhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xacnhan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.xacnhan.Location = new System.Drawing.Point(577, 430);
            this.xacnhan.Margin = new System.Windows.Forms.Padding(5);
            this.xacnhan.Name = "xacnhan";
            this.xacnhan.Size = new System.Drawing.Size(172, 34);
            this.xacnhan.TabIndex = 10;
            this.xacnhan.Text = "Xác Nhận";
            this.xacnhan.UseVisualStyleBackColor = true;
            this.xacnhan.Click += new System.EventHandler(this.xacnhan_Click);
            // 
            // Themsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 481);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Themsanpham";
            this.Text = "Themsanpham";
            this.Load += new System.EventHandler(this.Themsanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}