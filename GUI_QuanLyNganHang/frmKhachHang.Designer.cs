namespace GUI_QuanLyNganHang
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            pnDuoi = new Panel();
            pnDgv = new Panel();
            dgvKhachHang = new DataGridView();
            pnTimKiemKhachHang = new Panel();
            btnTimKhachHang = new Button();
            txtTimKhachHang = new TextBox();
            pnChucNang = new Panel();
            btnLamMoiKhachHang = new Button();
            btnXoaKhachHang = new Button();
            btnCapNhatKhachHang = new Button();
            btnThemKhachHang = new Button();
            pnThongTinKhachHang = new Panel();
            dtpNgayGuiCanhBao = new DateTimePicker();
            label11 = new Label();
            cbMaKH = new ComboBox();
            dtpNgayTamNgung = new DateTimePicker();
            dtpNgayDangNhapCuoi = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            txtSDTKhachHang = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            rbTamNgung = new RadioButton();
            rbHoatDong = new RadioButton();
            txtCCCD = new TextBox();
            txtMatKhauKhachHang = new TextBox();
            txtTenKH = new TextBox();
            txtEmailKhachHang = new TextBox();
            txtDiaChiKhachHang = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureAnhNV = new PictureBox();
            pnDuoi.SuspendLayout();
            pnDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            pnTimKiemKhachHang.SuspendLayout();
            pnChucNang.SuspendLayout();
            pnThongTinKhachHang.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAnhNV).BeginInit();
            SuspendLayout();
            // 
            // pnDuoi
            // 
            pnDuoi.Controls.Add(pnDgv);
            pnDuoi.Controls.Add(pnTimKiemKhachHang);
            pnDuoi.Controls.Add(pnChucNang);
            pnDuoi.Dock = DockStyle.Fill;
            pnDuoi.Location = new Point(0, 176);
            pnDuoi.Name = "pnDuoi";
            pnDuoi.Size = new Size(884, 385);
            pnDuoi.TabIndex = 3;
            // 
            // pnDgv
            // 
            pnDgv.Controls.Add(dgvKhachHang);
            pnDgv.Dock = DockStyle.Fill;
            pnDgv.Location = new Point(0, 26);
            pnDgv.Name = "pnDgv";
            pnDgv.Size = new Size(691, 359);
            pnDgv.TabIndex = 5;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 0);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.Size = new Size(691, 359);
            dgvKhachHang.TabIndex = 3;
            dgvKhachHang.CellDoubleClick += dgvKhachHang_CellDoubleClick;
            // 
            // pnTimKiemKhachHang
            // 
            pnTimKiemKhachHang.Controls.Add(btnTimKhachHang);
            pnTimKiemKhachHang.Controls.Add(txtTimKhachHang);
            pnTimKiemKhachHang.Dock = DockStyle.Top;
            pnTimKiemKhachHang.Location = new Point(0, 0);
            pnTimKiemKhachHang.Name = "pnTimKiemKhachHang";
            pnTimKiemKhachHang.Size = new Size(691, 26);
            pnTimKiemKhachHang.TabIndex = 4;
            // 
            // btnTimKhachHang
            // 
            btnTimKhachHang.BackgroundImage = (Image)resources.GetObject("btnTimKhachHang.BackgroundImage");
            btnTimKhachHang.BackgroundImageLayout = ImageLayout.Zoom;
            btnTimKhachHang.Dock = DockStyle.Right;
            btnTimKhachHang.Location = new Point(655, 0);
            btnTimKhachHang.Name = "btnTimKhachHang";
            btnTimKhachHang.Size = new Size(36, 26);
            btnTimKhachHang.TabIndex = 1;
            btnTimKhachHang.UseVisualStyleBackColor = true;
            btnTimKhachHang.Click += btnTimKhachHang_Click;
            // 
            // txtTimKhachHang
            // 
            txtTimKhachHang.Dock = DockStyle.Fill;
            txtTimKhachHang.Location = new Point(0, 0);
            txtTimKhachHang.Name = "txtTimKhachHang";
            txtTimKhachHang.Size = new Size(691, 23);
            txtTimKhachHang.TabIndex = 2;
            // 
            // pnChucNang
            // 
            pnChucNang.BackColor = Color.FromArgb(255, 192, 192);
            pnChucNang.Controls.Add(btnLamMoiKhachHang);
            pnChucNang.Controls.Add(btnXoaKhachHang);
            pnChucNang.Controls.Add(btnCapNhatKhachHang);
            pnChucNang.Controls.Add(btnThemKhachHang);
            pnChucNang.Dock = DockStyle.Right;
            pnChucNang.Location = new Point(691, 0);
            pnChucNang.Name = "pnChucNang";
            pnChucNang.Size = new Size(193, 385);
            pnChucNang.TabIndex = 0;
            // 
            // btnLamMoiKhachHang
            // 
            btnLamMoiKhachHang.ForeColor = Color.LightSeaGreen;
            btnLamMoiKhachHang.Image = (Image)resources.GetObject("btnLamMoiKhachHang.Image");
            btnLamMoiKhachHang.Location = new Point(121, 303);
            btnLamMoiKhachHang.Name = "btnLamMoiKhachHang";
            btnLamMoiKhachHang.Size = new Size(72, 77);
            btnLamMoiKhachHang.TabIndex = 8;
            btnLamMoiKhachHang.Text = "Làm mới";
            btnLamMoiKhachHang.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLamMoiKhachHang.UseVisualStyleBackColor = true;
            btnLamMoiKhachHang.Click += btnLamMoiKhachHang_Click;
            // 
            // btnXoaKhachHang
            // 
            btnXoaKhachHang.ForeColor = Color.LightSeaGreen;
            btnXoaKhachHang.Image = (Image)resources.GetObject("btnXoaKhachHang.Image");
            btnXoaKhachHang.Location = new Point(121, 214);
            btnXoaKhachHang.Name = "btnXoaKhachHang";
            btnXoaKhachHang.Size = new Size(63, 69);
            btnXoaKhachHang.TabIndex = 7;
            btnXoaKhachHang.Text = "Xóa";
            btnXoaKhachHang.TextImageRelation = TextImageRelation.ImageAboveText;
            btnXoaKhachHang.UseVisualStyleBackColor = true;
            btnXoaKhachHang.Click += btnXoaKhachHang_Click;
            // 
            // btnCapNhatKhachHang
            // 
            btnCapNhatKhachHang.ForeColor = Color.LightSeaGreen;
            btnCapNhatKhachHang.Image = (Image)resources.GetObject("btnCapNhatKhachHang.Image");
            btnCapNhatKhachHang.Location = new Point(3, 313);
            btnCapNhatKhachHang.Name = "btnCapNhatKhachHang";
            btnCapNhatKhachHang.Size = new Size(74, 67);
            btnCapNhatKhachHang.TabIndex = 6;
            btnCapNhatKhachHang.Text = "Cập nhật";
            btnCapNhatKhachHang.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCapNhatKhachHang.UseVisualStyleBackColor = true;
            btnCapNhatKhachHang.Click += btnCapNhatKhachHang_Click;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.ForeColor = Color.LightSeaGreen;
            btnThemKhachHang.Image = (Image)resources.GetObject("btnThemKhachHang.Image");
            btnThemKhachHang.Location = new Point(3, 214);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(77, 69);
            btnThemKhachHang.TabIndex = 0;
            btnThemKhachHang.Text = "Thêm";
            btnThemKhachHang.TextImageRelation = TextImageRelation.ImageAboveText;
            btnThemKhachHang.UseVisualStyleBackColor = true;
            btnThemKhachHang.Click += btnThemKhachHang_Click;
            // 
            // pnThongTinKhachHang
            // 
            pnThongTinKhachHang.BackColor = Color.Green;
            pnThongTinKhachHang.Controls.Add(dtpNgayGuiCanhBao);
            pnThongTinKhachHang.Controls.Add(label11);
            pnThongTinKhachHang.Controls.Add(cbMaKH);
            pnThongTinKhachHang.Controls.Add(dtpNgayTamNgung);
            pnThongTinKhachHang.Controls.Add(dtpNgayDangNhapCuoi);
            pnThongTinKhachHang.Controls.Add(label9);
            pnThongTinKhachHang.Controls.Add(label10);
            pnThongTinKhachHang.Controls.Add(txtSDTKhachHang);
            pnThongTinKhachHang.Controls.Add(label6);
            pnThongTinKhachHang.Controls.Add(panel3);
            pnThongTinKhachHang.Controls.Add(txtCCCD);
            pnThongTinKhachHang.Controls.Add(txtMatKhauKhachHang);
            pnThongTinKhachHang.Controls.Add(txtTenKH);
            pnThongTinKhachHang.Controls.Add(txtEmailKhachHang);
            pnThongTinKhachHang.Controls.Add(txtDiaChiKhachHang);
            pnThongTinKhachHang.Controls.Add(label8);
            pnThongTinKhachHang.Controls.Add(label7);
            pnThongTinKhachHang.Controls.Add(label5);
            pnThongTinKhachHang.Controls.Add(label4);
            pnThongTinKhachHang.Controls.Add(label3);
            pnThongTinKhachHang.Controls.Add(label2);
            pnThongTinKhachHang.Controls.Add(label1);
            pnThongTinKhachHang.Controls.Add(pictureAnhNV);
            pnThongTinKhachHang.Dock = DockStyle.Top;
            pnThongTinKhachHang.Location = new Point(0, 0);
            pnThongTinKhachHang.Name = "pnThongTinKhachHang";
            pnThongTinKhachHang.Size = new Size(884, 176);
            pnThongTinKhachHang.TabIndex = 2;
            // 
            // dtpNgayGuiCanhBao
            // 
            dtpNgayGuiCanhBao.Location = new Point(505, 144);
            dtpNgayGuiCanhBao.Name = "dtpNgayGuiCanhBao";
            dtpNgayGuiCanhBao.Size = new Size(143, 23);
            dtpNgayGuiCanhBao.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(505, 121);
            label11.Name = "label11";
            label11.Size = new Size(107, 15);
            label11.TabIndex = 34;
            label11.Text = "Ngày gửi cảnh báo";
            // 
            // cbMaKH
            // 
            cbMaKH.FormattingEnabled = true;
            cbMaKH.Location = new Point(102, 22);
            cbMaKH.Name = "cbMaKH";
            cbMaKH.Size = new Size(121, 23);
            cbMaKH.TabIndex = 33;
            cbMaKH.SelectedIndexChanged += cbMaKH_SelectedIndexChanged;
            // 
            // dtpNgayTamNgung
            // 
            dtpNgayTamNgung.Location = new Point(691, 144);
            dtpNgayTamNgung.Name = "dtpNgayTamNgung";
            dtpNgayTamNgung.Size = new Size(143, 23);
            dtpNgayTamNgung.TabIndex = 32;
            // 
            // dtpNgayDangNhapCuoi
            // 
            dtpNgayDangNhapCuoi.Location = new Point(339, 144);
            dtpNgayDangNhapCuoi.Name = "dtpNgayDangNhapCuoi";
            dtpNgayDangNhapCuoi.Size = new Size(115, 23);
            dtpNgayDangNhapCuoi.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(691, 121);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 28;
            label9.Text = "Ngày tạm ngưng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(339, 121);
            label10.Name = "label10";
            label10.Size = new Size(121, 15);
            label10.TabIndex = 27;
            label10.Text = "Ngày đăng nhập cuối";
            // 
            // txtSDTKhachHang
            // 
            txtSDTKhachHang.Location = new Point(248, 84);
            txtSDTKhachHang.Name = "txtSDTKhachHang";
            txtSDTKhachHang.Size = new Size(143, 23);
            txtSDTKhachHang.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 66);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 25;
            label6.Text = "Số điện thoại";
            // 
            // panel3
            // 
            panel3.Controls.Add(rbTamNgung);
            panel3.Controls.Add(rbHoatDong);
            panel3.Location = new Point(687, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(98, 90);
            panel3.TabIndex = 24;
            // 
            // rbTamNgung
            // 
            rbTamNgung.AutoSize = true;
            rbTamNgung.Location = new Point(3, 49);
            rbTamNgung.Name = "rbTamNgung";
            rbTamNgung.Size = new Size(87, 19);
            rbTamNgung.TabIndex = 1;
            rbTamNgung.TabStop = true;
            rbTamNgung.Text = "Tạm ngưng";
            rbTamNgung.UseVisualStyleBackColor = true;
            // 
            // rbHoatDong
            // 
            rbHoatDong.AutoSize = true;
            rbHoatDong.Location = new Point(12, 11);
            rbHoatDong.Name = "rbHoatDong";
            rbHoatDong.Size = new Size(82, 19);
            rbHoatDong.TabIndex = 0;
            rbHoatDong.TabStop = true;
            rbHoatDong.Text = "Hoạt động";
            rbHoatDong.UseVisualStyleBackColor = true;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(113, 147);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(115, 23);
            txtCCCD.TabIndex = 21;
            // 
            // txtMatKhauKhachHang
            // 
            txtMatKhauKhachHang.Location = new Point(416, 84);
            txtMatKhauKhachHang.Name = "txtMatKhauKhachHang";
            txtMatKhauKhachHang.Size = new Size(122, 23);
            txtMatKhauKhachHang.TabIndex = 20;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(106, 84);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(122, 23);
            txtTenKH.TabIndex = 19;
            // 
            // txtEmailKhachHang
            // 
            txtEmailKhachHang.Location = new Point(418, 22);
            txtEmailKhachHang.Name = "txtEmailKhachHang";
            txtEmailKhachHang.Size = new Size(120, 23);
            txtEmailKhachHang.TabIndex = 18;
            // 
            // txtDiaChiKhachHang
            // 
            txtDiaChiKhachHang.Location = new Point(248, 22);
            txtDiaChiKhachHang.Name = "txtDiaChiKhachHang";
            txtDiaChiKhachHang.Size = new Size(143, 23);
            txtDiaChiKhachHang.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Cyan;
            label8.Location = new Point(622, 22);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 8;
            label8.Text = "Trạng thái";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 4);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 7;
            label7.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 129);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 5;
            label5.Text = "CCCD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 66);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 4;
            label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 60);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 3;
            label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, -1);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 4);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã khách hàng";
            // 
            // pictureAnhNV
            // 
            pictureAnhNV.Dock = DockStyle.Left;
            pictureAnhNV.Image = (Image)resources.GetObject("pictureAnhNV.Image");
            pictureAnhNV.Location = new Point(0, 0);
            pictureAnhNV.Name = "pictureAnhNV";
            pictureAnhNV.Size = new Size(100, 176);
            pictureAnhNV.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAnhNV.TabIndex = 0;
            pictureAnhNV.TabStop = false;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(pnDuoi);
            Controls.Add(pnThongTinKhachHang);
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            Load += frmKhachHang_Load;
            pnDuoi.ResumeLayout(false);
            pnDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            pnTimKiemKhachHang.ResumeLayout(false);
            pnTimKiemKhachHang.PerformLayout();
            pnChucNang.ResumeLayout(false);
            pnThongTinKhachHang.ResumeLayout(false);
            pnThongTinKhachHang.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAnhNV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnDuoi;
        private TextBox txtTimKhachHang;
        private Button btnTimKhachHang;
        private DataGridView dgvKhachHang;
        private Panel pnChucNang;
        private Button btnLamMoiKhachHang;
        private Button btnXoaKhachHang;
        private Button btnCapNhatKhachHang;
        private Button btnThemKhachHang;
        private Panel pnThongTinKhachHang;
        private Panel panel3;
        private RadioButton rbTamNgung;
        private RadioButton rbHoatDong;
        private TextBox txtCCCD;
        private TextBox txtMatKhauKhachHang;
        private TextBox txtTenKH;
        private TextBox txtEmailKhachHang;
        private TextBox txtDiaChiKhachHang;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureAnhNV;
        private Label label9;
        private Label label10;
        private TextBox txtSDTKhachHang;
        private Label label6;
        private DateTimePicker dtpNgayTamNgung;
        private DateTimePicker dtpNgayDangNhapCuoi;
        private ComboBox cbMaKH;
        private Panel pnTimKiemKhachHang;
        private Panel pnDgv;
        private DateTimePicker dtpNgayGuiCanhBao;
        private Label label11;
    }
}