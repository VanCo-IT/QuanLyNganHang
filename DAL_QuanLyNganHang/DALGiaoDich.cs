using DTO_QuanLyNganHang;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyNganHang
{
    public class DALGiaoDich
    {
        public List<GiaoDich> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<GiaoDich> list = new List<GiaoDich>();
            try
            {
                SqlDataReader reader = DButil.Query(sql, args);
                while (reader.Read())
                {
                    GiaoDich entity = new GiaoDich();
                    entity.MaGD = reader.GetString("MaGD");
                    entity.SoTaiKhoan = reader.GetString("SoTaiKhoan");
                    entity.NgayGD = Convert.ToDateTime(reader["NgayGD"]);
                    entity.SoTien = Convert.ToDecimal(reader["SoTien"]);
                    entity.LoaiGD = reader["LoaiGD"].ToString();
                    entity.MoTa = reader["Mota"].ToString();
                    entity.TrangThai = reader.GetBoolean(reader.GetOrdinal("TrangThai"));
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
        public List<GiaoDich> selectAll()
        {
            String sql = "SELECT * FROM GiaoDich";
            return SelectBySql(sql, new List<object>());
        }
        public string generateMaGD()
        {
            string prefix = "MGD";
            string sql = "SELECT MAX(MaGD) FROM GiaoDich";
            List<object> thamSo = new List<object>();
            object result = DButil.ScalarQuery(sql, thamSo);

            if (result != null && result.ToString().StartsWith(prefix))
            {
                string maxCode = result.ToString().Substring(prefix.Length);
                if (int.TryParse(maxCode, out int number))
                {
                    int newNumber = number + 1;
                    return $"{prefix}{newNumber:D3}";
                }
            }

            return $"{prefix}001";
        }
        public void insertGiaoDich(GiaoDich gd)
        {
            try
            {
                string sql = @"INSERT INTO GiaoDich (MaGD, SoTaiKhoan, NgayGD, SoTien,LoaiGD,MoTa, TrangThai) 
                       VALUES (@0, @1, @2, @3, @4,@5,@6)";

                List<object> thamSo = new List<object>();
                thamSo.Add(gd.MaGD);
                thamSo.Add(gd.SoTaiKhoan);
                thamSo.Add(gd.NgayGD);
                thamSo.Add(gd.SoTien);
                thamSo.Add(gd.LoaiGD);
                thamSo.Add(gd.MoTa);
                thamSo.Add(gd.TrangThai);

                DButil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                // Ghi log nếu cần
                throw;
            }
        }
        public void updateGiaoDich(GiaoDich gd)
        {
            try
            {
                string sql = @"UPDATE GiaoDich 
                       SET SoTaiKhoan = @1, NgayGD = @2, SoTien = @3, LoaiGD = @4,MoTa = @5,TrangThai = @6
                       WHERE MaGD = @0";

                List<object> thamSo = new List<object>();
                thamSo.Add(gd.MaGD);     // @0
                thamSo.Add(gd.SoTaiKhoan);           // @1
                thamSo.Add(gd.NgayGD);           // @2
                thamSo.Add(gd.SoTien);   // @3
                thamSo.Add(gd.LoaiGD);         // @4
                thamSo.Add(gd.MoTa);         // @5
                thamSo.Add(gd.TrangThai);         // @6
                DButil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public List<string> GetOnlyMaSoTaiKhoan()
        {
            List<string> danhSachSoTaiKhoan = new List<string>();
            string sql = "SELECT SoTaiKhoan FROM TaiKhoan";
            SqlDataReader reader = DButil.Query(sql, new List<object>());

            while (reader.Read())
            {
                string sotaiKhoan = reader["SoTaiKhoan"].ToString();
                danhSachSoTaiKhoan.Add(sotaiKhoan);
            }

            return danhSachSoTaiKhoan;
        }
    }
}
