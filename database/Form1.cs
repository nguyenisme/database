using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_sach_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.ShowDialog();
        }

        private void button_theloai_Click(object sender, EventArgs e)
        {
            TheLoai theLoai = new TheLoai();
            theLoai.ShowDialog();
        }

        private void buttonPhieuKho_Click(object sender, EventArgs e)
        {
            PhieuKho phieuKho = new PhieuKho();
            phieuKho.ShowDialog();
        }

        private void buttonNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.ShowDialog();
        }

        private void buttonKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.ShowDialog();
        }

        private void buttonHangTonKho_Click(object sender, EventArgs e)
        {
            HangTonKho hangTonKho = new HangTonKho();
            hangTonKho.ShowDialog();
        }

        private void buttonDonHang_Click(object sender, EventArgs e)
        {
            DonHang donHang = new DonHang();
            donHang.ShowDialog();
        }

        private void buttonChiTietDonHang_Click(object sender, EventArgs e)
        {
            ChiTietDonHang chiTietDonHang = new ChiTietDonHang();
            chiTietDonHang.ShowDialog();
        }
    }
}
