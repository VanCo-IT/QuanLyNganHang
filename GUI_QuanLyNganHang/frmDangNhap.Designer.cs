namespace GUI_QuanLyNganHang
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            panel1 = new Panel();
            cbHienMK = new CheckBox();
            btnThoat = new Button();
            txtEmail = new TextBox();
            btnDangNhap = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtMatKhau = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(cbHienMK);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtMatKhau);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 561);
            panel1.TabIndex = 0;
            // 
            // cbHienMK
            // 
            cbHienMK.AutoSize = true;
            cbHienMK.Location = new Point(661, 349);
            cbHienMK.Name = "cbHienMK";
            cbHienMK.Size = new Size(104, 19);
            cbHienMK.TabIndex = 26;
            cbHienMK.Text = "Hiện mật khẩu\r\n";
            cbHienMK.UseVisualStyleBackColor = true;
            cbHienMK.CheckedChanged += cbHienMK_CheckedChanged;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThoat.BackColor = Color.FromArgb(128, 255, 128);
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.Location = new Point(793, 396);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(79, 51);
            btnThoat.TabIndex = 25;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmail.Location = new Point(654, 204);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(227, 24);
            txtEmail.TabIndex = 20;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDangNhap.BackColor = Color.FromArgb(128, 255, 128);
            btnDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDangNhap.Location = new Point(654, 396);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(80, 51);
            btnDangNhap.TabIndex = 24;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(728, 179);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 18;
            label1.Text = "Email";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(654, 267);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(708, 282);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 19;
            label2.Text = "Mật khẩu";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(654, 179);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMatKhau.Location = new Point(654, 303);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(227, 29);
            txtMatKhau.TabIndex = 21;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(panel1);
            Name = "frmDangNhap";
            Text = "frmDangNhap";
            FormClosing += frmDangNhap_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnThoat;
        private TextBox txtEmail;
        private Button btnDangNhap;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtMatKhau;
        private CheckBox cbHienMK;
    }
}