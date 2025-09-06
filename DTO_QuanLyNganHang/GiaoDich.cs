using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNganHang
{
    public class GiaoDich
    {
        public string MaGD { get; set; }
        public string SoTaiKhoan { get; set; }  
        public DateTime NgayGD { get; set; }
        public decimal SoTien {  get; set; }
        public string LoaiGD { get; set; }
        public string MoTa { get; set; }
        public bool TrangThai { get; set; }
        public string TrangThaiText => TrangThai ? "Đã thanh toán" : "Đã hủy";
    }
}
