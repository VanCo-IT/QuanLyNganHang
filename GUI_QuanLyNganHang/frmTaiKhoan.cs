using BLL_QuanLyNganHang;
using DAL_QuanLyNganHang;
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
    public partial class frmTaiKhoan : Form
    {
        private List<KhachHang> dsKhachHang; // Lưu danh sách khách hàng để dùng lại
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            CleanForm();
            LoadDanhSachTaiKhoan();
            LoadMaKhachHangVaoComboBox();
            //code này để Đặt chữ hướng dẫn ban đầu.
            txtTimTaiKhoan.Text = "Vui lòng nhập số tài khoản cần tìm kiếm";
            txtTimTaiKhoan.ForeColor = Color.Gray;
        }
        public void CleanForm()
        {
            txtSoTaiKhoan.Clear();
            txtSoDu.Clear();
            txtLoaiTaiKhoan.Clear();
            dtpNgayMo.Value = DateTime.Now;
            cbMaKH.SelectedIndex = -1;
        }

        private void txtSoDu_KeyPress(object sender, KeyPressEventArgs e)//code này để nhập số có thập phân(1 lần . )
        {
            TextBox textBox = sender as TextBox;

            // Cho phép: số, phím điều khiển (Backspace...), và dấu chấm
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Chỉ cho phép 1 dấu chấm
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        public void LoadDanhSachTaiKhoan()
        {
            try
            {
                BUSTaiKhoan busTaiKhoan = new BUSTaiKhoan();
                var danhSach = busTaiKhoan.GetTaiKhoanList();

                // Gán dữ liệu vào DataGridView
                dgvTaiKhoan.DataSource = null;
                dgvTaiKhoan.DataSource = danhSach;

                // Gán tiêu đề cột (chỉ khi đã có dữ liệu)
                if (dgvTaiKhoan.Columns["SoTaiKhoan"] != null)
                    dgvTaiKhoan.Columns["SoTaiKhoan"].HeaderText = "Số Tài Khoản";

                if (dgvTaiKhoan.Columns["MaKH"] != null)
                    dgvTaiKhoan.Columns["MaKH"].HeaderText = "Mã Khách Hàng";

                if (dgvTaiKhoan.Columns["SoDu"] != null)
                    dgvTaiKhoan.Columns["SoDu"].HeaderText = "Số Dư";

                if (dgvTaiKhoan.Columns["LoaiTaiKhoan"] != null)
                    dgvTaiKhoan.Columns["LoaiTaiKhoan"].HeaderText = "Loại Tài Khoản";

                if (dgvTaiKhoan.Columns["NgayMo"] != null)
                    dgvTaiKhoan.Columns["NgayMo"].HeaderText = "Ngày Mở";

                // Tự giãn cột
                dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTaiKhoan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                // Đổ dữ liệu vào các TextBox trên form
                txtSoTaiKhoan.Text = row.Cells["SoTaiKhoan"].Value?.ToString();
                cbMaKH.Text = row.Cells["MaKH"].Value?.ToString();
                txtSoDu.Text = row.Cells["SoDu"].Value?.ToString();
                txtLoaiTaiKhoan.Text = row.Cells["LoaiTaiKhoan"].Value?.ToString();
                dtpNgayMo.Value = Convert.ToDateTime(row.Cells["NgayMo"].Value);

                // Bật nút "Sửa"
                btnThemTaiKhoan.Enabled = false;
                btnCapNhatTaiKhoan.Enabled = true;
                btnXoaTaiKhoan.Enabled = true;
            }
        }
        private void LoadMaKhachHangVaoComboBox()
        {
            BUSKhachHang busKhachHang = new BUSKhachHang();
            dsKhachHang = busKhachHang.GetKhachHangList(); // Lấy full danh sách khách hàng

            cbMaKH.DataSource = dsKhachHang;
            cbMaKH.DisplayMember = "MaKH";  // Hiển thị mã khách hàng trong combo
            cbMaKH.ValueMember = "MaKH";    // Giá trị cũng là mã khách hàng
            cbMaKH.SelectedIndex = -1;      // Không chọn mặc định
        }

        private void cbMaKH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbMaKH.SelectedIndex == -1 || cbMaKH.SelectedValue == null)
                return;

            string selectedMaKH = cbMaKH.SelectedValue.ToString();

            try
            {
                BUSTaiKhoan busTaiKhoan = new BUSTaiKhoan();
                var taiKhoanTheoKH = busTaiKhoan.GetTaiKhoanTheoMaKH(selectedMaKH);

                // Hiển thị dữ liệu lên DataGridView
                dgvTaiKhoan.DataSource = null;
                dgvTaiKhoan.DataSource = taiKhoanTheoKH;

                // Nếu có ít nhất 1 tài khoản, lấy cái đầu tiên để hiển thị lên các TextBox
                if (taiKhoanTheoKH.Count > 0)
                {
                    TaiKhoan tk = taiKhoanTheoKH[0]; // lấy tài khoản đầu tiên

                    txtSoTaiKhoan.Text = tk.SoTaiKhoan;
                    txtSoDu.Text = tk.SoDu.ToString("N2");
                    txtLoaiTaiKhoan.Text = tk.LoaiTaiKhoan;
                    dtpNgayMo.Value = tk.NgayMo;
                }
                else
                {
                    // Nếu không có tài khoản thì clear form
                    txtSoTaiKhoan.Clear();
                    txtSoDu.Clear();
                    txtLoaiTaiKhoan.Clear();
                    dtpNgayMo.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách tài khoản: " + ex.Message);
            }
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan tk = new TaiKhoan();
                tk.SoTaiKhoan = txtSoTaiKhoan.Text.Trim();
                tk.MaKH = cbMaKH.SelectedValue?.ToString();
                tk.SoDu = decimal.TryParse(txtSoDu.Text, out decimal soDu) ? soDu : 0;
                tk.LoaiTaiKhoan = txtLoaiTaiKhoan.Text.Trim();
                tk.NgayMo = dtpNgayMo.Value;

                BUSTaiKhoan bus = new BUSTaiKhoan();
                bus.InsertTaiKhoan(tk);

                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachTaiKhoan();
                CleanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhatTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan tk = new TaiKhoan();
                tk.SoTaiKhoan = txtSoTaiKhoan.Text.Trim();
                tk.MaKH = cbMaKH.SelectedValue?.ToString();
                tk.SoDu = decimal.TryParse(txtSoDu.Text, out decimal soDu) ? soDu : 0;
                tk.LoaiTaiKhoan = txtLoaiTaiKhoan.Text.Trim();
                tk.NgayMo = dtpNgayMo.Value;

                BUSTaiKhoan bus = new BUSTaiKhoan();
                bus.UpdateTaiKhoan(tk);

                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachTaiKhoan();
                CleanForm();

                btnThemTaiKhoan.Enabled = true;
                btnCapNhatTaiKhoan.Enabled = false;
                btnXoaTaiKhoan.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string soTK = txtSoTaiKhoan.Text.Trim();
                    BUSTaiKhoan bus = new BUSTaiKhoan();
                    bus.DeleteTaiKhoan(soTK);

                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachTaiKhoan();
                    CleanForm();

                    btnThemTaiKhoan.Enabled = true;
                    btnCapNhatTaiKhoan.Enabled = false;
                    btnXoaTaiKhoan.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoiTaiKhoan_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void btnTimTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                BUSTaiKhoan busTaiKhoan = new BUSTaiKhoan();
                string maKH = cbMaKH.SelectedValue != null ? cbMaKH.SelectedValue.ToString() : "";
                string soTaiKhoan = txtSoTaiKhoan.Text.Trim();

                MessageBox.Show($"Mã KH: {maKH}\nSố tài khoản: {soTaiKhoan}");

                var danhSach = busTaiKhoan.GetTaiKhoanList();

                if (!string.IsNullOrEmpty(maKH))
                {
                    danhSach = danhSach.Where(tk => tk.MaKH == maKH).ToList();
                }

                if (!string.IsNullOrEmpty(soTaiKhoan))
                {
                    danhSach = danhSach.Where(tk => tk.SoTaiKhoan.Contains(soTaiKhoan)).ToList();
                }

                dgvTaiKhoan.DataSource = null;
                dgvTaiKhoan.DataSource = danhSach;

                if (danhSach.Count > 0)
                {
                    var tk = danhSach[0];
                    txtSoTaiKhoan.Text = tk.SoTaiKhoan;
                    cbMaKH.SelectedValue = tk.MaKH;
                    txtSoDu.Text = tk.SoDu.ToString("N2");
                    txtLoaiTaiKhoan.Text = tk.LoaiTaiKhoan;
                    dtpNgayMo.Value = tk.NgayMo;
                }
                else
                {
                    CleanForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm tài khoản: " + ex.Message);
            }
        }

        //Xóa chữ hướng dẫn khi người dùng bắt đầu nhập.
        private void txtTimTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTimTaiKhoan.Text == "Vui lòng nhập số tài khoản cần tìm kiếm")
            {
                txtTimTaiKhoan.Text = "";
                txtTimTaiKhoan.ForeColor = Color.Black; // Màu chữ bình thường
            }
        }
        //Hiện lại chữ hướng dẫn nếu người dùng không nhập gì.
        private void txtTimTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimTaiKhoan.Text))
            {
                txtTimTaiKhoan.Text = "Vui lòng nhập số tài khoản cần tìm kiếm";
                txtTimTaiKhoan.ForeColor = Color.Gray; // Màu chữ mờ
            }
        }
    }
}
