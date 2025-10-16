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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI_QuanLyNganHang
{
    public partial class frmDatLaiMK : Form
    {
        private string _email;
        public frmDatLaiMK(string email)
        {
            InitializeComponent();
            _email = email;
        }

        private void btnHienMKMoi_Click(object sender, EventArgs e)
        {
            txtMatKhauMoi.PasswordChar = (txtMatKhauMoi.PasswordChar == '#') ? '\0' : '#';
        }

        private void btnHienXacNhanMK_Click(object sender, EventArgs e)
        {
            txtXacNhanMatKhau.PasswordChar = (txtXacNhanMatKhau.PasswordChar == '#') ? '\0' : '#';
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string xacNhan = txtXacNhanMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(matKhauMoi) || string.IsNullOrWhiteSpace(xacNhan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (matKhauMoi != xacNhan)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
                return;
            }

            BUSNhanVien bus = new BUSNhanVien();
            bool result = bus.ResetMatKhau(_email, matKhauMoi);

            if (result)
            {
                MessageBox.Show("Đặt lại mật khẩu thành công!");
                this.Close(); // hoặc mở frmLogin
            }
            else
            {
                MessageBox.Show("Thất bại! Không thể cập nhật mật khẩu.");
            }
        }
    }
}
