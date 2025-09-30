namespace GUI_QuanLyNganHang
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMatKhauCu = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtXacNhanMatkhau = new TextBox();
            btnHienMKMoi = new Button();
            btnDoiMatKhau = new Button();
            btnThoat = new Button();
            btnHienXacNhanMK = new Button();
            btnHienMKCu = new Button();
            pnDoiMK = new Panel();
            pnDoiMK.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(11, 11);
            label2.Name = "label2";
            label2.Size = new Size(122, 19);
            label2.TabIndex = 1;
            label2.Text = "Nhập mật khẩu cũ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(11, 73);
            label3.Name = "label3";
            label3.Size = new Size(131, 19);
            label3.TabIndex = 2;
            label3.Text = "Nhập mật khẩu mới";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(11, 128);
            label4.Name = "label4";
            label4.Size = new Size(154, 19);
            label4.TabIndex = 3;
            label4.Text = "Xác nhận mật khẩu mới";
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMatKhauCu.Font = new Font("Segoe UI", 12F);
            txtMatKhauCu.Location = new Point(11, 33);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.PasswordChar = '*';
            txtMatKhauCu.Size = new Size(221, 29);
            txtMatKhauCu.TabIndex = 4;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMatKhauMoi.Font = new Font("Segoe UI", 12F);
            txtMatKhauMoi.Location = new Point(8, 95);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '#';
            txtMatKhauMoi.Size = new Size(224, 29);
            txtMatKhauMoi.TabIndex = 5;
            // 
            // txtXacNhanMatkhau
            // 
            txtXacNhanMatkhau.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtXacNhanMatkhau.Font = new Font("Segoe UI", 12F);
            txtXacNhanMatkhau.Location = new Point(8, 150);
            txtXacNhanMatkhau.Name = "txtXacNhanMatkhau";
            txtXacNhanMatkhau.PasswordChar = '#';
            txtXacNhanMatkhau.Size = new Size(224, 29);
            txtXacNhanMatkhau.TabIndex = 6;
            // 
            // btnHienMKMoi
            // 
            btnHienMKMoi.BackColor = Color.FromArgb(128, 255, 255);
            btnHienMKMoi.BackgroundImage = (Image)resources.GetObject("btnHienMKMoi.BackgroundImage");
            btnHienMKMoi.BackgroundImageLayout = ImageLayout.Zoom;
            btnHienMKMoi.Location = new Point(238, 95);
            btnHienMKMoi.Name = "btnHienMKMoi";
            btnHienMKMoi.Size = new Size(47, 29);
            btnHienMKMoi.TabIndex = 11;
            btnHienMKMoi.UseVisualStyleBackColor = false;
            btnHienMKMoi.Click += btnHienMKMoi_Click;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Font = new Font("Segoe UI", 15F);
            btnDoiMatKhau.ForeColor = Color.Red;
            btnDoiMatKhau.Location = new Point(3, 217);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(221, 37);
            btnDoiMatKhau.TabIndex = 12;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 15F);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(3, 272);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(221, 37);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHienXacNhanMK
            // 
            btnHienXacNhanMK.BackColor = Color.FromArgb(128, 255, 255);
            btnHienXacNhanMK.BackgroundImage = (Image)resources.GetObject("btnHienXacNhanMK.BackgroundImage");
            btnHienXacNhanMK.BackgroundImageLayout = ImageLayout.Zoom;
            btnHienXacNhanMK.Location = new Point(238, 150);
            btnHienXacNhanMK.Name = "btnHienXacNhanMK";
            btnHienXacNhanMK.Size = new Size(47, 29);
            btnHienXacNhanMK.TabIndex = 14;
            btnHienXacNhanMK.UseVisualStyleBackColor = false;
            btnHienXacNhanMK.Click += btnHienXacNhanMK_Click;
            // 
            // btnHienMKCu
            // 
            btnHienMKCu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHienMKCu.BackColor = Color.FromArgb(128, 255, 255);
            btnHienMKCu.BackgroundImage = (Image)resources.GetObject("btnHienMKCu.BackgroundImage");
            btnHienMKCu.BackgroundImageLayout = ImageLayout.Zoom;
            btnHienMKCu.Location = new Point(238, 34);
            btnHienMKCu.Name = "btnHienMKCu";
            btnHienMKCu.Size = new Size(47, 29);
            btnHienMKCu.TabIndex = 15;
            btnHienMKCu.UseVisualStyleBackColor = false;
            btnHienMKCu.Click += btnHienMKCu_Click;
            // 
            // pnDoiMK
            // 
            pnDoiMK.BackColor = Color.FromArgb(255, 192, 128);
            pnDoiMK.Controls.Add(txtXacNhanMatkhau);
            pnDoiMK.Controls.Add(btnHienXacNhanMK);
            pnDoiMK.Controls.Add(btnHienMKCu);
            pnDoiMK.Controls.Add(btnHienMKMoi);
            pnDoiMK.Controls.Add(label2);
            pnDoiMK.Controls.Add(label3);
            pnDoiMK.Controls.Add(btnThoat);
            pnDoiMK.Controls.Add(label4);
            pnDoiMK.Controls.Add(btnDoiMatKhau);
            pnDoiMK.Controls.Add(txtMatKhauCu);
            pnDoiMK.Controls.Add(txtMatKhauMoi);
            pnDoiMK.Dock = DockStyle.Fill;
            pnDoiMK.Location = new Point(0, 0);
            pnDoiMK.Name = "pnDoiMK";
            pnDoiMK.Size = new Size(322, 322);
            pnDoiMK.TabIndex = 16;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(322, 322);
            Controls.Add(pnDoiMK);
            Name = "frmDoiMatKhau";
            Text = "Đổi mật khẩu";
            Load += frmDoiMatKhau_Load;
            pnDoiMK.ResumeLayout(false);
            pnDoiMK.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMatKhauCu;
        private TextBox txtMatKhauMoi;
        private TextBox txtXacNhanMatkhau;
        private Button btnHienMKMoi;
        private Button btnDoiMatKhau;
        private Button btnThoat;
        private Button btnHienXacNhanMK;
        private Button btnHienMKCu;
        private Panel pnDoiMK;
    }
}