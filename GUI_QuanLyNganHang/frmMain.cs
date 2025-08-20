using FontAwesome.Sharp;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //CheckPermission();
        }
        private Form currentFormChild;

        private void openChildForm(Form formChild)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            pnMain.Controls.Add(formChild);
            pnMain.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelUser.Text = "Người dùng: admin";
            toolStripStatusLabelTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            foreach (Control ctl in pnLeft.Controls)
            {
                if (ctl is Button)
                {
                    ctl.MouseEnter += SidebarButton_MouseEnter;
                    ctl.MouseLeave += SidebarButton_MouseLeave;
                }
            }
        }
        private void SidebarButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.GreenYellow; // Màu xanh 
            }
        }

        private void SidebarButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.Black; // Màu gốc
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            pnHeThongChucNang.Visible = !pnHeThongChucNang.Visible;
        }

        private void mnuHeThong_DoiMatKhau_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoiMatKhau());
        }
    }
}
