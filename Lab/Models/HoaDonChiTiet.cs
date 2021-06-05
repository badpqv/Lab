using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_1.Models
{
    public class HoaDonChiTiet
    {
        public int IDHoaDon { get; set; }
        public int IDSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public SanPham SanPham { get; set; }
        public HoaDon HoaDon { get; set; }
    }
}
