namespace GUI_QuanLyNganHang
{
    partial class frmGiaoDich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoDich));
            pnThongTinGiaoDich = new Panel();
            txtMaGD = new TextBox();
            cbSoTaiKhoan = new ComboBox();
            dtpNgayGD = new DateTimePicker();
            panel3 = new Panel();
            rbDaHuy = new RadioButton();
            rbDaThanhToan = new RadioButton();
            label8 = new Label();
            txtMoTa = new TextBox();
            txtLoaiGD = new TextBox();
            txtSoTien = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            gbChucNang = new GroupBox();
            btnLamMoiGD = new Button();
            btnThemGD = new Button();
            btnCapNhatGD = new Button();
            dgvGiaoDich = new DataGridView();
            btnXuatHoaDon = new Button();
            pnThongTinGiaoDich.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGiaoDich).BeginInit();
            SuspendLayout();
            // 
            // pnThongTinGiaoDich
            // 
            pnThongTinGiaoDich.BackColor = Color.FromArgb(255, 128, 0);
            pnThongTinGiaoDich.Controls.Add(txtMaGD);
            pnThongTinGiaoDich.Controls.Add(cbSoTaiKhoan);
            pnThongTinGiaoDich.Controls.Add(dtpNgayGD);
            pnThongTinGiaoDich.Controls.Add(panel3);
            pnThongTinGiaoDich.Controls.Add(label8);
            pnThongTinGiaoDich.Controls.Add(txtMoTa);
            pnThongTinGiaoDich.Controls.Add(txtLoaiGD);
            pnThongTinGiaoDich.Controls.Add(txtSoTien);
            pnThongTinGiaoDich.Controls.Add(label6);
            pnThongTinGiaoDich.Controls.Add(label5);
            pnThongTinGiaoDich.Controls.Add(label4);
            pnThongTinGiaoDich.Controls.Add(label3);
            pnThongTinGiaoDich.Controls.Add(label2);
            pnThongTinGiaoDich.Controls.Add(label1);
            pnThongTinGiaoDich.Controls.Add(pictureBox1);
            pnThongTinGiaoDich.Dock = DockStyle.Top;
            pnThongTinGiaoDich.Location = new Point(0, 0);
            pnThongTinGiaoDich.Name = "pnThongTinGiaoDich";
            pnThongTinGiaoDich.Size = new Size(884, 100);
            pnThongTinGiaoDich.TabIndex = 0;
            // 
            // txtMaGD
            // 
            txtMaGD.Location = new Point(131, 30);
            txtMaGD.Name = "txtMaGD";
            txtMaGD.Size = new Size(145, 23);
            txtMaGD.TabIndex = 28;
            // 
            // cbSoTaiKhoan
            // 
            cbSoTaiKhoan.FormattingEnabled = true;
            cbSoTaiKhoan.Location = new Point(316, 27);
            cbSoTaiKhoan.Name = "cbSoTaiKhoan";
            cbSoTaiKhoan.Size = new Size(145, 23);
            cbSoTaiKhoan.TabIndex = 3;
            cbSoTaiKhoan.SelectedIndexChanged += cbSoTaiKhoan_SelectedIndexChanged;
            // 
            // dtpNgayGD
            // 
            dtpNgayGD.Location = new Point(487, 27);
            dtpNgayGD.Name = "dtpNgayGD";
            dtpNgayGD.Size = new Size(200, 23);
            dtpNgayGD.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.Controls.Add(rbDaHuy);
            panel3.Controls.Add(rbDaThanhToan);
            panel3.Location = new Point(757, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(124, 74);
            panel3.TabIndex = 26;
            // 
            // rbDaHuy
            // 
            rbDaHuy.AutoSize = true;
            rbDaHuy.Location = new Point(12, 46);
            rbDaHuy.Name = "rbDaHuy";
            rbDaHuy.Size = new Size(62, 19);
            rbDaHuy.TabIndex = 1;
            rbDaHuy.TabStop = true;
            rbDaHuy.Text = "Đã hủy";
            rbDaHuy.UseVisualStyleBackColor = true;
            // 
            // rbDaThanhToan
            // 
            rbDaThanhToan.AutoSize = true;
            rbDaThanhToan.Location = new Point(12, 11);
            rbDaThanhToan.Name = "rbDaThanhToan";
            rbDaThanhToan.Size = new Size(100, 19);
            rbDaThanhToan.TabIndex = 0;
            rbDaThanhToan.TabStop = true;
            rbDaThanhToan.Text = "Đã thanh toán";
            rbDaThanhToan.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(692, 23);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 25;
            label8.Text = "Trạng thái";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(487, 71);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(145, 23);
            txtMoTa.TabIndex = 12;
            // 
            // txtLoaiGD
            // 
            txtLoaiGD.Location = new Point(316, 71);
            txtLoaiGD.Name = "txtLoaiGD";
            txtLoaiGD.Size = new Size(145, 23);
            txtLoaiGD.TabIndex = 11;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(131, 71);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(145, 23);
            txtSoTien.TabIndex = 10;
            txtSoTien.KeyPress += txtSoTien_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 53);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 6;
            label6.Text = "Mô tả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(316, 53);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 5;
            label5.Text = "Loại giao dịch ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 53);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Số tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 9);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 3;
            label3.Text = "Ngày giao dịch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 9);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Số tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã giao dịch";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // gbChucNang
            // 
            gbChucNang.BackColor = Color.FromArgb(255, 255, 128);
            gbChucNang.Controls.Add(btnXuatHoaDon);
            gbChucNang.Controls.Add(btnLamMoiGD);
            gbChucNang.Controls.Add(btnThemGD);
            gbChucNang.Controls.Add(btnCapNhatGD);
            gbChucNang.Dock = DockStyle.Right;
            gbChucNang.Location = new Point(684, 100);
            gbChucNang.Name = "gbChucNang";
            gbChucNang.Size = new Size(200, 461);
            gbChucNang.TabIndex = 1;
            gbChucNang.TabStop = false;
            gbChucNang.Text = "Các chức năng";
            // 
            // btnLamMoiGD
            // 
            btnLamMoiGD.ForeColor = Color.LightSeaGreen;
            btnLamMoiGD.Image = (Image)resources.GetObject("btnLamMoiGD.Image");
            btnLamMoiGD.Location = new Point(131, 231);
            btnLamMoiGD.Name = "btnLamMoiGD";
            btnLamMoiGD.Size = new Size(72, 95);
            btnLamMoiGD.TabIndex = 12;
            btnLamMoiGD.Text = "Làm mới";
            btnLamMoiGD.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLamMoiGD.UseVisualStyleBackColor = true;
            btnLamMoiGD.Click += btnLamMoiGD_Click;
            // 
            // btnThemGD
            // 
            btnThemGD.ForeColor = Color.LightSeaGreen;
            btnThemGD.Image = (Image)resources.GetObject("btnThemGD.Image");
            btnThemGD.Location = new Point(6, 125);
            btnThemGD.Name = "btnThemGD";
            btnThemGD.Size = new Size(77, 77);
            btnThemGD.TabIndex = 9;
            btnThemGD.Text = "Thêm";
            btnThemGD.TextImageRelation = TextImageRelation.ImageAboveText;
            btnThemGD.UseVisualStyleBackColor = true;
            btnThemGD.Click += btnThemGD_Click;
            // 
            // btnCapNhatGD
            // 
            btnCapNhatGD.ForeColor = Color.LightSeaGreen;
            btnCapNhatGD.Image = (Image)resources.GetObject("btnCapNhatGD.Image");
            btnCapNhatGD.Location = new Point(126, 125);
            btnCapNhatGD.Name = "btnCapNhatGD";
            btnCapNhatGD.Size = new Size(74, 77);
            btnCapNhatGD.TabIndex = 10;
            btnCapNhatGD.Text = "Cập nhật";
            btnCapNhatGD.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCapNhatGD.UseVisualStyleBackColor = true;
            btnCapNhatGD.Click += btnCapNhatGD_Click;
            // 
            // dgvGiaoDich
            // 
            dgvGiaoDich.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiaoDich.Dock = DockStyle.Fill;
            dgvGiaoDich.Location = new Point(0, 100);
            dgvGiaoDich.Name = "dgvGiaoDich";
            dgvGiaoDich.Size = new Size(684, 461);
            dgvGiaoDich.TabIndex = 2;
            dgvGiaoDich.CellDoubleClick += dgvGiaoDich_CellDoubleClick;
            // 
            // btnXuatHoaDon
            // 
            btnXuatHoaDon.ForeColor = Color.LightSeaGreen;
            btnXuatHoaDon.Image = (Image)resources.GetObject("btnXuatHoaDon.Image");
            btnXuatHoaDon.Location = new Point(8, 266);
            btnXuatHoaDon.Name = "btnXuatHoaDon";
            btnXuatHoaDon.Size = new Size(77, 77);
            btnXuatHoaDon.TabIndex = 13;
            btnXuatHoaDon.Text = "Xuất hóa đơn";
            btnXuatHoaDon.TextImageRelation = TextImageRelation.ImageAboveText;
            btnXuatHoaDon.UseVisualStyleBackColor = true;
            // 
            // frmGiaoDich
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(dgvGiaoDich);
            Controls.Add(gbChucNang);
            Controls.Add(pnThongTinGiaoDich);
            Name = "frmGiaoDich";
            Text = "frmGiaoDich";
            Load += frmGiaoDich_Load;
            pnThongTinGiaoDich.ResumeLayout(false);
            pnThongTinGiaoDich.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGiaoDich).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnThongTinGiaoDich;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMoTa;
        private TextBox txtLoaiGD;
        private TextBox txtSoTien;
        private GroupBox gbChucNang;
        private Button btnLamMoiGD;
        private Button btnThemGD;
        private Button btnCapNhatGD;
        private DataGridView dgvGiaoDich;
        private Panel panel3;
        private RadioButton rbDaHuy;
        private RadioButton rbDaThanhToan;
        private Label label8;
        private DateTimePicker dtpNgayGD;
        private ComboBox cbSoTaiKhoan;
        private TextBox txtMaGD;
        private Button btnXuatHoaDon;
    }
}