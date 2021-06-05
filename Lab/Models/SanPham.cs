using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_1.Models
{
    public class SanPham
    {
        [Key]
        public int ID { get; set; }
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string ManHinh { get; set; }
        public string MoTaSP { get; set; }
        public int TrongLuongSP { get; set; }  
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public int IDDongSP { get; set; }
        public int IDThuongHieu { get; set; }
        public int IDTrangThai { get; set; }
        public ThuongHieu ThuongHieu { get; set; }
        public DongSanPham DongSP { get; set; }
        public ICollection<PhieuBaoHanh> PhieuBaoHanh { get; set; }
    }
}
