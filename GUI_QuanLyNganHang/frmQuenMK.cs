using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTIL_QuanLyNganHang;

namespace GUI_QuanLyNganHang
{
    public partial class frmQuenMK : Form
    {
        public string EmailDangQuen { get; set; }
        string maXacMinh = "";

        public frmQuenMK()
        {
            InitializeComponent();
        }

        private void btnXacMinhEmail_Click(object sender, EventArgs e)
        {
            // Tạo mã xác minh ngẫu nhiên
            Random rnd = new Random();
            maXacMinh = rnd.Next(100000, 999999).ToString();

            // Gửi email
            EmailSender emailService = new EmailSender();
            string error;
            bool result = emailService.SendVerificationCode(EmailDangQuen, maXacMinh, out error);

            if (result)
            {
                MessageBox.Show("Mã xác minh đã được gửi đến email của bạn!");
                frmNhapMa frm = new frmNhapMa();
                frm.MaDuocGui = maXacMinh;
                frm.EmailDangXacThuc = EmailDangQuen;
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Lỗi khi gửi email: {error}");
            }
        }

    }
}
