using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_1.Models
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int IDKhachHang { get; set; }
        public int IDNhanVien { get; set; }
        public int MaHD { get; set; }
        public DateTime NgayTaoHD { get; set; }
        public DateTime NgayThanhToanHD { get; set; }
        public DateTime NgayShipHang { get; set; }
        public DateTime NgayNhanHang { get; set; }
        public string DiaChiGiaoHang { get; set; }
        public int IDTrangThai { get; set; }
        public NhanVien NhanVien { get; set; }
        public KhachHang KhachHang { get; set; }
        public ICollection<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        public ICollection<PhieuBaoHanh> PhieuBaoHanh { get; set; }
    }
}
