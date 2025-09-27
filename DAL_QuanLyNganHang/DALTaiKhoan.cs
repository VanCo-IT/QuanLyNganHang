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
    public class DALTaiKhoan
    {
        public List<TaiKhoan> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            SQLiteDataReader reader = DButil.Query(sql, args);

            while (reader.Read())
            {
                TaiKhoan entity = new TaiKhoan();
                entity.SoTaiKhoan = reader["SoTaiKhoan"].ToString();
                entity.MaKH = reader["MaKH"].ToString();
                entity.SoDu = Convert.ToDecimal(reader["SoDu"]);
                entity.LoaiTaiKhoan = reader["LoaiTaiKhoan"].ToString();
                entity.NgayMo = Convert.ToDateTime(reader["NgayMo"]);
                list.Add(entity);
            }

            return list;
        }
        public List<TaiKhoan> selectAll()
        {
            String sql = "SELECT * FROM TaiKhoan";
            return SelectBySql(sql, new List<object>());
        }
        public string generateSoTaiKhoan()
        {
            string prefix = "STK";
            string sql = "SELECT MAX(SoTaiKhoan) FROM TaiKhoan";
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
        public void insertTaiKhoan(TaiKhoan tk)
        {
            try
            {
                string sql = @"INSERT INTO TaiKhoan (SoTaiKhoan, MaKH, SoDu, LoaiTaiKhoan, NgayMo) 
                       VALUES (@0, @1, @2, @3, @4)";

                List<object> thamSo = new List<object>();
                thamSo.Add(tk.SoTaiKhoan);
                thamSo.Add(tk.MaKH);
                thamSo.Add(tk.SoDu);
                thamSo.Add(tk.LoaiTaiKhoan);
                thamSo.Add(tk.NgayMo);

                DButil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                // Ghi log nếu cần
                throw;
            }
        }
        public void updateTaiKhoan(TaiKhoan tk)
        {
            try
            {
                string sql = @"UPDATE TaiKhoan 
                       SET MaKH = @1, SoDu = @2, LoaiTaiKhoan = @3, NgayMo = @4
                       WHERE SoTaiKhoan = @0";

                List<object> thamSo = new List<object>();
                thamSo.Add(tk.SoTaiKhoan);     // @0
                thamSo.Add(tk.MaKH);           // @1
                thamSo.Add(tk.SoDu);           // @2
                thamSo.Add(tk.LoaiTaiKhoan);   // @3
                thamSo.Add(tk.NgayMo);         // @4

                DButil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public void deleteTaiKhoan(string soTaiKhoan)
        {
            try
            {
                string sql = "DELETE FROM TaiKhoan WHERE SoTaiKhoan = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(soTaiKhoan);
                DButil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
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
