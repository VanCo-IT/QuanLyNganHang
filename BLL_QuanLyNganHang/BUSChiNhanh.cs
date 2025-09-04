using DAL_QuanLyNganHang;
using DTO_QuanLyNganHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_QuanLyNganHang
{
    public class BUSChiNhanh
    {
        DALChiNhanh dalCHiNhanh = new DALChiNhanh();
        public List<ChiNhanh> GetChiNhanhList()
        {
            return dalCHiNhanh.selectAll();
        }
        public string InSertChiNhanh(ChiNhanh cn)
        {
            try
            {
                // Sinh mã số tài khoản mới
                cn.MaCN = dalCHiNhanh.generateMaChiNhanh();

                // Kiểm tra mã khách hàng có hợp lệ không (tùy bạn có DAL kiểm tra hay không)
                if (string.IsNullOrEmpty(cn.MaCN))
                {
                    return "Mã chi nhánh không hợp lệ.Vui lòng nhập lại";
                }

                // Thêm vào CSDL
                dalCHiNhanh.insertChiNhanh(cn);

                return string.Empty; // Thành công
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
        public string UpdateChiNhanh(ChiNhanh cn)
        {
            try
            {
                if (string.IsNullOrEmpty(cn.MaCN))
                {
                    return "Mã chi nhánh không hợp lệ.";
                }

                dalCHiNhanh.updateChiNhanh(cn);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
        public string DaleteChiNhanh(string maChiNhanh)
        {
            try
            {
                if (string.IsNullOrEmpty(maChiNhanh))
                {
                    return "Mã chi nhánh không hợp lệ.";
                }

                dalCHiNhanh.deleteChiNhanh(maChiNhanh);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
    }
}
