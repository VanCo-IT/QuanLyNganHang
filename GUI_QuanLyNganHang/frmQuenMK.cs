using BLL_QuanLyNganHang;
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
            string email = EmailDangQuen?.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập email.");
                return;
            }

            BUSNhanVien busNV = new BUSNhanVien();

            // Kiểm tra email có trong danh sách nhân viên/quản lý không
            bool tonTai = busNV.KiemTraEmailTonTai(email);

            if (!tonTai)
            {
                MessageBox.Show("Email này không thuộc nhân viên hoặc quản lý trong hệ thống.");
                return;
            }

            // Nếu hợp lệ thì mới gửi email
            Random rnd = new Random();
            string maXacMinh = rnd.Next(100000, 999999).ToString();

            EmailSender emailService = new EmailSender();
            string error;
            bool result = emailService.SendVerificationCode(email, maXacMinh, out error);

            if (result)
            {
                MessageBox.Show("Mã xác minh đã được gửi đến email của bạn!");
                frmNhapMa frm = new frmNhapMa
                {
                    MaDuocGui = maXacMinh,
                    EmailDangXacThuc = email
                };
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
