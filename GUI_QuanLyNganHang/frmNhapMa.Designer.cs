namespace GUI_QuanLyNganHang
{
    partial class frmNhapMa
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
            label1 = new Label();
            txtMaXacMinh = new TextBox();
            btnXacNhan = new Button();
            btnQuayLai = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(272, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập mã xác minh đã được gửi vào email của bạn";
            // 
            // txtMaXacMinh
            // 
            txtMaXacMinh.Dock = DockStyle.Top;
            txtMaXacMinh.Location = new Point(0, 15);
            txtMaXacMinh.Name = "txtMaXacMinh";
            txtMaXacMinh.Size = new Size(275, 23);
            txtMaXacMinh.TabIndex = 1;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(25, 139);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(75, 23);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(149, 140);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(75, 23);
            btnQuayLai.TabIndex = 3;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // frmNhapMa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 175);
            Controls.Add(btnQuayLai);
            Controls.Add(btnXacNhan);
            Controls.Add(txtMaXacMinh);
            Controls.Add(label1);
            Name = "frmNhapMa";
            Text = "frmNhapMa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaXacMinh;
        private Button btnXacNhan;
        private Button btnQuayLai;
    }
}