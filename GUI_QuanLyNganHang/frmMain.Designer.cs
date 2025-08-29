namespace GUI_QuanLyNganHang
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelUser = new ToolStripStatusLabel();
            toolStripStatusLabelTime = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            pnLeft = new Panel();
            pnKhachHang = new Panel();
            pnChucNangKhachHang = new Panel();
            btnQuanLyKhachHang = new Button();
            btnKhachHang = new Button();
            pnHeThong = new Panel();
            pnHeThongChucNang = new Panel();
            btnThoat = new Button();
            btnDangXuat = new Button();
            btnThongTinTaiKhoan = new Button();
            btnDoiMatKhau = new Button();
            btnHeThong = new Button();
            notifyIcon1 = new NotifyIcon(components);
            menuscriptMain = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuHeThong_DoiMatKhau = new ToolStripMenuItem();
            mnuHeThong_ThongTinTK = new ToolStripMenuItem();
            mnuHeThong_DangXuat = new ToolStripMenuItem();
            mnuHeThong_Thoat = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuKhachHang_QLKhachHang = new ToolStripMenuItem();
            mnuKhachHang_QLTaiKhoanNganHang = new ToolStripMenuItem();
            mnuGiaoDich = new ToolStripMenuItem();
            mnuKhoanvay = new ToolStripMenuItem();
            mnuKhoanvay_DSKhoanVay = new ToolStripMenuItem();
            mnuKhoanvay_ThanhToanKhoanVay = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            pnMain = new Panel();
            statusStrip1.SuspendLayout();
            pnLeft.SuspendLayout();
            pnKhachHang.SuspendLayout();
            pnChucNangKhachHang.SuspendLayout();
            pnHeThong.SuspendLayout();
            pnHeThongChucNang.SuspendLayout();
            menuscriptMain.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelUser, toolStripStatusLabelTime });
            statusStrip1.Location = new Point(0, 600);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1015, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUser
            // 
            toolStripStatusLabelUser.Name = "toolStripStatusLabelUser";
            toolStripStatusLabelUser.Size = new Size(118, 17);
            toolStripStatusLabelUser.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabelTime
            // 
            toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            toolStripStatusLabelTime.Size = new Size(118, 17);
            toolStripStatusLabelTime.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pnLeft
            // 
            pnLeft.AutoSize = true;
            pnLeft.BackColor = Color.SpringGreen;
            pnLeft.Controls.Add(pnKhachHang);
            pnLeft.Controls.Add(pnHeThong);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 0);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(0, 600);
            pnLeft.TabIndex = 2;
            // 
            // pnKhachHang
            // 
            pnKhachHang.Controls.Add(pnChucNangKhachHang);
            pnKhachHang.Controls.Add(btnKhachHang);
            pnKhachHang.Dock = DockStyle.Top;
            pnKhachHang.Location = new Point(0, 172);
            pnKhachHang.Name = "pnKhachHang";
            pnKhachHang.Size = new Size(0, 131);
            pnKhachHang.TabIndex = 1;
            // 
            // pnChucNangKhachHang
            // 
            pnChucNangKhachHang.Controls.Add(btnQuanLyKhachHang);
            pnChucNangKhachHang.Dock = DockStyle.Top;
            pnChucNangKhachHang.Location = new Point(0, 28);
            pnChucNangKhachHang.Name = "pnChucNangKhachHang";
            pnChucNangKhachHang.Size = new Size(0, 100);
            pnChucNangKhachHang.TabIndex = 1;
            pnChucNangKhachHang.Visible = false;
            // 
            // btnQuanLyKhachHang
            // 
            btnQuanLyKhachHang.Dock = DockStyle.Top;
            btnQuanLyKhachHang.Location = new Point(0, 0);
            btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            btnQuanLyKhachHang.Size = new Size(0, 23);
            btnQuanLyKhachHang.TabIndex = 0;
            btnQuanLyKhachHang.Text = "Quản lý khách ";
            btnQuanLyKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKhachHang.Location = new Point(0, 0);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(0, 28);
            btnKhachHang.TabIndex = 0;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            // 
            // pnHeThong
            // 
            pnHeThong.Controls.Add(pnHeThongChucNang);
            pnHeThong.Controls.Add(btnHeThong);
            pnHeThong.Dock = DockStyle.Top;
            pnHeThong.Location = new Point(0, 0);
            pnHeThong.Name = "pnHeThong";
            pnHeThong.Size = new Size(0, 172);
            pnHeThong.TabIndex = 0;
            // 
            // pnHeThongChucNang
            // 
            pnHeThongChucNang.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnHeThongChucNang.Controls.Add(btnThoat);
            pnHeThongChucNang.Controls.Add(btnDangXuat);
            pnHeThongChucNang.Controls.Add(btnThongTinTaiKhoan);
            pnHeThongChucNang.Controls.Add(btnDoiMatKhau);
            pnHeThongChucNang.Dock = DockStyle.Fill;
            pnHeThongChucNang.Location = new Point(0, 34);
            pnHeThongChucNang.Name = "pnHeThongChucNang";
            pnHeThongChucNang.Size = new Size(0, 138);
            pnHeThongChucNang.TabIndex = 2;
            pnHeThongChucNang.Visible = false;
            // 
            // btnThoat
            // 
            btnThoat.Dock = DockStyle.Top;
            btnThoat.Location = new Point(0, 102);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(0, 33);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Dock = DockStyle.Top;
            btnDangXuat.Location = new Point(0, 68);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(0, 34);
            btnDangXuat.TabIndex = 2;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // btnThongTinTaiKhoan
            // 
            btnThongTinTaiKhoan.Dock = DockStyle.Top;
            btnThongTinTaiKhoan.Location = new Point(0, 34);
            btnThongTinTaiKhoan.Name = "btnThongTinTaiKhoan";
            btnThongTinTaiKhoan.Size = new Size(0, 34);
            btnThongTinTaiKhoan.TabIndex = 1;
            btnThongTinTaiKhoan.Text = "Thông tin tài khoản";
            btnThongTinTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Dock = DockStyle.Top;
            btnDoiMatKhau.ForeColor = Color.Black;
            btnDoiMatKhau.Location = new Point(0, 0);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(0, 34);
            btnDoiMatKhau.TabIndex = 0;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            // 
            // btnHeThong
            // 
            btnHeThong.Dock = DockStyle.Top;
            btnHeThong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHeThong.Location = new Point(0, 0);
            btnHeThong.Name = "btnHeThong";
            btnHeThong.Size = new Size(0, 34);
            btnHeThong.TabIndex = 0;
            btnHeThong.Text = "Hệ thống";
            btnHeThong.UseVisualStyleBackColor = true;
            btnHeThong.Click += btnHeThong_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // menuscriptMain
            // 
            menuscriptMain.BackColor = Color.Cyan;
            menuscriptMain.Dock = DockStyle.Left;
            menuscriptMain.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuKhachHang, mnuGiaoDich, mnuKhoanvay, mnuNhanVien, mnuTroGiup });
            menuscriptMain.Location = new Point(0, 0);
            menuscriptMain.Name = "menuscriptMain";
            menuscriptMain.Size = new Size(126, 600);
            menuscriptMain.TabIndex = 4;
            menuscriptMain.Text = "menuStrip2";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuHeThong_DoiMatKhau, mnuHeThong_ThongTinTK, mnuHeThong_DangXuat, mnuHeThong_Thoat });
            mnuHeThong.Font = new Font("Segoe UI", 12F);
            mnuHeThong.Image = (Image)resources.GetObject("mnuHeThong.Image");
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(113, 25);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuHeThong_DoiMatKhau
            // 
            mnuHeThong_DoiMatKhau.Font = new Font("Times New Roman", 12F);
            mnuHeThong_DoiMatKhau.Image = (Image)resources.GetObject("mnuHeThong_DoiMatKhau.Image");
            mnuHeThong_DoiMatKhau.Name = "mnuHeThong_DoiMatKhau";
            mnuHeThong_DoiMatKhau.Size = new Size(214, 26);
            mnuHeThong_DoiMatKhau.Text = "Đổi mật khẩu";
            mnuHeThong_DoiMatKhau.Click += mnuHeThong_DoiMatKhau_Click;
            // 
            // mnuHeThong_ThongTinTK
            // 
            mnuHeThong_ThongTinTK.Image = (Image)resources.GetObject("mnuHeThong_ThongTinTK.Image");
            mnuHeThong_ThongTinTK.Name = "mnuHeThong_ThongTinTK";
            mnuHeThong_ThongTinTK.Size = new Size(214, 26);
            mnuHeThong_ThongTinTK.Text = "Thông tin tài khoản";
            // 
            // mnuHeThong_DangXuat
            // 
            mnuHeThong_DangXuat.Image = (Image)resources.GetObject("mnuHeThong_DangXuat.Image");
            mnuHeThong_DangXuat.Name = "mnuHeThong_DangXuat";
            mnuHeThong_DangXuat.Size = new Size(214, 26);
            mnuHeThong_DangXuat.Text = "Đăng xuất";
            mnuHeThong_DangXuat.Click += mnuHeThong_DangXuat_Click;
            // 
            // mnuHeThong_Thoat
            // 
            mnuHeThong_Thoat.Image = (Image)resources.GetObject("mnuHeThong_Thoat.Image");
            mnuHeThong_Thoat.Name = "mnuHeThong_Thoat";
            mnuHeThong_Thoat.Size = new Size(214, 26);
            mnuHeThong_Thoat.Text = "Thoát";
            mnuHeThong_Thoat.Click += mnuHeThong_Thoat_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.DropDownItems.AddRange(new ToolStripItem[] { mnuKhachHang_QLKhachHang, mnuKhachHang_QLTaiKhoanNganHang });
            mnuKhachHang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuKhachHang.Image = (Image)resources.GetObject("mnuKhachHang.Image");
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(113, 23);
            mnuKhachHang.Text = "Khách hàng";
            // 
            // mnuKhachHang_QLKhachHang
            // 
            mnuKhachHang_QLKhachHang.Image = (Image)resources.GetObject("mnuKhachHang_QLKhachHang.Image");
            mnuKhachHang_QLKhachHang.Name = "mnuKhachHang_QLKhachHang";
            mnuKhachHang_QLKhachHang.Size = new Size(248, 24);
            mnuKhachHang_QLKhachHang.Text = "Quản lý khách hàng";
            mnuKhachHang_QLKhachHang.Click += mnuKhachHang_QLKhachHang_Click;
            // 
            // mnuKhachHang_QLTaiKhoanNganHang
            // 
            mnuKhachHang_QLTaiKhoanNganHang.Image = (Image)resources.GetObject("mnuKhachHang_QLTaiKhoanNganHang.Image");
            mnuKhachHang_QLTaiKhoanNganHang.Name = "mnuKhachHang_QLTaiKhoanNganHang";
            mnuKhachHang_QLTaiKhoanNganHang.Size = new Size(248, 24);
            mnuKhachHang_QLTaiKhoanNganHang.Text = "Quản lý tài khoản ngân hàng";
            mnuKhachHang_QLTaiKhoanNganHang.Click += mnuKhachHang_QLTaiKhoanNganHang_Click;
            // 
            // mnuGiaoDich
            // 
            mnuGiaoDich.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuGiaoDich.Image = (Image)resources.GetObject("mnuGiaoDich.Image");
            mnuGiaoDich.Name = "mnuGiaoDich";
            mnuGiaoDich.Size = new Size(113, 23);
            mnuGiaoDich.Text = "Giao dịch";
            // 
            // mnuKhoanvay
            // 
            mnuKhoanvay.DropDownItems.AddRange(new ToolStripItem[] { mnuKhoanvay_DSKhoanVay, mnuKhoanvay_ThanhToanKhoanVay });
            mnuKhoanvay.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuKhoanvay.Image = (Image)resources.GetObject("mnuKhoanvay.Image");
            mnuKhoanvay.Name = "mnuKhoanvay";
            mnuKhoanvay.Size = new Size(113, 23);
            mnuKhoanvay.Text = "Khoản vay";
            // 
            // mnuKhoanvay_DSKhoanVay
            // 
            mnuKhoanvay_DSKhoanVay.Image = (Image)resources.GetObject("mnuKhoanvay_DSKhoanVay.Image");
            mnuKhoanvay_DSKhoanVay.Name = "mnuKhoanvay_DSKhoanVay";
            mnuKhoanvay_DSKhoanVay.Size = new Size(211, 24);
            mnuKhoanvay_DSKhoanVay.Text = "Danh sách khoản vay";
            // 
            // mnuKhoanvay_ThanhToanKhoanVay
            // 
            mnuKhoanvay_ThanhToanKhoanVay.Image = (Image)resources.GetObject("mnuKhoanvay_ThanhToanKhoanVay.Image");
            mnuKhoanvay_ThanhToanKhoanVay.Name = "mnuKhoanvay_ThanhToanKhoanVay";
            mnuKhoanvay_ThanhToanKhoanVay.Size = new Size(211, 24);
            mnuKhoanvay_ThanhToanKhoanVay.Text = "Thanh toán khoản vay";
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuNhanVien.Image = (Image)resources.GetObject("mnuNhanVien.Image");
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(113, 23);
            mnuNhanVien.Text = "Nhân viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuTroGiup.Image = (Image)resources.GetObject("mnuTroGiup.Image");
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(113, 23);
            mnuTroGiup.Text = "Trợ giúp";
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.White;
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(126, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(889, 600);
            pnMain.TabIndex = 5;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1015, 622);
            Controls.Add(pnMain);
            Controls.Add(menuscriptMain);
            Controls.Add(pnLeft);
            Controls.Add(statusStrip1);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnLeft.ResumeLayout(false);
            pnKhachHang.ResumeLayout(false);
            pnChucNangKhachHang.ResumeLayout(false);
            pnHeThong.ResumeLayout(false);
            pnHeThongChucNang.ResumeLayout(false);
            menuscriptMain.ResumeLayout(false);
            menuscriptMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelUser;
        private ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.Timer timer1;
        private Panel pnLeft;
        private Panel pnHeThong;
        private Panel pnHeThongChucNang;
        private Button btnDangXuat;
        private Button btnThongTinTaiKhoan;
        private Button btnDoiMatKhau;
        private Button btnHeThong;
        private NotifyIcon notifyIcon1;
        private Button btnThoat;
        private Panel pnKhachHang;
        private Panel pnChucNangKhachHang;
        private Button btnQuanLyKhachHang;
        private Button btnKhachHang;
        private MenuStrip menuscriptMain;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuHeThong_DoiMatKhau;
        private ToolStripMenuItem mnuHeThong_ThongTinTK;
        private ToolStripMenuItem mnuHeThong_DangXuat;
        private ToolStripMenuItem mnuHeThong_Thoat;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuKhachHang_QLKhachHang;
        private ToolStripMenuItem mnuKhachHang_QLTaiKhoanNganHang;
        private ToolStripMenuItem mnuGiaoDich;
        private ToolStripMenuItem mnuKhoanvay;
        private ToolStripMenuItem mnuKhoanvay_DSKhoanVay;
        private ToolStripMenuItem mnuKhoanvay_ThanhToanKhoanVay;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuTroGiup;
        private Panel pnMain;
    }
}