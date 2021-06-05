using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_1.Models
{
    public class PhieuBaoHanh
    {
        public int ID { get; set; }
        public int MaPhieu { get; set; }
        public int IDSanPham { get; set; }
    
        public int IDHoaDon { get; set; }

        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string MoTa { get; set; }
        public string IMEI { get; set; }
        public int IDTrangThai { get; set; }
        public SanPham SanPham { get; set; }
        public HoaDon HoaDon { get; set; }
    }
}
