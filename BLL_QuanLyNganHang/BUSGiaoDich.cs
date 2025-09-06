using DAL_QuanLyNganHang;
using DTO_QuanLyNganHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_QuanLyNganHang
{
    public class BUSGiaoDich
    {
        DALGiaoDich dalGiaoDich = new DALGiaoDich();
        public List<GiaoDich> GetGiaoDichList()
        {
            return dalGiaoDich.selectAll();
        }
        public string InsertGiaoDich(GiaoDich gd)
        {
            try
            {
                // Sinh mã số giao dịch mới
                gd.MaGD = dalGiaoDich.generateMaGD();

                // Kiểm tra số tài khoản có hợp lệ không 
                if (string.IsNullOrEmpty(gd.SoTaiKhoan))
                {
                    return "Số tài khoản không hợp lệ.";
                }

                // Thêm vào CSDL
                dalGiaoDich.insertGiaoDich(gd);

                return string.Empty; // Thành công
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
        public string UpdateGiaoDich(GiaoDich gd)
        {
            try
            {
                if (string.IsNullOrEmpty(gd.MaGD))
                {
                    return "Mã giao dịch không hợp lệ.Vui lòng thử lại";
                }

                dalGiaoDich.updateGiaoDich(gd);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
        public List<string> GetAllSoTaiKhoan()
        {
            return dalGiaoDich.GetOnlyMaSoTaiKhoan();
        }
        public List<GiaoDich> GetGiaoDichTheoSoTaiKhoan(string soTaiKhoan)
        {
            string sql = "SELECT * FROM GiaoDich WHERE SoTaiKhoan = @0";
            List<object> thamSo = new List<object> { soTaiKhoan };
            return dalGiaoDich.SelectBySql(sql, thamSo);
        }
    }
}
