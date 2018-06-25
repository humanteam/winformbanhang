namespace QuanLySanPham.FormControllers
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
            this.btn_themsp = new System.Windows.Forms.Button();
            this.btn_suasp = new System.Windows.Forms.Button();
            this.btn_xoasp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tenuser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_themuser = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_themsp
            // 
            this.btn_themsp.Location = new System.Drawing.Point(2, 12);
            this.btn_themsp.Name = "btn_themsp";
            this.btn_themsp.Size = new System.Drawing.Size(94, 23);
            this.btn_themsp.TabIndex = 0;
            this.btn_themsp.Text = "Thêm sản phẩm";
            this.btn_themsp.UseVisualStyleBackColor = true;
            // 
            // btn_suasp
            // 
            this.btn_suasp.Location = new System.Drawing.Point(102, 12);
            this.btn_suasp.Name = "btn_suasp";
            this.btn_suasp.Size = new System.Drawing.Size(94, 23);
            this.btn_suasp.TabIndex = 1;
            this.btn_suasp.Text = "Sửa sản phẩm";
            this.btn_suasp.UseVisualStyleBackColor = true;
            // 
            // btn_xoasp
            // 
            this.btn_xoasp.Location = new System.Drawing.Point(202, 12);
            this.btn_xoasp.Name = "btn_xoasp";
            this.btn_xoasp.Size = new System.Drawing.Size(94, 23);
            this.btn_xoasp.TabIndex = 2;
            this.btn_xoasp.Text = "Xóa sản phẩm";
            this.btn_xoasp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tenuser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(462, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // txt_tenuser
            // 
            this.txt_tenuser.AutoSize = true;
            this.txt_tenuser.Location = new System.Drawing.Point(98, 35);
            this.txt_tenuser.Name = "txt_tenuser";
            this.txt_tenuser.Size = new System.Drawing.Size(119, 13);
            this.txt_tenuser.TabIndex = 1;
            this.txt_tenuser.Text = "Tên người dùng hiển thị";
            this.txt_tenuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người dùng:";
            // 
            // btn_themuser
            // 
            this.btn_themuser.Enabled = false;
            this.btn_themuser.Location = new System.Drawing.Point(302, 12);
            this.btn_themuser.Name = "btn_themuser";
            this.btn_themuser.Size = new System.Drawing.Size(102, 23);
            this.btn_themuser.TabIndex = 4;
            this.btn_themuser.Text = "Thêm người dùng";
            this.btn_themuser.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(2, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 277);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các sản phẩm";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(165, 56);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 387);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_themuser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xoasp);
            this.Controls.Add(this.btn_suasp);
            this.Controls.Add(this.btn_themsp);
            this.Name = "ProductManager";
            this.Text = "ProductManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductManager_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductManager_FormClosed);
            this.Load += new System.EventHandler(this.ProductManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_themsp;
        private System.Windows.Forms.Button btn_suasp;
        private System.Windows.Forms.Button btn_xoasp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txt_tenuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_themuser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_thoat;
    }
}