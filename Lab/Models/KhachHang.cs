using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_1.Models
{
    public class KhachHang
    {
        public int ID { get; set; }
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string TenDemKH { get; set; }
        public string HoKH { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string ThanhPho { get; set; }
        public int MaCty { get; set; }
        public string TenCty { get; set; }
        public string Mst { get; set; }
        public int IDTrangThai { get; set; }
        public ICollection<HoaDon> HoaDon { get; set; }
    }
}
