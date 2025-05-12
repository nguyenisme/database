namespace database
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            menuQuanLyDuLieu = new ToolStripMenuItem();
            menuSach = new ToolStripMenuItem();
            menuTheLoai = new ToolStripMenuItem();
            menuNhanVien = new ToolStripMenuItem();
            menuKhachHang = new ToolStripMenuItem();
            menuQuanLyKho = new ToolStripMenuItem();
            menuPhieuKho = new ToolStripMenuItem();
            menuHangTonKho = new ToolStripMenuItem();
            menuQuanLyDonHang = new ToolStripMenuItem();
            menuDonHang = new ToolStripMenuItem();
            menuChiTietDonHang = new ToolStripMenuItem();
            truyVấnToolStripMenuItem = new ToolStripMenuItem();
            lblTitle = new Label();
            dataGridViewData1 = new DataGridView();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuQuanLyDuLieu, menuQuanLyKho, menuQuanLyDonHang, truyVấnToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(959, 28);
            menuStrip.TabIndex = 0;
            // 
            // menuQuanLyDuLieu
            // 
            menuQuanLyDuLieu.DropDownItems.AddRange(new ToolStripItem[] { menuSach, menuTheLoai, menuNhanVien, menuKhachHang });
            menuQuanLyDuLieu.Name = "menuQuanLyDuLieu";
            menuQuanLyDuLieu.Size = new Size(130, 24);
            menuQuanLyDuLieu.Text = "Quản Lý Dữ Liệu";
            // 
            // menuSach
            // 
            menuSach.Name = "menuSach";
            menuSach.Size = new Size(224, 26);
            menuSach.Text = "Sách";
            menuSach.Click += menuSach_Click;
            // 
            // menuTheLoai
            // 
            menuTheLoai.Name = "menuTheLoai";
            menuTheLoai.Size = new Size(224, 26);
            menuTheLoai.Text = "Thể Loại";
            menuTheLoai.Click += menuTheLoai_Click;
            // 
            // menuNhanVien
            // 
            menuNhanVien.Name = "menuNhanVien";
            menuNhanVien.Size = new Size(224, 26);
            menuNhanVien.Text = "Nhân Viên";
            menuNhanVien.Click += menuNhanVien_Click;
            // 
            // menuKhachHang
            // 
            menuKhachHang.Name = "menuKhachHang";
            menuKhachHang.Size = new Size(224, 26);
            menuKhachHang.Text = "Khách Hàng";
            menuKhachHang.Click += menuKhachHang_Click;
            // 
            // menuQuanLyKho
            // 
            menuQuanLyKho.DropDownItems.AddRange(new ToolStripItem[] { menuPhieuKho, menuHangTonKho });
            menuQuanLyKho.Name = "menuQuanLyKho";
            menuQuanLyKho.Size = new Size(105, 24);
            menuQuanLyKho.Text = "Quản Lý Kho";
            // 
            // menuPhieuKho
            // 
            menuPhieuKho.Name = "menuPhieuKho";
            menuPhieuKho.Size = new Size(187, 26);
            menuPhieuKho.Text = "Phiếu Kho";
            menuPhieuKho.Click += menuPhieuKho_Click;
            // 
            // menuHangTonKho
            // 
            menuHangTonKho.Name = "menuHangTonKho";
            menuHangTonKho.Size = new Size(187, 26);
            menuHangTonKho.Text = "Hàng Tồn Kho";
            menuHangTonKho.Click += menuHangTonKho_Click;
            // 
            // menuQuanLyDonHang
            // 
            menuQuanLyDonHang.DropDownItems.AddRange(new ToolStripItem[] { menuDonHang, menuChiTietDonHang });
            menuQuanLyDonHang.Name = "menuQuanLyDonHang";
            menuQuanLyDonHang.Size = new Size(147, 24);
            menuQuanLyDonHang.Text = "Quản Lý Đơn Hàng";
            // 
            // menuDonHang
            // 
            menuDonHang.Name = "menuDonHang";
            menuDonHang.Size = new Size(214, 26);
            menuDonHang.Text = "Đơn Hàng";
            menuDonHang.Click += menuDonHang_Click;
            // 
            // menuChiTietDonHang
            // 
            menuChiTietDonHang.Name = "menuChiTietDonHang";
            menuChiTietDonHang.Size = new Size(214, 26);
            menuChiTietDonHang.Text = "Chi Tiết Đơn Hàng";
            menuChiTietDonHang.Click += menuChiTietDonHang_Click;
            // 
            // truyVấnToolStripMenuItem
            // 
            truyVấnToolStripMenuItem.Name = "truyVấnToolStripMenuItem";
            truyVấnToolStripMenuItem.Size = new Size(79, 24);
            truyVấnToolStripMenuItem.Text = "Truy Vấn";
            truyVấnToolStripMenuItem.Click += truyVấnToolStripMenuItem_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle.ImageAlign = ContentAlignment.TopCenter;
            lblTitle.Location = new Point(271, 61);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(394, 32);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Hệ Thống Quản Lý Bán Sách";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // dataGridViewData1
            // 
            dataGridViewData1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData1.Location = new Point(12, 135);
            dataGridViewData1.Name = "dataGridViewData1";
            dataGridViewData1.RowHeadersWidth = 51;
            dataGridViewData1.Size = new Size(935, 413);
            dataGridViewData1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(959, 556);
            Controls.Add(dataGridViewData1);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Hệ Thống Quản Lý Bán Sách";
            Load += Form1_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip;
        private ToolStripMenuItem menuQuanLyDuLieu;
        private ToolStripMenuItem menuSach;
        private ToolStripMenuItem menuTheLoai;
        private ToolStripMenuItem menuNhanVien;
        private ToolStripMenuItem menuKhachHang;
        private ToolStripMenuItem menuQuanLyKho;
        private ToolStripMenuItem menuPhieuKho;
        private ToolStripMenuItem menuHangTonKho;
        private ToolStripMenuItem menuQuanLyDonHang;
        private ToolStripMenuItem menuDonHang;
        private ToolStripMenuItem menuChiTietDonHang;
        private Label lblTitle;
        private DataGridView dataGridViewData1;
        private ToolStripMenuItem truyVấnToolStripMenuItem;
    }
}
