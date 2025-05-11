using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database
{
    public partial class TruyVanDuLieu : Form
    {
        private readonly string connectionString = "Server=DESKTOP-555IDLF\\NGUYEN;Database=Nghia;Trusted_Connection=True;";

        public TruyVanDuLieu()
        {
            InitializeComponent();
        }

        private void TruyVanDuLieu_Load(object sender, EventArgs e)
        {
            // Khởi tạo ComboBox với các loại truy vấn
            comboBoxQueryType.Items.AddRange(new object[]
            {
                "Danh sách đơn hàng",
                "Chi tiết đơn hàng",
                "Tổng tiền đơn hàng",
                "Top 5 sách bán chạy",
                "Khách hàng mua nhiều nhất"
            });
            comboBoxQueryType.SelectedIndex = 0;
            UpdateTextBoxVisibility();
        }

        private void comboBoxQueryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextBoxVisibility();
        }

        private void UpdateTextBoxVisibility()
        {
            // Hiển thị TextBox chỉ khi cần MaDonHang
            string selectedQuery = comboBoxQueryType.SelectedItem?.ToString();
            bool needOrderId = selectedQuery == "Chi tiết đơn hàng" || selectedQuery == "Tổng tiền đơn hàng";
            textBoxOrderId.Enabled = needOrderId;
            textBoxOrderId.Visible = needOrderId;
            if (!needOrderId)
                textBoxOrderId.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedQuery = comboBoxQueryType.SelectedItem?.ToString();
            string orderId = textBoxOrderId.Text.Trim();

            // Kiểm tra MaDonHang khi cần
            if ((selectedQuery == "Chi tiết đơn hàng" || selectedQuery == "Tổng tiền đơn hàng") && string.IsNullOrEmpty(orderId))
            {
                MessageBox.Show("Vui lòng nhập số đơn hàng (MaDonHang).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "";
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    switch (selectedQuery)
                    {
                        case "Danh sách đơn hàng":
                            query = @"
                                SELECT dh.MaDonHang, dh.NgayDatHang, kh.TenKhachHang
                                FROM DonHang dh
                                JOIN KhachHang kh ON dh.MaKhachHang = kh.MaKhachHang";
                            break;

                        case "Chi tiết đơn hàng":
                            query = @"
                                SELECT ct.MaChiTiet, s.TenSach, ct.SoLuong, ct.DonGia, (ct.SoLuong * ct.DonGia) AS ThanhTien
                                FROM ChiTietDonHang ct
                                JOIN Sach s ON ct.MaSach = s.MaSach
                                WHERE ct.MaDonHang = @MaDonHang";
                            adapter.SelectCommand = new SqlCommand(query, conn);
                            adapter.SelectCommand.Parameters.AddWithValue("@MaDonHang", orderId);
                            break;

                        case "Tổng tiền đơn hàng":
                            query = @"
                                SELECT MaDonHang, SUM(SoLuong * DonGia) AS TongTien
                                FROM ChiTietDonHang
                                WHERE MaDonHang = @MaDonHang
                                GROUP BY MaDonHang";
                            adapter.SelectCommand = new SqlCommand(query, conn);
                            adapter.SelectCommand.Parameters.AddWithValue("@MaDonHang", orderId);
                            break;

                        case "Top 5 sách bán chạy":
                            query = @"
                                SELECT s.MaSach, s.TenSach, SUM(ct.SoLuong) AS TongBan
                                FROM ChiTietDonHang ct
                                JOIN Sach s ON ct.MaSach = s.MaSach
                                GROUP BY s.MaSach, s.TenSach
                                ORDER BY TongBan DESC
                                OFFSET 0 ROWS FETCH NEXT 5 ROWS ONLY";
                            break;

                        case "Khách hàng mua nhiều nhất":
                            query = @"
                                SELECT kh.MaKhachHang, kh.TenKhachHang, COUNT(dh.MaDonHang) AS SoDonHang
                                FROM KhachHang kh
                                JOIN DonHang dh ON kh.MaKhachHang = dh.MaKhachHang
                                GROUP BY kh.MaKhachHang, kh.TenKhachHang
                                ORDER BY SoDonHang DESC
                                OFFSET 0 ROWS FETCH NEXT 4 ROWS ONLY";
                            break;
                    }

                    if (string.IsNullOrEmpty(query))
                        return;

                    if (adapter.SelectCommand == null)
                        adapter.SelectCommand = new SqlCommand(query, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewResults.DataSource = dt;

                    // Tùy chỉnh tiêu đề cột
                    if (selectedQuery == "Danh sách đơn hàng")
                    {
                        dataGridViewResults.Columns["MaDonHang"].HeaderText = "Mã Đơn Hàng";
                        dataGridViewResults.Columns["NgayDatHang"].HeaderText = "Ngày Đặt Hàng";
                        dataGridViewResults.Columns["TenKhachHang"].HeaderText = "Tên Khách Hàng";
                    }
                    else if (selectedQuery == "Chi tiết đơn hàng")
                    {
                        dataGridViewResults.Columns["MaChiTiet"].HeaderText = "Mã Chi Tiết";
                        dataGridViewResults.Columns["TenSach"].HeaderText = "Tên Sách";
                        dataGridViewResults.Columns["SoLuong"].HeaderText = "Số Lượng";
                        dataGridViewResults.Columns["DonGia"].HeaderText = "Đơn Giá";
                        dataGridViewResults.Columns["ThanhTien"].HeaderText = "Thành Tiền";
                    }
                    else if (selectedQuery == "Tổng tiền đơn hàng")
                    {
                        dataGridViewResults.Columns["MaDonHang"].HeaderText = "Mã Đơn Hàng";
                        dataGridViewResults.Columns["TongTien"].HeaderText = "Tổng Tiền";
                    }
                    else if (selectedQuery == "Top 5 sách bán chạy")
                    {
                        dataGridViewResults.Columns["MaSach"].HeaderText = "Mã Sách";
                        dataGridViewResults.Columns["TenSach"].HeaderText = "Tên Sách";
                        dataGridViewResults.Columns["TongBan"].HeaderText = "Tổng Bán";
                    }
                    else if (selectedQuery == "Khách hàng mua nhiều nhất")
                    {
                        dataGridViewResults.Columns["MaKhachHang"].HeaderText = "Mã Khách Hàng";
                        dataGridViewResults.Columns["TenKhachHang"].HeaderText = "Tên Khách Hàng";
                        dataGridViewResults.Columns["SoDonHang"].HeaderText = "Số Đơn Hàng";
                    }
                    dataGridViewResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thực hiện truy vấn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}