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
    public partial class frmNhapMa : Form
    {
        public string MaDuocGui { get; set; }
        public string EmailDangXacThuc { get; set; }
        public frmNhapMa()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMaXacMinh.Text == MaDuocGui)
            {
                MessageBox.Show("Xác minh thành công!");
                frmDatLaiMK frmDatLai = new frmDatLaiMK(EmailDangXacThuc);
                this.Hide();
                frmDatLai.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Mã xác minh không đúng, vui lòng thử lại!");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
