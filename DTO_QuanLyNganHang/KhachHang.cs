using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNganHang
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }   
        public string CCCD { get; set; }    
        public string DiaChi { get; set; }  
        public string SDT { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public bool TrangThai { get; set; }
        public DateTime? NgayDangNhapCuoi { get; set; }
        public DateTime? NgayGuiCanhBao { get; set; }
        public DateTime? NgayTamNgung { get; set; }

        public string TrangThaiText => TrangThai ? "Đang Hoạt Động" : "Tạm Ngưng";
    }
}
