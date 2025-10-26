using DTO_QuanLyNganHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text; //cài thư viện này để xuất hóa đơn
using iTextSharp.text.pdf; //cài thư viện này để xuất hóa đơn


namespace GUI_QuanLyNganHang
{
    public partial class frmHoaDon : Form
    {
        private GiaoDich giaoDich;
        //public frmHoaDon()
        //{
        //    InitializeComponent();
        //}
        public frmHoaDon(GiaoDich gd)
        {
            InitializeComponent();
            this.giaoDich = gd;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            txtMaGD.Text = giaoDich.MaGD;
            txtSoTaiKhoan.Text = giaoDich.SoTaiKhoan;
            dtpNgayGD.Text = giaoDich.NgayGD.ToString("dd/MM/yyyy");
            txtSoTien.Text = giaoDich.SoTien.ToString("N0") + " VND";
            txtLoaiGD.Text = giaoDich.LoaiGD;
            txtMoTa.Text = giaoDich.MoTa;
            txtTrangThai.Text = giaoDich.TrangThaiText;
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.FileName = giaoDich.MaGD + ".pdf"; // Tên mặc định

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToPDF(filePath);

                // Hiển thị xem trước in (PrintPreview)
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += (s, ev) =>
                {
                    ev.Graphics.DrawString(File.ReadAllText(filePath),
                                           new System.Drawing.Font("Arial", 12),
                                           System.Drawing.Brushes.Black, 20, 20);
                };

                PrintPreviewDialog preview = new PrintPreviewDialog();
                preview.Document = pd;
                preview.ShowDialog();
                // Hiện thông báo xuất thành công
                MessageBox.Show("Xuất hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form này sau khi xuất xong
                this.Close();
            }
        }
        private void ExportToPDF(string filePath)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Sử dụng font Tahoma (có hỗ trợ tiếng Việt) từ thư mục Fonts của Windows
                string fontPath = Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + @"\tahoma.ttf";
                var bf = iTextSharp.text.pdf.BaseFont.CreateFont(fontPath, iTextSharp.text.pdf.BaseFont.IDENTITY_H, iTextSharp.text.pdf.BaseFont.EMBEDDED);// sai?
                var font = new iTextSharp.text.Font(bf, 12);
                var fontTitle = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);

                doc.Add(new iTextSharp.text.Paragraph("=== HÓA ĐƠN GIAO DỊCH ===", fontTitle));
                doc.Add(new iTextSharp.text.Paragraph("Mã GD: " + giaoDich.MaGD, font));
                doc.Add(new iTextSharp.text.Paragraph("Số tài khoản: " + giaoDich.SoTaiKhoan, font));
                doc.Add(new iTextSharp.text.Paragraph("Ngày GD: " + giaoDich.NgayGD.ToString("dd/MM/yyyy"), font));
                doc.Add(new iTextSharp.text.Paragraph("Số tiền: " + giaoDich.SoTien.ToString("N0") + " VND", font));
                doc.Add(new iTextSharp.text.Paragraph("Loại GD: " + giaoDich.LoaiGD, font));
                doc.Add(new iTextSharp.text.Paragraph("Mô tả: " + giaoDich.MoTa, font));
                doc.Add(new iTextSharp.text.Paragraph("Trạng thái: " + giaoDich.TrangThaiText, font));

                doc.Close();
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
