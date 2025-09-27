using DTO_QuanLyNganHang;
//using Microsoft.Data.SqlClient;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyNganHang
{
    public class DALKhachHang
    {
        public List<KhachHang> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<KhachHang> list = new List<KhachHang>();
            try
            {
                SQLiteDataReader reader = DButil.Query(sql, args);
                while (reader.Read())
                {
                    KhachHang entity = new KhachHang();
                    entity.MaKH = reader["MaKH"].ToString();
                    entity.TenKH = reader["TenKH"].ToString();
                    entity.CCCD = reader["CCCD"].ToString();
                    entity.DiaChi = reader["DiaChi"].ToString();
                    entity.SDT = reader["SDT"].ToString();
                    entity.Email = reader["Email"].ToString();
                    entity.MatKhau = reader["MatKhau"].ToString();

                    entity.TrangThai = !reader.IsDBNull(reader.GetOrdinal("TrangThai"))
                    && Convert.ToBoolean(reader["TrangThai"]);

                    int indexNgayDangNhapCuoi = reader.GetOrdinal("NgayDangNhapCuoi");
                    entity.NgayDangNhapCuoi = !reader.IsDBNull(indexNgayDangNhapCuoi)
                        ? reader.GetDateTime(indexNgayDangNhapCuoi)
                        : (DateTime?)null;

                    int indexNgayGuiCanhBao = reader.GetOrdinal("NgayGuiCanhBao");
                    entity.NgayGuiCanhBao = !reader.IsDBNull(indexNgayGuiCanhBao)
                        ? reader.GetDateTime(indexNgayGuiCanhBao)
                        : (DateTime?)null;

                    int indexNgayTamNgung = reader.GetOrdinal("NgayTamNgung");
                    entity.NgayTamNgung = !reader.IsDBNull(indexNgayTamNgung)
                        ? reader.GetDateTime(indexNgayTamNgung)
                        : (DateTime?)null;
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
        public List<KhachHang> selectAll(int trangThai = -1)
        {
            string sql = "SELECT KhachHang.MaKH, TenKH, CCCD, DiaChi, SDT, Email, MatKhau, TrangThai, " +
             "NgayDangNhapCuoi, NgayTamNgung, NgayGuiCanhBao, " +
             "TaiKhoan.SoTaiKhoan, TaiKhoan.SoDu, TaiKhoan.LoaiTaiKhoan, TaiKhoan.NgayMo " +
             "FROM KhachHang " +
             "LEFT JOIN TaiKhoan ON KhachHang.MaKH = TaiKhoan.MaKH";

            List<object> p = new List<object>();
            if (trangThai > -1)
            {
                sql += " WHERE KhachHang.TrangThai = @0";
            }

            p.Add(trangThai);


            return SelectBySql(sql, p);
        }


        public KhachHang selectById(string id)
        {
            String sql = "SELECT * FROM KhachHang WHERE MaKH=@0";
            List<object> thamSo = new List<object>();
            thamSo.Add(id);
            List<KhachHang> list = SelectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public void insertKhachHang(KhachHang kh)
        {
            try
            {
                string sql = @"INSERT INTO KhachHang (MaKH, TenKH,CCCD,DiaChi,SDT,Email,MatKhau,TrangThai,NgayDangNhapCuoi,NgayGuiCanhBao,NgayTamNgung) 
                   VALUES (@0, @1, @2, @3, @4, @5,@6,@7,@8,@9,@10)";
                List<object> thamSo = new List<object>();
                thamSo.Add(kh.MaKH);
                thamSo.Add(kh.TenKH);
                thamSo.Add(kh.CCCD);
                thamSo.Add(kh.DiaChi);
                thamSo.Add(kh.SDT);
                thamSo.Add(kh.Email);
                thamSo.Add(kh.MatKhau);
                thamSo.Add(kh.TrangThai);
                thamSo.Add(kh.NgayDangNhapCuoi ?? (object)DBNull.Value);
                thamSo.Add(kh.NgayTamNgung ?? (object)DBNull.Value);
                thamSo.Add(kh.NgayGuiCanhBao ?? (object)DBNull.Value);
                DButil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void updateKhachHang(KhachHang kh)
        {
            try
            {
                string sql = @"UPDATE KhachHang 
                   SET TenKH = @1, CCCD = @2, DiaChi = @3, SDT = @4,Email =@5,MatKhau = @6,TrangThai = @7,NgayDangNhapCuoi = @8,NgayTamNgung = @9,NgayGuiCanhBao = @10
                   WHERE MaKH = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(kh.MaKH);
                thamSo.Add(kh.TenKH);
                thamSo.Add(kh.CCCD);
                thamSo.Add(kh.DiaChi);
                thamSo.Add(kh.SDT);
                thamSo.Add(kh.Email);
                thamSo.Add(kh.MatKhau);
                thamSo.Add(kh.TrangThai);
                thamSo.Add(kh.NgayDangNhapCuoi);
                thamSo.Add(kh.NgayTamNgung);
                thamSo.Add(kh.NgayGuiCanhBao);
                DButil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void deleteKhachHang(string maKH)
        {
            try
            {
                string sql = "DELETE FROM KhachHang WHERE MaKH = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maKH);
                DButil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public string generateMaKhachHang()
        {
            string prefix = "KH";
            string sql = "SELECT MAX(MaKH) FROM KhachHang";
            List<object> thamSo = new List<object>();
            object result = DButil.ScalarQuery(sql, thamSo);
            if (result != null && result.ToString().StartsWith(prefix))
            {
                string maxCode = result.ToString().Substring(2);
                int newNumber = int.Parse(maxCode) + 1;
                return $"{prefix}{newNumber:D3}";
            }

            return $"{prefix}001";
        }
        public List<string> GetOnlyMaKH()
        {
            List<string> danhSachMaKH = new List<string>();
            string sql = "SELECT MaKH FROM KhachHang";
            SQLiteDataReader reader = DButil.Query(sql, new List<object>());

            while (reader.Read())
            {
                string maKH = reader["MaKH"].ToString();
                danhSachMaKH.Add(maKH);
            }

            return danhSachMaKH;
        }

    }
}
