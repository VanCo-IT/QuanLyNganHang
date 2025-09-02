using BLL_QuanLyNganHang;
using DTO_QuanLyNganHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLyNganHang
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private BUSNhanVien bUSnhanvien = new BUSNhanVien();

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachNhanVien();

        }
        private void LoadDanhSachNhanVien()
        {
            BUSNhanVien bUSNhanVien = new BUSNhanVien();
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = bUSNhanVien.GetNhanVienList();
        }
        private void ClearForm()
        {
            btnThemNV.Enabled = true;
            btnCapNhatNV.Enabled = false;
            btnXoaNV.Enabled = true;
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtSDT.Clear();
            txtTenDangNhap.Clear();
            rbQuanLy.Checked = false;
            rbNhanVien.Checked = false;
            rbHoatDong.Checked = false;
            rbTamNgung.Checked = false;
        }
        private void btnTimNV_Click(object sender, EventArgs e)
        {
            string maNV = txtTimNV.Text.Trim();

            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần tìm!");
                return;
            }

            var list = bUSnhanvien.GetNhanVienList();

            var ketQua = list.Where(nv => nv.MaNV != null && nv.MaNV.Trim().Equals(maNV, StringComparison.OrdinalIgnoreCase)).ToList();

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên có mã: " + maNV);
            }

            dgvNhanVien.DataSource = ketQua;
        }

        private void dgvNhanVien_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            // Đổ dữ liệu vào các ô nhập liệu trên form
            txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
            txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            txtSDT.Text = row.Cells["SDT"].Value.ToString();
            txtTenDangNhap.Text = row.Cells["TenDN"].Value.ToString();

            bool vaiTro = Convert.ToBoolean(row.Cells["VaiTro"].Value);
            if (vaiTro == false)
            {
                rbNhanVien.Checked = true;
            }
            else
            {
                rbQuanLy.Checked = true;
            }

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai == false)
            {
                rbTamNgung.Checked = true;
            }
            else
            {
                rbHoatDong.Checked = true;
            }

            // Bật nút "Sửa"
            btnThemNV.Enabled = false;
            btnCapNhatNV.Enabled = true;
            btnXoaNV.Enabled = true;
            // Tắt chỉnh sửa mã nhân viên
            txtMaNV.Enabled = false;
        }

        private void btnThemNV_Click_1(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            bool vaiTro;

            if (rbNhanVien.Checked)
            {
                vaiTro = true;
            }
            else
            {
                vaiTro = false;
            }
            bool trangThai;

            if (rbHoatDong.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }
            NhanVien nv = new NhanVien
            {
                MaNV = maNV,
                TenNV = tenNV,
                Email = email,
                MatKhau = matKhau,
                SDT = sdt,
                TenDN = tenDangNhap,
                VaiTro = vaiTro,
                TrangThai = trangThai
            };
            BUSNhanVien bus = new BUSNhanVien();
            string result = bus.InsertNhanVien(nv);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Thêm nhân viên thành công");
                ClearForm();
                LoadDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show(result);
            }

        }

        private void btnCapNhatNV_Click_1(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            bool vaiTro;

            if (rbQuanLy.Checked)
            {
                vaiTro = true;
            }
            else
            {
                vaiTro = false;
            }
            bool trangThai;

            if (rbHoatDong.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }
            NhanVien nv = new NhanVien
            {
                MaNV = maNV,
                TenNV = tenNV,
                Email = email,
                MatKhau = matKhau,
                TenDN = tenDangNhap,
                SDT = sdt,
                VaiTro = vaiTro,
                TrangThai = trangThai
            };
            BUSNhanVien bus = new BUSNhanVien();
            string result = bus.UpdateNhanVien(nv);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnXoaNV_Click_1(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            if (string.IsNullOrEmpty(maNV))
            {
                if (dgvNhanVien.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];
                    maNV = selectedRow.Cells["MaNhanVien"].Value.ToString();
                    tenNV = selectedRow.Cells["HoTen"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {maNV} - {tenNV}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUSNhanVien bus = new BUSNhanVien();
                string kq = bus.DeleteNhanVien(maNV);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin nhân viên {maNV} - {tenNV} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnLamMoiNV_Click_1(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachNhanVien();
        }
    }
}