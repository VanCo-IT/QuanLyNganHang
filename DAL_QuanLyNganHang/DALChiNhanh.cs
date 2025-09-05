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
    public class DALChiNhanh
    {
        public List<ChiNhanh> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<ChiNhanh> list = new List<ChiNhanh>();
            try
            {
                SqlDataReader reader = DButil.Query(sql, args);
                while (reader.Read())
                {
                    ChiNhanh entity = new ChiNhanh();
                    entity.MaCN = reader["MaCN"].ToString();
                    entity.TenCN = reader["TenCN"].ToString();
                    entity.DiaChi = reader["DiaChi"].ToString();
                    entity.SoDienThoai = reader["SoDienThoai"].ToString();
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
        public List<ChiNhanh> selectAll()
        {
            string sql =
             "SELECT *\r\nFROM ChiNhanh";

            return SelectBySql(sql, new List<object>());
        }
        public ChiNhanh selectById(string id)
        {
            String sql = "SELECT * FROM ChiNhanh WHERE MaCN=@0";
            List<object> thamSo = new List<object>();
            thamSo.Add(id);
            List<ChiNhanh> list = SelectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }
        public string generateMaChiNhanh()
        {
            string prefix = "CN";
            string sql = "SELECT MAX(MaCN) FROM ChiNhanh";
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
        public void insertChiNhanh(ChiNhanh cn)
        {
            try
            {
                string sql = @"INSERT INTO ChiNhanh (MaCN, TenCN, DiaChi, SoDienThoai) 
                       VALUES (@0, @1, @2, @3)";

                List<object> thamSo = new List<object>();
                thamSo.Add(cn.MaCN);
                thamSo.Add(cn.TenCN);
                thamSo.Add(cn.DiaChi);
                thamSo.Add(cn.SoDienThoai);
                DButil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                // Ghi log nếu cần
                throw;
            }
        }
        public void updateChiNhanh(ChiNhanh cn)
        {
            try
            {
                string sql = @"UPDATE ChiNhanh 
                       SET TenCN = @1, DiaChi = @2, SoDienThoai = @3
                       WHERE MaCN = @0";

                List<object> thamSo = new List<object>();
                thamSo.Add(cn.MaCN);     // @0
                thamSo.Add(cn.TenCN);           // @1
                thamSo.Add(cn.DiaChi);           // @2
                thamSo.Add(cn.SoDienThoai);   // @3

                DButil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public void deleteChiNhanh(string maChiNhanh)
        {
            try
            {
                string sql = "DELETE FROM ChiNhanh WHERE MaCN = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maChiNhanh);
                DButil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public List<string> GetOnlyMaCN()
        {
            List<string> danhSachMaCN = new List<string>();
            string sql = "SELECT MaCN FROM ChiNhanh";
            SqlDataReader reader = DButil.Query(sql, new List<object>());

            while (reader.Read())
            {
                string maCN = reader["MaCN"].ToString();
                danhSachMaCN.Add(maCN);
            }

            return danhSachMaCN;
        }
    }
}
