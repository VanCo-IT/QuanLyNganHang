namespace GUI_QuanLyNganHang
{
    partial class frmQuenMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuenMK));
            label1 = new Label();
            label2 = new Label();
            pnKhoiPhuc = new Panel();
            pnChonXacMinh = new Panel();
            btnXacMinhSMS = new Button();
            btnXacMinhDT = new Button();
            btnXacMinhEmail = new Button();
            pnKhoiPhuc.SuspendLayout();
            pnChonXacMinh.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(140, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 28);
            label1.TabIndex = 0;
            label1.Text = "Khôi phục tài khoản";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(43, 39);
            label2.Name = "label2";
            label2.Size = new Size(377, 43);
            label2.TabIndex = 1;
            label2.Text = "Để giữ an toàn cho tài khoản của bạn, chúng tôi muốn đảm bảo rằng bạn là người đang cố đăng nhập";
            // 
            // pnKhoiPhuc
            // 
            pnKhoiPhuc.Controls.Add(label1);
            pnKhoiPhuc.Controls.Add(label2);
            pnKhoiPhuc.Dock = DockStyle.Top;
            pnKhoiPhuc.Location = new Point(0, 0);
            pnKhoiPhuc.Name = "pnKhoiPhuc";
            pnKhoiPhuc.Size = new Size(505, 82);
            pnKhoiPhuc.TabIndex = 2;
            // 
            // pnChonXacMinh
            // 
            pnChonXacMinh.Controls.Add(btnXacMinhSMS);
            pnChonXacMinh.Controls.Add(btnXacMinhDT);
            pnChonXacMinh.Controls.Add(btnXacMinhEmail);
            pnChonXacMinh.Dock = DockStyle.Fill;
            pnChonXacMinh.Location = new Point(0, 82);
            pnChonXacMinh.Name = "pnChonXacMinh";
            pnChonXacMinh.Size = new Size(505, 320);
            pnChonXacMinh.TabIndex = 3;
            // 
            // btnXacMinhSMS
            // 
            btnXacMinhSMS.Dock = DockStyle.Top;
            btnXacMinhSMS.FlatStyle = FlatStyle.Flat;
            btnXacMinhSMS.Image = (Image)resources.GetObject("btnXacMinhSMS.Image");
            btnXacMinhSMS.ImageAlign = ContentAlignment.MiddleLeft;
            btnXacMinhSMS.Location = new Point(0, 133);
            btnXacMinhSMS.Name = "btnXacMinhSMS";
            btnXacMinhSMS.Size = new Size(505, 81);
            btnXacMinhSMS.TabIndex = 3;
            btnXacMinhSMS.Text = "Nhận mã xác minh";
            btnXacMinhSMS.TextAlign = ContentAlignment.MiddleRight;
            btnXacMinhSMS.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXacMinhSMS.UseVisualStyleBackColor = true;
            // 
            // btnXacMinhDT
            // 
            btnXacMinhDT.Dock = DockStyle.Top;
            btnXacMinhDT.FlatStyle = FlatStyle.Flat;
            btnXacMinhDT.Image = (Image)resources.GetObject("btnXacMinhDT.Image");
            btnXacMinhDT.ImageAlign = ContentAlignment.MiddleLeft;
            btnXacMinhDT.Location = new Point(0, 52);
            btnXacMinhDT.Name = "btnXacMinhDT";
            btnXacMinhDT.Size = new Size(505, 81);
            btnXacMinhDT.TabIndex = 2;
            btnXacMinhDT.Text = "Nhận cuộc gọi xác minh";
            btnXacMinhDT.TextAlign = ContentAlignment.MiddleRight;
            btnXacMinhDT.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXacMinhDT.UseVisualStyleBackColor = true;
            // 
            // btnXacMinhEmail
            // 
            btnXacMinhEmail.Dock = DockStyle.Top;
            btnXacMinhEmail.FlatStyle = FlatStyle.Flat;
            btnXacMinhEmail.Image = (Image)resources.GetObject("btnXacMinhEmail.Image");
            btnXacMinhEmail.ImageAlign = ContentAlignment.MiddleLeft;
            btnXacMinhEmail.Location = new Point(0, 0);
            btnXacMinhEmail.Name = "btnXacMinhEmail";
            btnXacMinhEmail.Size = new Size(505, 52);
            btnXacMinhEmail.TabIndex = 1;
            btnXacMinhEmail.Text = "Nhận mã xác minh tại *****@gmail.com";
            btnXacMinhEmail.TextAlign = ContentAlignment.MiddleRight;
            btnXacMinhEmail.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXacMinhEmail.UseVisualStyleBackColor = true;
            btnXacMinhEmail.Click += btnXacMinhEmail_Click;
            // 
            // frmQuenMK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 402);
            Controls.Add(pnChonXacMinh);
            Controls.Add(pnKhoiPhuc);
            Name = "frmQuenMK";
            Text = "frmQuenMK";
            pnKhoiPhuc.ResumeLayout(false);
            pnKhoiPhuc.PerformLayout();
            pnChonXacMinh.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel pnKhoiPhuc;
        private Panel pnChonXacMinh;
        private Button btnXacMinhDT;
        private Button btnXacMinhEmail;
        private Button btnXacMinhSMS;
    }
}