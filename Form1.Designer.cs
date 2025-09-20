namespace WF_Homework
{
    partial class Form1
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
            this.lblFormDatHang = new System.Windows.Forms.Label();
            this.lblKhacHang = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lsbDanhSachSanPham = new System.Windows.Forms.ListBox();
            this.lblDanhSachSanPham = new System.Windows.Forms.Label();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.cbbThanhToan = new System.Windows.Forms.ComboBox();
            this.btDatHang = new System.Windows.Forms.Button();
            this.lblHienThiThongTinDonHang = new System.Windows.Forms.Label();
            this.lblThongTinDonHang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFormDatHang
            // 
            this.lblFormDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFormDatHang.Location = new System.Drawing.Point(12, 9);
            this.lblFormDatHang.Name = "lblFormDatHang";
            this.lblFormDatHang.Size = new System.Drawing.Size(270, 44);
            this.lblFormDatHang.TabIndex = 0;
            this.lblFormDatHang.Text = "Form đặt hàng";
            // 
            // lblKhacHang
            // 
            this.lblKhacHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhacHang.Location = new System.Drawing.Point(46, 65);
            this.lblKhacHang.Name = "lblKhacHang";
            this.lblKhacHang.Size = new System.Drawing.Size(132, 30);
            this.lblKhacHang.TabIndex = 1;
            this.lblKhacHang.Text = "Khách hàng";
            this.lblKhacHang.Click += new System.EventHandler(this.lblKhacHang_Click);
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDienThoai.Location = new System.Drawing.Point(46, 98);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(132, 30);
            this.lblDienThoai.TabIndex = 2;
            this.lblDienThoai.Text = "Điện thoại";
            this.lblDienThoai.Click += new System.EventHandler(this.lblDienThoai_Click);
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(162, 67);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(213, 22);
            this.txtKhachHang.TabIndex = 3;
            this.txtKhachHang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(162, 95);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(213, 22);
            this.txtDienThoai.TabIndex = 4;
            // 
            // lsbDanhSachSanPham
            // 
            this.lsbDanhSachSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsbDanhSachSanPham.FormattingEnabled = true;
            this.lsbDanhSachSanPham.ItemHeight = 18;
            this.lsbDanhSachSanPham.Items.AddRange(new object[] {
            "Doraemon",
            "Kính Vạn Hoa",
            "Harry Potter"});
            this.lsbDanhSachSanPham.Location = new System.Drawing.Point(50, 165);
            this.lsbDanhSachSanPham.Name = "lsbDanhSachSanPham";
            this.lsbDanhSachSanPham.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbDanhSachSanPham.Size = new System.Drawing.Size(325, 148);
            this.lsbDanhSachSanPham.TabIndex = 5;
            this.lsbDanhSachSanPham.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblDanhSachSanPham
            // 
            this.lblDanhSachSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhSachSanPham.Location = new System.Drawing.Point(46, 138);
            this.lblDanhSachSanPham.Name = "lblDanhSachSanPham";
            this.lblDanhSachSanPham.Size = new System.Drawing.Size(211, 24);
            this.lblDanhSachSanPham.TabIndex = 6;
            this.lblDanhSachSanPham.Text = "Danh sách sản phẩm";
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThanhToan.Location = new System.Drawing.Point(46, 332);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(105, 27);
            this.lblThanhToan.TabIndex = 7;
            this.lblThanhToan.Text = "Thanh toán";
            this.lblThanhToan.Click += new System.EventHandler(this.lblThanhToan_Click);
            // 
            // cbbThanhToan
            // 
            this.cbbThanhToan.FormattingEnabled = true;
            this.cbbThanhToan.Items.AddRange(new object[] {
            "ATM",
            "MoMo e-wallet",
            "ZaloPay",
            "Visa, Mastercard",
            ""});
            this.cbbThanhToan.Location = new System.Drawing.Point(50, 356);
            this.cbbThanhToan.Name = "cbbThanhToan";
            this.cbbThanhToan.Size = new System.Drawing.Size(325, 24);
            this.cbbThanhToan.TabIndex = 8;
            this.cbbThanhToan.Text = "ATM";
            this.cbbThanhToan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btDatHang
            // 
            this.btDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDatHang.Location = new System.Drawing.Point(50, 398);
            this.btDatHang.Name = "btDatHang";
            this.btDatHang.Size = new System.Drawing.Size(101, 29);
            this.btDatHang.TabIndex = 9;
            this.btDatHang.Text = "Đặt hàng";
            this.btDatHang.UseVisualStyleBackColor = true;
            this.btDatHang.Click += new System.EventHandler(this.btDatHang_Click);
            // 
            // lblHienThiThongTinDonHang
            // 
            this.lblHienThiThongTinDonHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHienThiThongTinDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHienThiThongTinDonHang.Location = new System.Drawing.Point(492, 86);
            this.lblHienThiThongTinDonHang.Name = "lblHienThiThongTinDonHang";
            this.lblHienThiThongTinDonHang.Size = new System.Drawing.Size(283, 341);
            this.lblHienThiThongTinDonHang.TabIndex = 10;
            this.lblHienThiThongTinDonHang.Click += new System.EventHandler(this.lblHienThiThongTinDonHang_Click);
            // 
            // lblThongTinDonHang
            // 
            this.lblThongTinDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongTinDonHang.Location = new System.Drawing.Point(491, 62);
            this.lblThongTinDonHang.Name = "lblThongTinDonHang";
            this.lblThongTinDonHang.Size = new System.Drawing.Size(184, 24);
            this.lblThongTinDonHang.TabIndex = 11;
            this.lblThongTinDonHang.Text = "Thông tin đơn hàng";
            this.lblThongTinDonHang.Click += new System.EventHandler(this.lblThongTinDonHang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThongTinDonHang);
            this.Controls.Add(this.lblHienThiThongTinDonHang);
            this.Controls.Add(this.btDatHang);
            this.Controls.Add(this.cbbThanhToan);
            this.Controls.Add(this.lblThanhToan);
            this.Controls.Add(this.lblDanhSachSanPham);
            this.Controls.Add(this.lsbDanhSachSanPham);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lblKhacHang);
            this.Controls.Add(this.lblFormDatHang);
            this.Name = "Form1";
            this.Text = "Chương trình đặt hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormDatHang;
        private System.Windows.Forms.Label lblKhacHang;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.ListBox lsbDanhSachSanPham;
        private System.Windows.Forms.Label lblDanhSachSanPham;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.ComboBox cbbThanhToan;
        private System.Windows.Forms.Button btDatHang;
        private System.Windows.Forms.Label lblHienThiThongTinDonHang;
        private System.Windows.Forms.Label lblThongTinDonHang;
    }
}

