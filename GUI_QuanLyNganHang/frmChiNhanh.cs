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
    public partial class frmChiNhanh : Form
    {
        BUSChiNhanh busChiNhanh = new BUSChiNhanh();
        public frmChiNhanh()
        {
            InitializeComponent();
        }

        private void frmChiNhanh_Load(object sender, EventArgs e)
        {
            LoadChiNhanh();
            ClearForm();
        }
        private void ClearForm()
        {
            txtMaChiNhanh.Clear();
            txtTenChiNhanh.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
        }
        private void LoadChiNhanh()
        {
            try
            {
                BUSChiNhanh busChiNhanh = new BUSChiNhanh();
                List<ChiNhanh> dsChiNhanh = busChiNhanh.GetChiNhanhList();
                dgvChiNhanh.DataSource = busChiNhanh.GetChiNhanhList();

                // Optional: Tùy chỉnh cột hiển thị nếu muốn
                //dgvKhachHang.Columns["MatKhau"].Visible = false; // Ẩn mật khẩu nếu không cần hiển thị
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách chi nhánh: " + ex.Message);
            }
        }

        private void dgvChiNhanh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvChiNhanh.Rows[e.RowIndex];
            txtMaChiNhanh.Text = row.Cells["MaCN"].Value?.ToString();
            txtTenChiNhanh.Text = row.Cells["TenCN"].Value?.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
        }

        private void btnThemChiNhanh_Click(object sender, EventArgs e)
        {
            string maCN = txtMaChiNhanh.Text.Trim();
            string tenCN = txtTenChiNhanh.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();
            if (string.IsNullOrEmpty(maCN) || string.IsNullOrEmpty(tenCN) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin chi nhánh.");
                return;
            }
            ChiNhanh cn = new ChiNhanh
            {
                MaCN = maCN,
                TenCN = tenCN,
                DiaChi = diaChi,
                SoDienThoai = soDienThoai
            };
            BUSChiNhanh busChiNhanh = new BUSChiNhanh();
            string result = busChiNhanh.InSertChiNhanh(cn);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Thêm chi nhánh thành công");
                ClearForm();
                LoadChiNhanh();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnCapNhatChiNhanh_Click(object sender, EventArgs e)
        {
            try
            {
                string maCN = txtMaChiNhanh.Text.Trim();
                string tenCN = txtTenChiNhanh.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string sdt = txtSoDienThoai.Text.Trim();

                if (string.IsNullOrEmpty(maCN))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                ChiNhanh cn = new ChiNhanh
                {
                    MaCN = maCN,
                    TenCN = tenCN,
                    DiaChi = diaChi,
                    SoDienThoai = sdt,
                };

                BUSChiNhanh busChiNhanh = new BUSChiNhanh();
                string result = busChiNhanh.UpdateChiNhanh(cn);

                MessageBox.Show("Cập nhật chi nhánh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadChiNhanh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaChiNhanh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaChiNhanh.Text))
            {
                MessageBox.Show("Vui lòng chọn mã chi nhánh để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa chi nhánh này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string maCN = txtMaChiNhanh.Text.Trim();
                    BUSChiNhanh busChiNhanh = new BUSChiNhanh();
                    busChiNhanh.DeleteChiNhanh(maCN);

                    MessageBox.Show("Xóa chi nhánh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChiNhanh();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa chi nhánh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoiChiNhanh_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadChiNhanh();
        }
    }
}
