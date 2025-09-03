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
    public class DALNhanVien
    {
        public NhanVien getNhanVien(string email, string password)
        {
            string sql = "SELECT * FROM NhanVien WHERE Email=@0 AND MatKhau=@1";
            List<object> thamSo = new List<object>();
            thamSo.Add(email);
            thamSo.Add(password);
            NhanVien nv = DButil.Value<NhanVien>(sql, thamSo);
            return nv;
        }

        public NhanVien? getNhanVien1(string email, string password)
        {
            string sql = "SELECT Top 1 * FROM NhanVien WHERE Email=@0 AND MatKhau=@1";
            List<object> thamSo = new List<object>();
            thamSo.Add(email);
            thamSo.Add(password);
            SqlDataReader reader = DButil.Query(sql, thamSo);
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNV = reader["MaNV"].ToString();
                    nv.TenNV = reader["TenNV"].ToString();
                    nv.TenDN = reader["TenDN"].ToString();
                    nv.SDT = reader["SDT"].ToString();
                    nv.Email = reader["Email"].ToString();
                    nv.MatKhau = reader["MatKhau"].ToString();
                    nv.VaiTro = bool.Parse(reader["VaiTro"].ToString());
                    nv.TrangThai = bool.Parse(reader["TrangThai"].ToString());
                    return nv;
                }
            }
            return null;
        }

        public void ResetMatKhau(string mk, string email)
        {
            try
            {
                string sql = "UPDATE NhanVien SET MatKhau = @0 WHERE Email = @1";
                List<object> thamSo = new List<object>();
                thamSo.Add(mk);
                thamSo.Add(email);
                DButil.Update(sql, thamSo);

            }
            catch (Exception e)
            {
                throw;
            }
        }

        public List<NhanVien> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<NhanVien> list = new List<NhanVien>();
            try
            {
                SqlDataReader reader = DButil.Query(sql, args);
                while (reader.Read())
                {
                    NhanVien entity = new NhanVien();
                    entity.MaNV = reader.GetString("MaNV");
                    entity.TenNV = reader.GetString("TenNV");
                    entity.TenDN = reader.GetString("TenDN");
                    entity.SDT = reader["SDT"].ToString();
                    entity.Email = reader.GetString("Email");
                    entity.MatKhau = reader.GetString("MatKhau");
                    entity.VaiTro = reader.GetBoolean("VaiTro");
                    entity.TrangThai = reader.GetBoolean("TrangThai");
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<NhanVien> selectAll()
        {
            String sql = "SELECT * FROM NhanVien";
            return SelectBySql(sql, new List<object>());
        }


        public NhanVien selectById(string id)
        {
            String sql = "SELECT * FROM NhanVien WHERE MaNV=@0";
            List<object> thamSo = new List<object>();
            thamSo.Add(id);
            List<NhanVien> list = SelectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public void insertNhanVien(NhanVien nv)
        {
            try
            {
                string sql = @"INSERT INTO NhanVien (MaNV, TenNV,TenDN,SDT, Email, MatKhau, VaiTro, TrangThai) 
                   VALUES (@0, @1, @2, @3, @4, @5,@6,@7)";
                List<object> thamSo = new List<object>();
                thamSo.Add(nv.MaNV);
                thamSo.Add(nv.TenNV);
                thamSo.Add(nv.TenDN);
                thamSo.Add(nv.SDT);
                thamSo.Add(nv.Email);
                thamSo.Add(nv.MatKhau);
                thamSo.Add(nv.VaiTro);
                thamSo.Add(nv.TrangThai);
                DButil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void updateNhanVien(NhanVien nv)
        {
            if (nv == null) throw new ArgumentNullException(nameof(nv));
            try
            {
                string sql = @"UPDATE NhanVien 
                       SET TenNV = @1, TenDN = @2, SDT = @3, Email = @4, MatKhau = @5, VaiTro = @6, TrangThai = @7
                       WHERE MaNV = @0";

                List<object> thamSo = new List<object>()
        {
            nv.MaNV,    // @0
            nv.TenNV,   // @1
            nv.TenDN,   // @2
            nv.SDT,     // @3
            nv.Email,   // @4
            nv.MatKhau, // @5
            nv.VaiTro,  // @6
            nv.TrangThai // @7
        };
                DButil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                // Optional: log error
                throw;
            }

        }

        public void deleteNhanVien(string maNv)
        {
            try
            {
                string sql = "DELETE FROM NhanVien WHERE MaNV = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maNv);
                DButil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public bool checkEmailExists(string email)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE Email = @0";
            List<object> thamSo = new List<object>();
            thamSo.Add(email);
            object result = DButil.ScalarQuery(sql, thamSo);
            return Convert.ToInt32(result) > 0;
        }

        public string generateMaNhanVien()
        {
            string prefix = "NV";
            string sql = "SELECT MAX(MaNV) FROM NhanVien";
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
    }
}
