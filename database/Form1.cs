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
        string connectionString = @"Server=DESKTOP-555IDLF\NGUYEN;Database=Nghia;Trusted_Connection=True;";
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void menuSach_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.ShowDialog();
        }

        private void menuTheLoai_Click(object sender, EventArgs e)
        {
            TheLoai theLoai = new TheLoai();
            theLoai.ShowDialog();
        }

        private void menuPhieuKho_Click(object sender, EventArgs e)
        {
            PhieuKho phieuKho = new PhieuKho();
            phieuKho.ShowDialog();
        }

        private void menuNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.ShowDialog();
        }

        private void menuKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.ShowDialog();
        }

        private void menuHangTonKho_Click(object sender, EventArgs e)
        {
            HangTonKho hangTonKho = new HangTonKho();
            hangTonKho.ShowDialog();
        }

        private void menuDonHang_Click(object sender, EventArgs e)
        {
            DonHang donHang = new DonHang();
            donHang.ShowDialog();
        }

        private void menuChiTietDonHang_Click(object sender, EventArgs e)
        {
            ChiTietDonHang chiTietDonHang = new ChiTietDonHang();
            chiTietDonHang.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string connectionString = @"Server=DESKTOP-555IDLF\NGUYEN;Database=Nghia;Trusted_Connection=True;";
            conn = new SqlConnection(connectionString);

            string query = "SELECT * FROM Sach";
            adapter = new SqlDataAdapter(query, conn);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewData1.ReadOnly = true;
            dataGridViewData1.DataSource = dt;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void truyVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TruyVanDuLieu truyVanDuLieu = new TruyVanDuLieu();
            truyVanDuLieu.ShowDialog();
        }
    }
}
