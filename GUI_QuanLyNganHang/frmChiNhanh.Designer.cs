namespace GUI_QuanLyNganHang
{
    partial class frmChiNhanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiNhanh));
            pnThongTinChiNhanh = new Panel();
            cbMaCN = new ComboBox();
            txtTenChiNhanh = new TextBox();
            txtSoDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            pbChiNhanh = new PictureBox();
            pnDuLieuChiNhanh = new Panel();
            dgvChiNhanh = new DataGridView();
            pnTimChiNhanh = new Panel();
            txtTimChiNhanh = new TextBox();
            btnTimChiNhanh = new Button();
            gbChucNangChiNhanh = new GroupBox();
            btnLamMoiChiNhanh = new Button();
            btnXoaChiNhanh = new Button();
            btnCapNhatChiNhanh = new Button();
            btnThemChiNhanh = new Button();
            pnThongTinChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbChiNhanh).BeginInit();
            pnDuLieuChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiNhanh).BeginInit();
            pnTimChiNhanh.SuspendLayout();
            gbChucNangChiNhanh.SuspendLayout();
            SuspendLayout();
            // 
            // pnThongTinChiNhanh
            // 
            pnThongTinChiNhanh.BackColor = Color.Cyan;
            pnThongTinChiNhanh.Controls.Add(cbMaCN);
            pnThongTinChiNhanh.Controls.Add(txtTenChiNhanh);
            pnThongTinChiNhanh.Controls.Add(txtSoDienThoai);
            pnThongTinChiNhanh.Controls.Add(txtDiaChi);
            pnThongTinChiNhanh.Controls.Add(label1);
            pnThongTinChiNhanh.Controls.Add(label3);
            pnThongTinChiNhanh.Controls.Add(label7);
            pnThongTinChiNhanh.Controls.Add(label2);
            pnThongTinChiNhanh.Controls.Add(pbChiNhanh);
            pnThongTinChiNhanh.Dock = DockStyle.Top;
            pnThongTinChiNhanh.Location = new Point(0, 0);
            pnThongTinChiNhanh.Name = "pnThongTinChiNhanh";
            pnThongTinChiNhanh.Size = new Size(884, 140);
            pnThongTinChiNhanh.TabIndex = 0;
            // 
            // cbMaCN
            // 
            cbMaCN.FormattingEnabled = true;
            cbMaCN.Location = new Point(284, 21);
            cbMaCN.Name = "cbMaCN";
            cbMaCN.Size = new Size(143, 23);
            cbMaCN.TabIndex = 31;
            cbMaCN.SelectedIndexChanged += cbMaCN_SelectedIndexChanged;
            // 
            // txtTenChiNhanh
            // 
            txtTenChiNhanh.Location = new Point(497, 21);
            txtTenChiNhanh.Name = "txtTenChiNhanh";
            txtTenChiNhanh.Size = new Size(120, 23);
            txtTenChiNhanh.TabIndex = 30;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(497, 102);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(120, 23);
            txtSoDienThoai.TabIndex = 26;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(284, 102);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(143, 23);
            txtDiaChi.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 84);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 24;
            label1.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(497, 84);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 23;
            label3.Text = "Số điện thoại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(284, 3);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 20;
            label7.Text = "Mã chi nhánh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(497, 3);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 19;
            label2.Text = "Tên chi nhánh";
            // 
            // pbChiNhanh
            // 
            pbChiNhanh.Dock = DockStyle.Left;
            pbChiNhanh.Image = (Image)resources.GetObject("pbChiNhanh.Image");
            pbChiNhanh.Location = new Point(0, 0);
            pbChiNhanh.Name = "pbChiNhanh";
            pbChiNhanh.Size = new Size(275, 140);
            pbChiNhanh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChiNhanh.TabIndex = 0;
            pbChiNhanh.TabStop = false;
            // 
            // pnDuLieuChiNhanh
            // 
            pnDuLieuChiNhanh.Controls.Add(dgvChiNhanh);
            pnDuLieuChiNhanh.Controls.Add(pnTimChiNhanh);
            pnDuLieuChiNhanh.Controls.Add(gbChucNangChiNhanh);
            pnDuLieuChiNhanh.Dock = DockStyle.Fill;
            pnDuLieuChiNhanh.Location = new Point(0, 140);
            pnDuLieuChiNhanh.Name = "pnDuLieuChiNhanh";
            pnDuLieuChiNhanh.Size = new Size(884, 421);
            pnDuLieuChiNhanh.TabIndex = 29;
            // 
            // dgvChiNhanh
            // 
            dgvChiNhanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiNhanh.Dock = DockStyle.Fill;
            dgvChiNhanh.Location = new Point(0, 30);
            dgvChiNhanh.Name = "dgvChiNhanh";
            dgvChiNhanh.Size = new Size(645, 391);
            dgvChiNhanh.TabIndex = 3;
            // 
            // pnTimChiNhanh
            // 
            pnTimChiNhanh.BackColor = Color.FromArgb(128, 255, 128);
            pnTimChiNhanh.Controls.Add(txtTimChiNhanh);
            pnTimChiNhanh.Controls.Add(btnTimChiNhanh);
            pnTimChiNhanh.Dock = DockStyle.Top;
            pnTimChiNhanh.Location = new Point(0, 0);
            pnTimChiNhanh.Name = "pnTimChiNhanh";
            pnTimChiNhanh.Size = new Size(645, 30);
            pnTimChiNhanh.TabIndex = 2;
            // 
            // txtTimChiNhanh
            // 
            txtTimChiNhanh.Dock = DockStyle.Fill;
            txtTimChiNhanh.Location = new Point(0, 0);
            txtTimChiNhanh.Name = "txtTimChiNhanh";
            txtTimChiNhanh.Size = new Size(570, 23);
            txtTimChiNhanh.TabIndex = 1;
            // 
            // btnTimChiNhanh
            // 
            btnTimChiNhanh.BackgroundImage = (Image)resources.GetObject("btnTimChiNhanh.BackgroundImage");
            btnTimChiNhanh.BackgroundImageLayout = ImageLayout.Stretch;
            btnTimChiNhanh.Dock = DockStyle.Right;
            btnTimChiNhanh.Location = new Point(570, 0);
            btnTimChiNhanh.Name = "btnTimChiNhanh";
            btnTimChiNhanh.Size = new Size(75, 30);
            btnTimChiNhanh.TabIndex = 0;
            btnTimChiNhanh.UseVisualStyleBackColor = true;
            btnTimChiNhanh.Click += btnTimChiNhanh_Click;
            // 
            // gbChucNangChiNhanh
            // 
            gbChucNangChiNhanh.BackColor = Color.FromArgb(255, 128, 0);
            gbChucNangChiNhanh.Controls.Add(btnLamMoiChiNhanh);
            gbChucNangChiNhanh.Controls.Add(btnXoaChiNhanh);
            gbChucNangChiNhanh.Controls.Add(btnCapNhatChiNhanh);
            gbChucNangChiNhanh.Controls.Add(btnThemChiNhanh);
            gbChucNangChiNhanh.Dock = DockStyle.Right;
            gbChucNangChiNhanh.Location = new Point(645, 0);
            gbChucNangChiNhanh.Name = "gbChucNangChiNhanh";
            gbChucNangChiNhanh.Size = new Size(239, 421);
            gbChucNangChiNhanh.TabIndex = 0;
            gbChucNangChiNhanh.TabStop = false;
            gbChucNangChiNhanh.Text = "Chức năng";
            // 
            // btnLamMoiChiNhanh
            // 
            btnLamMoiChiNhanh.BackgroundImage = (Image)resources.GetObject("btnLamMoiChiNhanh.BackgroundImage");
            btnLamMoiChiNhanh.BackgroundImageLayout = ImageLayout.Stretch;
            btnLamMoiChiNhanh.Location = new Point(169, 187);
            btnLamMoiChiNhanh.Name = "btnLamMoiChiNhanh";
            btnLamMoiChiNhanh.Size = new Size(67, 64);
            btnLamMoiChiNhanh.TabIndex = 3;
            btnLamMoiChiNhanh.UseVisualStyleBackColor = true;
            btnLamMoiChiNhanh.Click += btnLamMoiChiNhanh_Click;
            // 
            // btnXoaChiNhanh
            // 
            btnXoaChiNhanh.BackgroundImage = (Image)resources.GetObject("btnXoaChiNhanh.BackgroundImage");
            btnXoaChiNhanh.BackgroundImageLayout = ImageLayout.Stretch;
            btnXoaChiNhanh.Location = new Point(6, 187);
            btnXoaChiNhanh.Name = "btnXoaChiNhanh";
            btnXoaChiNhanh.Size = new Size(86, 64);
            btnXoaChiNhanh.TabIndex = 2;
            btnXoaChiNhanh.UseVisualStyleBackColor = true;
            btnXoaChiNhanh.Click += btnXoaChiNhanh_Click;
            // 
            // btnCapNhatChiNhanh
            // 
            btnCapNhatChiNhanh.BackgroundImage = (Image)resources.GetObject("btnCapNhatChiNhanh.BackgroundImage");
            btnCapNhatChiNhanh.BackgroundImageLayout = ImageLayout.Center;
            btnCapNhatChiNhanh.Location = new Point(146, 102);
            btnCapNhatChiNhanh.Name = "btnCapNhatChiNhanh";
            btnCapNhatChiNhanh.Size = new Size(81, 53);
            btnCapNhatChiNhanh.TabIndex = 1;
            btnCapNhatChiNhanh.UseVisualStyleBackColor = true;
            btnCapNhatChiNhanh.Click += btnCapNhatChiNhanh_Click;
            // 
            // btnThemChiNhanh
            // 
            btnThemChiNhanh.BackgroundImage = (Image)resources.GetObject("btnThemChiNhanh.BackgroundImage");
            btnThemChiNhanh.BackgroundImageLayout = ImageLayout.Stretch;
            btnThemChiNhanh.Location = new Point(6, 102);
            btnThemChiNhanh.Name = "btnThemChiNhanh";
            btnThemChiNhanh.Size = new Size(86, 53);
            btnThemChiNhanh.TabIndex = 0;
            btnThemChiNhanh.UseVisualStyleBackColor = true;
            btnThemChiNhanh.Click += btnThemChiNhanh_Click;
            // 
            // frmChiNhanh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(pnDuLieuChiNhanh);
            Controls.Add(pnThongTinChiNhanh);
            Name = "frmChiNhanh";
            Text = "frmChiNhanh";
            Load += frmChiNhanh_Load;
            pnThongTinChiNhanh.ResumeLayout(false);
            pnThongTinChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbChiNhanh).EndInit();
            pnDuLieuChiNhanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiNhanh).EndInit();
            pnTimChiNhanh.ResumeLayout(false);
            pnTimChiNhanh.PerformLayout();
            gbChucNangChiNhanh.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnThongTinChiNhanh;
        private PictureBox pbChiNhanh;
        private TextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private Label label1;
        private Label label3;
        private Label label7;
        private Label label2;
        private Panel pnDuLieuChiNhanh;
        private GroupBox gbChucNangChiNhanh;
        private Button btnLamMoiChiNhanh;
        private Button btnXoaChiNhanh;
        private Button btnCapNhatChiNhanh;
        private Button btnThemChiNhanh;
        private TextBox txtTenChiNhanh;
        private DataGridView dgvChiNhanh;
        private Panel pnTimChiNhanh;
        private Button btnTimChiNhanh;
        private TextBox txtTimChiNhanh;
        private ComboBox cbMaCN;
    }
}