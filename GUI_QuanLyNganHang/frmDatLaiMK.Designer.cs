namespace GUI_QuanLyNganHang
{
    partial class frmDatLaiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatLaiMK));
            txtXacNhanMatKhau = new TextBox();
            btnHienXacNhanMK = new Button();
            btnHienMKMoi = new Button();
            label3 = new Label();
            btnThoat = new Button();
            label4 = new Label();
            btnDoiMatKhau = new Button();
            txtMatKhauMoi = new TextBox();
            pnDoiMK = new Panel();
            pnDoiMK.SuspendLayout();
            SuspendLayout();
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 12F);
            txtXacNhanMatKhau.Location = new Point(28, 156);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '#';
            txtXacNhanMatKhau.Size = new Size(224, 29);
            txtXacNhanMatKhau.TabIndex = 6;
            // 
            // btnHienXacNhanMK
            // 
            btnHienXacNhanMK.BackColor = Color.FromArgb(128, 255, 255);
            btnHienXacNhanMK.BackgroundImage = (Image)resources.GetObject("btnHienXacNhanMK.BackgroundImage");
            btnHienXacNhanMK.BackgroundImageLayout = ImageLayout.Zoom;
            btnHienXacNhanMK.Location = new Point(275, 146);
            btnHienXacNhanMK.Name = "btnHienXacNhanMK";
            btnHienXacNhanMK.Size = new Size(47, 29);
            btnHienXacNhanMK.TabIndex = 14;
            btnHienXacNhanMK.UseVisualStyleBackColor = false;
            btnHienXacNhanMK.Click += btnHienXacNhanMK_Click;
            // 
            // btnHienMKMoi
            // 
            btnHienMKMoi.BackColor = Color.FromArgb(128, 255, 255);
            btnHienMKMoi.BackgroundImage = (Image)resources.GetObject("btnHienMKMoi.BackgroundImage");
            btnHienMKMoi.BackgroundImageLayout = ImageLayout.Zoom;
            btnHienMKMoi.Location = new Point(275, 93);
            btnHienMKMoi.Name = "btnHienMKMoi";
            btnHienMKMoi.Size = new Size(47, 29);
            btnHienMKMoi.TabIndex = 11;
            btnHienMKMoi.UseVisualStyleBackColor = false;
            btnHienMKMoi.Click += btnHienMKMoi_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(41, 70);
            label3.Name = "label3";
            label3.Size = new Size(131, 19);
            label3.TabIndex = 2;
            label3.Text = "Nhập mật khẩu mới";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 15F);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(28, 282);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(221, 37);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(41, 125);
            label4.Name = "label4";
            label4.Size = new Size(154, 19);
            label4.TabIndex = 3;
            label4.Text = "Xác nhận mật khẩu mới";
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Font = new Font("Segoe UI", 15F);
            btnDoiMatKhau.ForeColor = Color.Red;
            btnDoiMatKhau.Location = new Point(41, 226);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(221, 37);
            btnDoiMatKhau.TabIndex = 12;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMatKhauMoi.Font = new Font("Segoe UI", 12F);
            txtMatKhauMoi.Location = new Point(38, 92);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '#';
            txtMatKhauMoi.Size = new Size(224, 29);
            txtMatKhauMoi.TabIndex = 5;
            // 
            // pnDoiMK
            // 
            pnDoiMK.BackColor = Color.FromArgb(255, 192, 128);
            pnDoiMK.Controls.Add(txtXacNhanMatKhau);
            pnDoiMK.Controls.Add(btnHienXacNhanMK);
            pnDoiMK.Controls.Add(btnHienMKMoi);
            pnDoiMK.Controls.Add(label3);
            pnDoiMK.Controls.Add(btnThoat);
            pnDoiMK.Controls.Add(label4);
            pnDoiMK.Controls.Add(btnDoiMatKhau);
            pnDoiMK.Controls.Add(txtMatKhauMoi);
            pnDoiMK.Dock = DockStyle.Fill;
            pnDoiMK.Location = new Point(0, 0);
            pnDoiMK.Name = "pnDoiMK";
            pnDoiMK.Size = new Size(322, 322);
            pnDoiMK.TabIndex = 17;
            // 
            // frmDatLaiMK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 322);
            Controls.Add(pnDoiMK);
            Name = "frmDatLaiMK";
            Text = "frmDatLaiMK";
            pnDoiMK.ResumeLayout(false);
            pnDoiMK.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtXacNhanMatKhau;
        private Button btnHienXacNhanMK;
        private Button btnHienMKMoi;
        private Label label3;
        private Button btnThoat;
        private Label label4;
        private Button btnDoiMatKhau;
        private TextBox txtMatKhauMoi;
        private Panel pnDoiMK;
    }
}