using DAL_QuanLyNganHang;
using DTO_QuanLyNganHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_QuanLyNganHang
{
    public class BUSTaiKhoan
    {
        DALTaiKhoan dalTaiKhoan = new DALTaiKhoan();
        public List<TaiKhoan> GetTaiKhoanList()
        {
            return dalTaiKhoan.selectAll();
        }
        public string InsertTaiKhoan(TaiKhoan tk)
        {
            try
            {
                // Sinh mã số tài khoản mới
                tk.SoTaiKhoan = dalTaiKhoan.generateSoTaiKhoan();

                // Kiểm tra mã khách hàng có hợp lệ không (tùy bạn có DAL kiểm tra hay không)
                if (string.IsNullOrEmpty(tk.MaKH))
                {
                    return "Mã khách hàng không hợp lệ.";
                }

                // Thêm vào CSDL
                dalTaiKhoan.insertTaiKhoan(tk);

                return string.Empty; // Thành công
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
        public string UpdateTaiKhoan(TaiKhoan tk)
        {
            try
            {
                if (string.IsNullOrEmpty(tk.SoTaiKhoan))
                {
                    return "Số tài khoản không hợp lệ.";
                }

                dalTaiKhoan.updateTaiKhoan(tk);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteTaiKhoan(string soTaiKhoan)
        {
            try
            {
                if (string.IsNullOrEmpty(soTaiKhoan))
                {
                    return "Số tài khoản không hợp lệ.";
                }

                dalTaiKhoan.deleteTaiKhoan(soTaiKhoan);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
        public List<string> GetAllMaKH()
        {
            return dalTaiKhoan.GetOnlyMaKH();
        }
        public List<TaiKhoan> GetTaiKhoanTheoMaKH(string maKH)
        {
            string sql = "SELECT * FROM TaiKhoan WHERE MaKH = @0";
            List<object> thamSo = new List<object> { maKH };
            return dalTaiKhoan.SelectBySql(sql, thamSo);
        }

    }
}
