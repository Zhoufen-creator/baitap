using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKhacHang_Click(object sender, EventArgs e)
        {

        }

        private void lblDienThoai_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblHienThiThongTinDonHang_Click(object sender, EventArgs e)
        {

        }

        private void lblThongTinDonHang_Click(object sender, EventArgs e)
        {

        }

        private void btDatHang_Click(object sender, EventArgs e)
        {
            string sanPhamDaChon = "";
            foreach (var item in lsbDanhSachSanPham.SelectedItems)
            {
                sanPhamDaChon += "- "+ item.ToString() + "\n";
            }
            lblHienThiThongTinDonHang.Text = "Khách hàng " + txtKhachHang.Text + "\n" +
                                             "Điện thoại " + txtDienThoai.Text + "\n" +
                                             "Sản phẩm đặt mua \n" + sanPhamDaChon +
                                             "Cách thanh toán " + cbbThanhToan.SelectedItem.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult choice = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }  
    }
}
