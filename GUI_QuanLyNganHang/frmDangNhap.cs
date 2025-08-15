using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_QuanLyNganHang;
using DTO_QuanLyNganHang;
using UTIL_QuanLyNganHang;

namespace GUI_QuanLyNganHang
{
    public partial class frmDangNhap : Form
    {
        BUSNhanVien BUSNhanVien = new BUSNhanVien();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = cbHienMK.Checked ? '\0' : '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtEmail.Text;
            string password = txtMatKhau.Text;
            NhanVien nv = BUSNhanVien.DangNhap(username, password);
            if (nv == null)
            {
                MessageBox.Show(this, "Tài khoản hoặc mật khẩu không chính xác");
            }
            else
            {
                if (nv.TrangThai == false)
                {
                    MessageBox.Show(this, "Tài khoản đang tạm khóa, vui lòng viên hệ QTV!!!");
                    return;
                }
                AuthUtil.user = nv;

                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát khỏi chương trình", "Thoát",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question
                           );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
