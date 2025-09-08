using BLL_QuanLyNganHang;
using DAL_QuanLyNganHang;
using DTO_QuanLyNganHang;
using Microsoft.VisualBasic;
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
    public partial class frmGiaoDich : Form
    {
        private List<TaiKhoan> dsTaiKhoan; // Lưu danh sách tài khoản để dùng lại
        public frmGiaoDich()
        {
            InitializeComponent();
        }

        private void frmGiaoDich_Load(object sender, EventArgs e)
        {
            LoadSoTaiKhoanVaoComboBox();     // ✅ Load dữ liệu tài khoản trước
            LoadDanhSachGiaoDich();          // ✅ Sau đó load giao dịch
            ClearForm();                     // ✅ Cuối cùng reset form
        }
        private void ClearForm()
        {
            txtMaGD.Clear();
            cbSoTaiKhoan.SelectedIndex = -1; // ✅ Đặt lại selection thay vì xóa Item
            dtpNgayGD.Value = DateTime.Now;
            txtSoTien.Clear();
            txtLoaiGD.Clear();
            txtMoTa.Clear();
            rbDaThanhToan.Checked = false;
            rbDaHuy.Checked = false;
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            //code này để nhập số có thập phân(1 lần . )
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
        public void LoadDanhSachGiaoDich()
        {
            try
            {
                var danhSach = new BUSGiaoDich().GetGiaoDichList();
                dgvGiaoDich.DataSource = danhSach;
                //// ✅ In ra tên các cột đang có
                //string cols = "";
                //foreach (DataGridViewColumn col in dgvGiaoDich.Columns)
                //{
                //    cols += col.Name + "\n";
                //}
                //MessageBox.Show("Tên các cột trong DataGridView:\n" + cols);

                var columnHeaders = new Dictionary<string, string>
                {
                    { "MaGD", "Mã Giao Dịch" },
                    { "SoTaiKhoan", "Số Tài Khoản" },
                    { "NgayGD", "Ngày Giao Dịch" },
                    { "SoTien", "Số Tiền" },
                    { "LoaiGD", "Loại Giao Dịch" },
                    { "MoTa", "Mô Tả" },
                    { "TrangThai", "Trạng Thái" }
                };

                foreach (var column in columnHeaders)
                {
                    if (dgvGiaoDich.Columns[column.Key] != null)
                        dgvGiaoDich.Columns[column.Key].HeaderText = column.Value;
                }

                dgvGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách giao dịch: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGiaoDich_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvGiaoDich.Rows[e.RowIndex];

                // ✅ Dùng theo index tạm thời để tránh lỗi (cột theo thứ tự như DataSource)
                txtMaGD.Text = row.Cells[0].Value?.ToString();          // MaGD
                cbSoTaiKhoan.Text = row.Cells[1].Value?.ToString();     // SoTaiKhoan

                if (row.Cells[2].Value != null)
                {
                    dtpNgayGD.Value = Convert.ToDateTime(row.Cells[2].Value);  // NgayGD
                }

                txtSoTien.Text = row.Cells[3].Value?.ToString();        // SoTien
                txtLoaiGD.Text = row.Cells[4].Value?.ToString();        // LoaiGD
                txtMoTa.Text = row.Cells[5].Value?.ToString();          // MoTa

                bool trangThai = false;
                bool.TryParse(row.Cells[6].Value?.ToString(), out trangThai);  // TrangThai
                rbDaThanhToan.Checked = trangThai;
                rbDaHuy.Checked = !trangThai;
            }
        }

        private void LoadSoTaiKhoanVaoComboBox()
        {
            BUSTaiKhoan busTaiKhoan = new BUSTaiKhoan();
            dsTaiKhoan = busTaiKhoan.GetTaiKhoanList(); // Lấy full danh sách tài khoản

            cbSoTaiKhoan.DataSource = dsTaiKhoan;
            cbSoTaiKhoan.DisplayMember = "SoTaiKhoan";  // Hiển thị mã khách hàng trong combo
            cbSoTaiKhoan.ValueMember = "SoTaiKhoan";    // Giá trị cũng là mã khách hàng
            cbSoTaiKhoan.SelectedIndex = -1;      // Không chọn mặc định
        }

        private void cbSoTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSoTaiKhoan.SelectedIndex == -1 || cbSoTaiKhoan.SelectedValue == null)
                return;

            string selectedSoTaiKhoan = cbSoTaiKhoan.SelectedValue.ToString();

            try
            {
                BUSGiaoDich busGiaoDich = new BUSGiaoDich();
                var giaoDichList = busGiaoDich.GetGiaoDichTheoSoTaiKhoan(selectedSoTaiKhoan);

                // Gán vào DataGridView
                dgvGiaoDich.DataSource = null;
                dgvGiaoDich.DataSource = giaoDichList;
                var columnHeaders = new Dictionary<string, string>
                {
                    { "MaGD", "Mã Giao Dịch" },
                    { "SoTaiKhoan", "Số Tài Khoản" },
                    { "NgayGD", "Ngày Giao Dịch" },
                    { "SoTien", "Số Tiền" },
                    { "LoaiGD", "Loại Giao Dịch" },
                    { "MoTa", "Mô Tả" },
                    { "TrangThai", "Trạng Thái" }
                };

                foreach (var column in columnHeaders)
                {
                    if (dgvGiaoDich.Columns[column.Key] != null)
                        dgvGiaoDich.Columns[column.Key].HeaderText = column.Value;
                }

                dgvGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                // Nếu có ít nhất 1 giao dịch, hiển thị dữ liệu lên form
                if (giaoDichList.Count > 0)
                {
                    GiaoDich gd = giaoDichList[0];

                    txtMaGD.Text = gd.MaGD;
                    txtSoTien.Text = gd.SoTien.ToString("N2");
                    dtpNgayGD.Value = gd.NgayGD;
                    txtLoaiGD.Text = gd.LoaiGD;
                    txtMoTa.Text = gd.MoTa;

                    if (gd.TrangThai)
                        rbDaThanhToan.Checked = true;
                    else
                        rbDaHuy.Checked = true;
                }
                else
                {
                    ClearFormDataInput(); // Xoá nội dung nếu không có giao dịch
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách giao dịch: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemGD_Click(object sender, EventArgs e)
        {
            if (cbSoTaiKhoan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn số tài khoản.");
                return;
            }

            GiaoDich gd = new GiaoDich
            {
                SoTaiKhoan = cbSoTaiKhoan.SelectedValue?.ToString(),
                NgayGD = dtpNgayGD.Value,
                SoTien = decimal.TryParse(txtSoTien.Text, out var sotien) ? sotien : 0,
                LoaiGD = txtLoaiGD.Text,
                MoTa = txtMoTa.Text,
                TrangThai = rbDaThanhToan.Checked
            };

            string ketQua = new BUSGiaoDich().InsertGiaoDich(gd);
            if (string.IsNullOrEmpty(ketQua))
            {
                MessageBox.Show("Thêm giao dịch thành công!");

                // Gọi lại hàm lọc theo số tài khoản đang chọn
                cbSoTaiKhoan_SelectedIndexChanged(null, null);
                // Mở form hóa đơn để in
                frmHoaDon frm = new frmHoaDon(gd);
                frm.ShowDialog();

                ClearFormDataInput(); // Không gọi ClearForm để không reset combo
            }
            else
            {
                MessageBox.Show("Lỗi: " + ketQua);
            }
        }

        private void ClearFormDataInput()
        {
            txtMaGD.Clear();
            dtpNgayGD.Value = DateTime.Now;
            txtSoTien.Clear();
            txtLoaiGD.Clear();
            txtMoTa.Clear();
            rbDaThanhToan.Checked = false;
            rbDaHuy.Checked = false;
        }

        private void btnCapNhatGD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaGD.Text))
            {
                MessageBox.Show("Vui lòng chọn giao dịch cần cập nhật.");
                return;
            }

            GiaoDich gd = new GiaoDich
            {
                MaGD = txtMaGD.Text,
                SoTaiKhoan = cbSoTaiKhoan.SelectedValue?.ToString(),
                NgayGD = dtpNgayGD.Value,
                SoTien = decimal.TryParse(txtSoTien.Text, out var sotien) ? sotien : 0,
                LoaiGD = txtLoaiGD.Text,
                MoTa = txtMoTa.Text,
                TrangThai = rbDaThanhToan.Checked
            };

            string ketQua = new BUSGiaoDich().UpdateGiaoDich(gd);
            if (string.IsNullOrEmpty(ketQua))
            {
                MessageBox.Show("Cập nhật giao dịch thành công!");

                // Load lại danh sách theo số tài khoản đang chọn
                cbSoTaiKhoan_SelectedIndexChanged(null, null);

                ClearFormDataInput();
            }
            else
            {
                MessageBox.Show("Lỗi: " + ketQua);
            }
        }

        private void btnLamMoiGD_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachGiaoDich();
        }
    }
}
