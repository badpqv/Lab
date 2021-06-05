using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_1.Models
{
    public class NhanVien
    {
        public int ID { get; set; }
        public int IDCuaHang { get; set; }
        public int MaNv { get; set; }
        public string TenNv { get; set; }
        public string HoNv { get; set; }
        public string TenDemNv { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public decimal LuongNv { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public int IDChucVu { get; set; }
        public int IDTrangThai { get; set; }
        public CuaHang CuaHang { get; set; }
        public ChucVu ChucVu { get; set; }
        public ICollection<HoaDon> HoaDon { get; set; }
    }
}
