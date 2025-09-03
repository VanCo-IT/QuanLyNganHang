namespace GUI_QuanLyNganHang
{
    partial class frmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            txtSoDu = new TextBox();
            txtLoaiTaiKhoan = new TextBox();
            txtSoTaiKhoan = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureAnhNV = new PictureBox();
            pnThongTinKhachHang = new Panel();
            cbMaKH = new ComboBox();
            dtpNgayMo = new DateTimePicker();
            pnCSDL = new Panel();
            dgvTaiKhoan = new DataGridView();
            pnTimTaiKhoan = new Panel();
            btnTimTaiKhoan = new Button();
            txtTimTaiKhoan = new TextBox();
            gbChucNang = new GroupBox();
            btnLamMoiTaiKhoan = new Button();
            btnXoaTaiKhoan = new Button();
            btnCapNhatTaiKhoan = new Button();
            btnThemTaiKhoan = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureAnhNV).BeginInit();
            pnThongTinKhachHang.SuspendLayout();
            pnCSDL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            pnTimTaiKhoan.SuspendLayout();
            gbChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // txtSoDu
            // 
            txtSoDu.Location = new Point(394, 31);
            txtSoDu.Name = "txtSoDu";
            txtSoDu.Size = new Size(115, 23);
            txtSoDu.TabIndex = 21;
            txtSoDu.KeyPress += txtSoDu_KeyPress;
            // 
            // txtLoaiTaiKhoan
            // 
            txtLoaiTaiKhoan.Location = new Point(103, 102);
            txtLoaiTaiKhoan.Name = "txtLoaiTaiKhoan";
            txtLoaiTaiKhoan.Size = new Size(120, 23);
            txtLoaiTaiKhoan.TabIndex = 18;
            // 
            // txtSoTaiKhoan
            // 
            txtSoTaiKhoan.Location = new Point(247, 31);
            txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            txtSoTaiKhoan.Size = new Size(118, 23);
            txtSoTaiKhoan.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(394, 13);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 5;
            label5.Text = "Số dư";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 84);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 4;
            label4.Text = "Ngày mở";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 13);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "Mã KH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 79);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "Loại tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 13);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Số tài khoản";
            // 
            // pictureAnhNV
            // 
            pictureAnhNV.Dock = DockStyle.Left;
            pictureAnhNV.Image = (Image)resources.GetObject("pictureAnhNV.Image");
            pictureAnhNV.Location = new Point(0, 0);
            pictureAnhNV.Name = "pictureAnhNV";
            pictureAnhNV.Size = new Size(100, 174);
            pictureAnhNV.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAnhNV.TabIndex = 0;
            pictureAnhNV.TabStop = false;
            // 
            // pnThongTinKhachHang
            // 
            pnThongTinKhachHang.BackColor = Color.Green;
            pnThongTinKhachHang.Controls.Add(cbMaKH);
            pnThongTinKhachHang.Controls.Add(dtpNgayMo);
            pnThongTinKhachHang.Controls.Add(txtSoDu);
            pnThongTinKhachHang.Controls.Add(txtLoaiTaiKhoan);
            pnThongTinKhachHang.Controls.Add(txtSoTaiKhoan);
            pnThongTinKhachHang.Controls.Add(label5);
            pnThongTinKhachHang.Controls.Add(label4);
            pnThongTinKhachHang.Controls.Add(label3);
            pnThongTinKhachHang.Controls.Add(label2);
            pnThongTinKhachHang.Controls.Add(label1);
            pnThongTinKhachHang.Controls.Add(pictureAnhNV);
            pnThongTinKhachHang.Dock = DockStyle.Top;
            pnThongTinKhachHang.Location = new Point(0, 0);
            pnThongTinKhachHang.Name = "pnThongTinKhachHang";
            pnThongTinKhachHang.Size = new Size(884, 174);
            pnThongTinKhachHang.TabIndex = 4;
            // 
            // cbMaKH
            // 
            cbMaKH.FormattingEnabled = true;
            cbMaKH.Location = new Point(106, 31);
            cbMaKH.Name = "cbMaKH";
            cbMaKH.Size = new Size(121, 23);
            cbMaKH.TabIndex = 23;
            cbMaKH.SelectedIndexChanged += cbMaKH_SelectedIndexChanged_1;
            // 
            // dtpNgayMo
            // 
            dtpNgayMo.Location = new Point(247, 102);
            dtpNgayMo.Name = "dtpNgayMo";
            dtpNgayMo.Size = new Size(200, 23);
            dtpNgayMo.TabIndex = 22;
            // 
            // pnCSDL
            // 
            pnCSDL.Controls.Add(dgvTaiKhoan);
            pnCSDL.Controls.Add(pnTimTaiKhoan);
            pnCSDL.Controls.Add(gbChucNang);
            pnCSDL.Dock = DockStyle.Fill;
            pnCSDL.Location = new Point(0, 174);
            pnCSDL.Name = "pnCSDL";
            pnCSDL.Size = new Size(884, 387);
            pnCSDL.TabIndex = 5;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(0, 26);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.Size = new Size(684, 361);
            dgvTaiKhoan.TabIndex = 2;
            dgvTaiKhoan.CellDoubleClick += dgvTaiKhoan_CellDoubleClick;
            // 
            // pnTimTaiKhoan
            // 
            pnTimTaiKhoan.Controls.Add(btnTimTaiKhoan);
            pnTimTaiKhoan.Controls.Add(txtTimTaiKhoan);
            pnTimTaiKhoan.Dock = DockStyle.Top;
            pnTimTaiKhoan.Location = new Point(0, 0);
            pnTimTaiKhoan.Name = "pnTimTaiKhoan";
            pnTimTaiKhoan.Size = new Size(684, 26);
            pnTimTaiKhoan.TabIndex = 1;
            // 
            // btnTimTaiKhoan
            // 
            btnTimTaiKhoan.BackgroundImage = (Image)resources.GetObject("btnTimTaiKhoan.BackgroundImage");
            btnTimTaiKhoan.BackgroundImageLayout = ImageLayout.Stretch;
            btnTimTaiKhoan.Dock = DockStyle.Right;
            btnTimTaiKhoan.Location = new Point(636, 0);
            btnTimTaiKhoan.Name = "btnTimTaiKhoan";
            btnTimTaiKhoan.Size = new Size(48, 26);
            btnTimTaiKhoan.TabIndex = 1;
            btnTimTaiKhoan.UseVisualStyleBackColor = true;
            btnTimTaiKhoan.Click += btnTimTaiKhoan_Click;
            // 
            // txtTimTaiKhoan
            // 
            txtTimTaiKhoan.Dock = DockStyle.Left;
            txtTimTaiKhoan.Location = new Point(0, 0);
            txtTimTaiKhoan.Name = "txtTimTaiKhoan";
            txtTimTaiKhoan.Size = new Size(630, 23);
            txtTimTaiKhoan.TabIndex = 0;
            txtTimTaiKhoan.Enter += txtTimTaiKhoan_Enter;
            txtTimTaiKhoan.Leave += txtTimTaiKhoan_Leave;
            // 
            // gbChucNang
            // 
            gbChucNang.BackColor = Color.FromArgb(255, 255, 128);
            gbChucNang.Controls.Add(btnLamMoiTaiKhoan);
            gbChucNang.Controls.Add(btnXoaTaiKhoan);
            gbChucNang.Controls.Add(btnCapNhatTaiKhoan);
            gbChucNang.Controls.Add(btnThemTaiKhoan);
            gbChucNang.Dock = DockStyle.Right;
            gbChucNang.Location = new Point(684, 0);
            gbChucNang.Name = "gbChucNang";
            gbChucNang.Size = new Size(200, 387);
            gbChucNang.TabIndex = 0;
            gbChucNang.TabStop = false;
            gbChucNang.Text = "Chức năng";
            // 
            // btnLamMoiTaiKhoan
            // 
            btnLamMoiTaiKhoan.ForeColor = Color.LightSeaGreen;
            btnLamMoiTaiKhoan.Image = (Image)resources.GetObject("btnLamMoiTaiKhoan.Image");
            btnLamMoiTaiKhoan.Location = new Point(124, 196);
            btnLamMoiTaiKhoan.Name = "btnLamMoiTaiKhoan";
            btnLamMoiTaiKhoan.Size = new Size(72, 77);
            btnLamMoiTaiKhoan.TabIndex = 12;
            btnLamMoiTaiKhoan.Text = "Làm mới";
            btnLamMoiTaiKhoan.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLamMoiTaiKhoan.UseVisualStyleBackColor = true;
            btnLamMoiTaiKhoan.Click += btnLamMoiTaiKhoan_Click;
            // 
            // btnXoaTaiKhoan
            // 
            btnXoaTaiKhoan.ForeColor = Color.LightSeaGreen;
            btnXoaTaiKhoan.Image = (Image)resources.GetObject("btnXoaTaiKhoan.Image");
            btnXoaTaiKhoan.Location = new Point(124, 107);
            btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            btnXoaTaiKhoan.Size = new Size(63, 69);
            btnXoaTaiKhoan.TabIndex = 11;
            btnXoaTaiKhoan.Text = "Xóa";
            btnXoaTaiKhoan.TextImageRelation = TextImageRelation.ImageAboveText;
            btnXoaTaiKhoan.UseVisualStyleBackColor = true;
            btnXoaTaiKhoan.Click += btnXoaTaiKhoan_Click;
            // 
            // btnCapNhatTaiKhoan
            // 
            btnCapNhatTaiKhoan.ForeColor = Color.LightSeaGreen;
            btnCapNhatTaiKhoan.Image = (Image)resources.GetObject("btnCapNhatTaiKhoan.Image");
            btnCapNhatTaiKhoan.Location = new Point(6, 206);
            btnCapNhatTaiKhoan.Name = "btnCapNhatTaiKhoan";
            btnCapNhatTaiKhoan.Size = new Size(74, 67);
            btnCapNhatTaiKhoan.TabIndex = 10;
            btnCapNhatTaiKhoan.Text = "Cập nhật";
            btnCapNhatTaiKhoan.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCapNhatTaiKhoan.UseVisualStyleBackColor = true;
            btnCapNhatTaiKhoan.Click += btnCapNhatTaiKhoan_Click;
            // 
            // btnThemTaiKhoan
            // 
            btnThemTaiKhoan.ForeColor = Color.LightSeaGreen;
            btnThemTaiKhoan.Image = (Image)resources.GetObject("btnThemTaiKhoan.Image");
            btnThemTaiKhoan.Location = new Point(6, 107);
            btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            btnThemTaiKhoan.Size = new Size(77, 69);
            btnThemTaiKhoan.TabIndex = 9;
            btnThemTaiKhoan.Text = "Thêm";
            btnThemTaiKhoan.TextImageRelation = TextImageRelation.ImageAboveText;
            btnThemTaiKhoan.UseVisualStyleBackColor = true;
            btnThemTaiKhoan.Click += btnThemTaiKhoan_Click;
            // 
            // frmTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(pnCSDL);
            Controls.Add(pnThongTinKhachHang);
            Name = "frmTaiKhoan";
            Text = "frmTaiKhoan";
            Load += frmTaiKhoan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureAnhNV).EndInit();
            pnThongTinKhachHang.ResumeLayout(false);
            pnThongTinKhachHang.PerformLayout();
            pnCSDL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            pnTimTaiKhoan.ResumeLayout(false);
            pnTimTaiKhoan.PerformLayout();
            gbChucNang.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtSoDu;
        private TextBox txtLoaiTaiKhoan;
        private TextBox txtSoTaiKhoan;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureAnhNV;
        private Panel pnThongTinKhachHang;
        private DateTimePicker dtpNgayMo;
        private Panel pnCSDL;
        private GroupBox gbChucNang;
        private Button btnLamMoiTaiKhoan;
        private Button btnXoaTaiKhoan;
        private Button btnCapNhatTaiKhoan;
        private Button btnThemTaiKhoan;
        private Panel pnTimTaiKhoan;
        private Button btnTimTaiKhoan;
        private TextBox txtTimTaiKhoan;
        private DataGridView dgvTaiKhoan;
        private ComboBox cbMaKH;
    }
}