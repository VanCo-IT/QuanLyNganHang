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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMatKhauCu = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtXacNhanMatkhau = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(565, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 0;
            label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(459, 97);
            label2.Name = "label2";
            label2.Size = new Size(211, 32);
            label2.TabIndex = 1;
            label2.Text = "Nhập mật khẩu cũ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(459, 250);
            label3.Name = "label3";
            label3.Size = new Size(227, 32);
            label3.TabIndex = 2;
            label3.Text = "Nhập mật khẩu mới";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(459, 383);
            label4.Name = "label4";
            label4.Size = new Size(267, 32);
            label4.TabIndex = 3;
            label4.Text = "Xác nhận mật khẩu mới";
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMatKhauCu.Font = new Font("Segoe UI", 12F);
            txtMatKhauCu.Location = new Point(459, 132);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(428, 29);
            txtMatKhauCu.TabIndex = 4;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMatKhauMoi.Font = new Font("Segoe UI", 12F);
            txtMatKhauMoi.Location = new Point(459, 285);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(428, 29);
            txtMatKhauMoi.TabIndex = 5;
            // 
            // txtXacNhanMatkhau
            // 
            txtXacNhanMatkhau.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtXacNhanMatkhau.Font = new Font("Segoe UI", 12F);
            txtXacNhanMatkhau.Location = new Point(459, 418);
            txtXacNhanMatkhau.Name = "txtXacNhanMatkhau";
            txtXacNhanMatkhau.Size = new Size(428, 29);
            txtXacNhanMatkhau.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(665, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(732, 381);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(686, 250);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 561);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(txtXacNhanMatkhau);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtMatKhauCu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDoiMatKhau";
            Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMatKhauCu;
        private TextBox txtMatKhauMoi;
        private TextBox txtXacNhanMatkhau;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}