using BLL_QuanLyNganHang;
using DAL_QuanLyNganHang;
using DTO_QuanLyNganHang;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmKhachHang : Form
    {
        private BUSKhachHang bUSKhachHang = new BUSKhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            ClearForm();
            //LoadTaiKhoan();
            LoadDanhSachKhachHang();
            LoadMaKhachHangVaoComboBox();


        }
        private void ClearForm()
        {
            cbMaKH.SelectedIndex = -1; /// tránh va chạm với hiện makh từ combobox
            txtTenKH.Clear();
            txtEmailKhachHang.Clear();
            txtMatKhauKhachHang.Clear();
            txtCCCD.Clear();
            txtDiaChiKhachHang.Clear();
            txtSDTKhachHang.Clear();
            rbHoatDong.Checked = false;
            rbTamNgung.Checked = false;
            dtpNgayDangNhapCuoi.Value = DateTime.Now;
            dtpNgayTamNgung.Value = DateTime.Now;
        }
        private void LoadDanhSachKhachHang()
        {
            try
            {
                BUSKhachHang busKhachHang = new BUSKhachHang();
                List<KhachHang> dsKhachHang = busKhachHang.GetKhachHangList();
                dgvKhachHang.DataSource = busKhachHang.GetKhachHangList();

                // Optional: Tùy chỉnh cột hiển thị nếu muốn
                //dgvKhachHang.Columns["MatKhau"].Visible = false; // Ẩn mật khẩu nếu không cần hiển thị
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách khách hàng: " + ex.Message);
            }


        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            cbMaKH.SelectedValue = row.Cells["MaKH"].Value?.ToString();
            txtTenKH.Text = row.Cells["TenKH"].Value?.ToString();
            txtCCCD.Text = row.Cells["CCCD"].Value?.ToString();
            txtDiaChiKhachHang.Text = row.Cells["DiaChi"].Value?.ToString();
            txtSDTKhachHang.Text = row.Cells["SDT"].Value?.ToString();
            txtEmailKhachHang.Text = row.Cells["Email"].Value?.ToString();
            txtMatKhauKhachHang.Text = row.Cells["MatKhau"].Value?.ToString();

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            rbHoatDong.Checked = trangThai;
            rbTamNgung.Checked = !trangThai;

            // Ngày đăng nhập cuối
            object cellNgayCuoi = row.Cells["NgayDangNhapCuoi"].Value;
            if (cellNgayCuoi != null && cellNgayCuoi != DBNull.Value)
            {
                DateTime ngay = Convert.ToDateTime(cellNgayCuoi);
                dtpNgayDangNhapCuoi.Value = (ngay > dtpNgayDangNhapCuoi.MinDate) ? ngay : DateTime.Now;
            }
            else
            {
                dtpNgayDangNhapCuoi.Value = DateTime.Now;
            }

            // Ngày gửi cảnh báo
            object cellCanhBao = row.Cells["NgayGuiCanhBao"].Value;
            if (cellCanhBao != null && cellCanhBao != DBNull.Value)
            {
                DateTime ngay = Convert.ToDateTime(cellCanhBao);
                dtpNgayGuiCanhBao.Value = (ngay > dtpNgayGuiCanhBao.MinDate) ? ngay : DateTime.Now;
            }
            else
            {
                dtpNgayGuiCanhBao.Value = DateTime.Now;
            }

            // Ngày tạm ngưng
            object cellTamNgung = row.Cells["NgayTamNgung"].Value;
            if (cellTamNgung != null && cellTamNgung != DBNull.Value)
            {
                DateTime ngay = Convert.ToDateTime(cellTamNgung);
                dtpNgayTamNgung.Value = (ngay > dtpNgayTamNgung.MinDate) ? ngay : DateTime.Now;
            }
            else
            {
                dtpNgayTamNgung.Value = DateTime.Now;
            }
        }

        private void LoadMaKhachHangVaoComboBox()
        {
            try
            {
                BUSKhachHang busKhachHang = new BUSKhachHang();
                List<string> danhSachMaKH = busKhachHang.GetAllMaKH();

                cbMaKH.DataSource = danhSachMaKH;
                cbMaKH.DropDownStyle = ComboBoxStyle.DropDownList; // Không cho nhập tay
                cbMaKH.SelectedIndex = -1; // Không chọn sẵn
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải mã khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code khi ấn vào cbMaKH sẽ hiện thông tin để sửa 

            // Kiểm tra nếu có chọn giá trị nào
            if (cbMaKH.SelectedIndex == -1)
            {
                ClearForm();
                return;
            }

            // Lấy mã khách hàng được chọn
            string selectedMaKH = cbMaKH.SelectedValue.ToString();

            // Tìm đối tượng KhachHang tương ứng trong danh sách
            BUSKhachHang bus = new BUSKhachHang();
            List<KhachHang> dsKhachHang = bus.GetKhachHangList();

            KhachHang kh = dsKhachHang.FirstOrDefault(x => x.MaKH == selectedMaKH);

            if (kh != null)
            {
                // Hiển thị thông tin khách hàng lên form
                txtTenKH.Text = kh.TenKH;
                txtCCCD.Text = kh.CCCD;
                txtDiaChiKhachHang.Text = kh.DiaChi;
                txtSDTKhachHang.Text = kh.SDT;
                txtEmailKhachHang.Text = kh.Email;
                txtMatKhauKhachHang.Text = kh.MatKhau;

                // Giả sử true = Hoạt động, false = Tạm ngưng
                rbHoatDong.Checked = kh.TrangThai;
                rbTamNgung.Checked = !kh.TrangThai;
                // Set giá trị DateTimePicker (kiểm tra null hoặc ngày hợp lệ)
                dtpNgayDangNhapCuoi.Value = kh.NgayDangNhapCuoi ?? DateTime.Now;
                dtpNgayGuiCanhBao.Value = kh.NgayGuiCanhBao ?? DateTime.Now;
                dtpNgayTamNgung.Value = kh.NgayTamNgung ?? DateTime.Now;
            }
            else
            {
                ClearForm();
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = cbMaKH.SelectedValue?.ToString();
                string tenKH = txtTenKH.Text.Trim();
                string cccd = txtCCCD.Text.Trim();
                string diaChi = txtDiaChiKhachHang.Text.Trim();
                string sdt = txtSDTKhachHang.Text.Trim();
                string email = txtEmailKhachHang.Text.Trim();
                string matKhau = txtMatKhauKhachHang.Text.Trim();
                bool trangThai = rbHoatDong.Checked;
                DateTime ngayDangNhapCuoi = dtpNgayDangNhapCuoi.Value;
                DateTime ngayGuiCanhBao = dtpNgayGuiCanhBao.Value;
                DateTime ngayTamNgung = dtpNgayTamNgung.Value;

                if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                KhachHang kh = new KhachHang
                {
                    MaKH = maKH,
                    TenKH = tenKH,
                    CCCD = cccd,
                    DiaChi = diaChi,
                    SDT = sdt,
                    Email = email,
                    MatKhau = matKhau,
                    TrangThai = trangThai,
                    NgayDangNhapCuoi = ngayDangNhapCuoi,
                    NgayGuiCanhBao = ngayGuiCanhBao,
                    NgayTamNgung = ngayTamNgung
                };

                BUSKhachHang bUSKhachHang = new BUSKhachHang();
                string result = bUSKhachHang.InsertKhachHang(kh);

                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadDanhSachKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhatKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = cbMaKH.SelectedValue?.ToString();
                string tenKH = txtTenKH.Text.Trim();
                string cccd = txtCCCD.Text.Trim();
                string diaChi = txtDiaChiKhachHang.Text.Trim();
                string sdt = txtSDTKhachHang.Text.Trim();
                string email = txtEmailKhachHang.Text.Trim();
                string matKhau = txtMatKhauKhachHang.Text.Trim();
                bool trangThai = rbHoatDong.Checked;
                DateTime ngayDangNhapCuoi = dtpNgayDangNhapCuoi.Value;
                DateTime ngayGuiCanhBao = dtpNgayGuiCanhBao.Value;
                DateTime ngayTamNgung = dtpNgayTamNgung.Value;
                if (string.IsNullOrEmpty(maKH))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                KhachHang kh = new KhachHang
                {
                    MaKH = maKH,
                    TenKH = tenKH,
                    CCCD = cccd,
                    DiaChi = diaChi,
                    SDT = sdt,
                    Email = email,
                    MatKhau = matKhau,
                    TrangThai = trangThai,
                    NgayDangNhapCuoi = ngayDangNhapCuoi,
                    NgayGuiCanhBao = ngayGuiCanhBao,
                    NgayTamNgung = ngayTamNgung
                };

                BUSKhachHang bUSKhachHang = new BUSKhachHang();
                string result = bUSKhachHang.UpdateKhachHang(kh);
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachKhachHang();
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng không thành công: " + result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = cbMaKH.SelectedValue?.ToString();
                string tenKH = txtTenKH.Text.Trim();
                string cccd = txtCCCD.Text.Trim();
                string diaChi = txtDiaChiKhachHang.Text.Trim();
                string sdt = txtSDTKhachHang.Text.Trim();
                string email = txtEmailKhachHang.Text.Trim();
                string matKhau = txtMatKhauKhachHang.Text.Trim();
                bool trangThai = rbHoatDong.Checked;
                DateTime ngayDangNhapCuoi = dtpNgayDangNhapCuoi.Value;
                DateTime ngayGuiCanhBao = dtpNgayGuiCanhBao.Value;
                DateTime ngayTamNgung = dtpNgayTamNgung.Value;
                if (string.IsNullOrEmpty(maKH))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                KhachHang kh = new KhachHang
                {
                    MaKH = maKH,
                    TenKH = tenKH,
                    CCCD = cccd,
                    DiaChi = diaChi,
                    SDT = sdt,
                    Email = email,
                    MatKhau = matKhau,
                    TrangThai = trangThai,
                    NgayDangNhapCuoi = ngayDangNhapCuoi,
                    NgayGuiCanhBao = ngayGuiCanhBao,
                    NgayTamNgung = ngayTamNgung
                };

                BUSKhachHang bUSKhachHang = new BUSKhachHang();
                string result = bUSKhachHang.DeleteKhachHang(maKH);
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachKhachHang();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng không thành công: " + result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoiKhachHang_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnTimKhachHang_Click(object sender, EventArgs e)
        {
            string maKH = txtTimKhachHang.Text.Trim();

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng cần tìm!");
                return;
            }

            var list = bUSKhachHang.GetKhachHangList();

            var ketQua = list.Where(nv => nv.MaKH != null && nv.MaKH.Trim().Equals(maKH, StringComparison.OrdinalIgnoreCase)).ToList();

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng có mã: " + maKH);
            }

            dgvKhachHang.DataSource = ketQua;
        }
}


    //private void LoadTaiKhoan()
    //{
    //    try
    //    {
    //        BUSTaiKhoan busTaiKhoan = new BUSTaiKhoan();
    //        List<TaiKhoan> dsTaiKhoan = busTaiKhoan.GetTaiKhoanList();

    //        cbMaKH.DataSource = dsTaiKhoan;
    //        cbMaKH.ValueMember = "SoTaiKhoan";           // Lưu giá trị
    //        cbMaKH.DisplayMember = "LoaiTaiKhoan";       // Hiển thị

    //        cbMaKH.SelectedIndex = -1; // Không chọn sẵn dòng nào
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show("Lỗi khi tải danh sách tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //}
}
