namespace database
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_sach = new Button();
            button_theloai = new Button();
            buttonPhieuKho = new Button();
            buttonNhanVien = new Button();
            buttonKhachHang = new Button();
            buttonHangTonKho = new Button();
            buttonDonHang = new Button();
            buttonChiTietDonHang = new Button();
            SuspendLayout();
            // 
            // button_sach
            // 
            button_sach.Location = new Point(128, 182);
            button_sach.Name = "button_sach";
            button_sach.Size = new Size(94, 29);
            button_sach.TabIndex = 0;
            button_sach.Text = "Sách";
            button_sach.UseVisualStyleBackColor = true;
            button_sach.Click += button_sach_Click;
            // 
            // button_theloai
            // 
            button_theloai.Location = new Point(228, 182);
            button_theloai.Name = "button_theloai";
            button_theloai.Size = new Size(94, 29);
            button_theloai.TabIndex = 1;
            button_theloai.Text = "Thể Loại";
            button_theloai.UseVisualStyleBackColor = true;
            button_theloai.Click += button_theloai_Click;
            // 
            // buttonPhieuKho
            // 
            buttonPhieuKho.Location = new Point(328, 182);
            buttonPhieuKho.Name = "buttonPhieuKho";
            buttonPhieuKho.Size = new Size(94, 29);
            buttonPhieuKho.TabIndex = 2;
            buttonPhieuKho.Text = "Phiếu Kho";
            buttonPhieuKho.UseVisualStyleBackColor = true;
            buttonPhieuKho.Click += buttonPhieuKho_Click;
            // 
            // buttonNhanVien
            // 
            buttonNhanVien.Location = new Point(428, 182);
            buttonNhanVien.Name = "buttonNhanVien";
            buttonNhanVien.Size = new Size(94, 29);
            buttonNhanVien.TabIndex = 3;
            buttonNhanVien.Text = "Nhân Viên";
            buttonNhanVien.UseVisualStyleBackColor = true;
            buttonNhanVien.Click += buttonNhanVien_Click;
            // 
            // buttonKhachHang
            // 
            buttonKhachHang.Location = new Point(528, 182);
            buttonKhachHang.Name = "buttonKhachHang";
            buttonKhachHang.Size = new Size(94, 29);
            buttonKhachHang.TabIndex = 4;
            buttonKhachHang.Text = "Khách Hàng";
            buttonKhachHang.UseVisualStyleBackColor = true;
            buttonKhachHang.Click += buttonKhachHang_Click;
            // 
            // buttonHangTonKho
            // 
            buttonHangTonKho.Location = new Point(228, 217);
            buttonHangTonKho.Name = "buttonHangTonKho";
            buttonHangTonKho.Size = new Size(117, 29);
            buttonHangTonKho.TabIndex = 5;
            buttonHangTonKho.Text = "Hàng Tồn Kho";
            buttonHangTonKho.UseVisualStyleBackColor = true;
            buttonHangTonKho.Click += buttonHangTonKho_Click;
            // 
            // buttonDonHang
            // 
            buttonDonHang.Location = new Point(351, 217);
            buttonDonHang.Name = "buttonDonHang";
            buttonDonHang.Size = new Size(94, 29);
            buttonDonHang.TabIndex = 6;
            buttonDonHang.Text = "Đơn Hàng";
            buttonDonHang.UseVisualStyleBackColor = true;
            buttonDonHang.Click += buttonDonHang_Click;
            // 
            // buttonChiTietDonHang
            // 
            buttonChiTietDonHang.Location = new Point(280, 252);
            buttonChiTietDonHang.Name = "buttonChiTietDonHang";
            buttonChiTietDonHang.Size = new Size(142, 29);
            buttonChiTietDonHang.TabIndex = 7;
            buttonChiTietDonHang.Text = "Chi Tiết Đơn Hàng";
            buttonChiTietDonHang.UseVisualStyleBackColor = true;
            buttonChiTietDonHang.Click += buttonChiTietDonHang_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonChiTietDonHang);
            Controls.Add(buttonDonHang);
            Controls.Add(buttonHangTonKho);
            Controls.Add(buttonKhachHang);
            Controls.Add(buttonNhanVien);
            Controls.Add(buttonPhieuKho);
            Controls.Add(button_theloai);
            Controls.Add(button_sach);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Sach;
        private Button button_sach;
        private Button button_theloai;
        private Button buttonPhieuKho;
        private Button buttonNhanVien;
        private Button buttonKhachHang;
        private Button buttonHangTonKho;
        private Button buttonDonHang;
        private Button buttonChiTietDonHang;
    }
}
