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
    public partial class frmChaoMung : Form
    {
        public frmChaoMung()
        {
            InitializeComponent();
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;
            Task.Delay(3000).ContinueWith(t =>
            {
                if (this.IsHandleCreated && !this.IsDisposed)
                {
                    this.Invoke(new Action(() =>
                    {
                        frmDangNhap login = new frmDangNhap();
                        login.Show();

                        this.Hide();
                    }));
                }
            });
        }

        // Bien dem so lan bam nut X
        private int demSoLanDong = 0;

        private void frmChaoMung_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Chi chan khi nguoi dung bam nut X (dong thu cong)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                demSoLanDong++;

                if (demSoLanDong < 2)
                {
                    // Huy khong cho dong
                    e.Cancel = true;

                    // Thong bao nguoi dung can bam tiep
                    MessageBox.Show(
                        $"Ban phai bam dong them {2 - demSoLanDong} lan nua de thoat.",
                        "Chua cho thoat",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    // Cho phep dong form
                    e.Cancel = false;
                }
            }
        }
    }
}
