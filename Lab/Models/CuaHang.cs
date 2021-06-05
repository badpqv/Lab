using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_1.Models
{
    public class CuaHang
    {
        public int ID { get; set; }
        public int MaCH { get; set; }
        public string TenCH { get; set; }
        public string DiaChi { get; set; }
        public string ThanhPho { get; set; }
        public string QuocGia { get; set; }
        public int IDTrangThai { get; set; }
        public ICollection<NhanVien> NhanVien { get; set; }
    }
}
