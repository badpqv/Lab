using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_1.Models
{
    public class DongSanPham
    {
        public int ID { get; set; }
        public int MaDSP { get; set; }
        public string TenDSP { get; set; }
        public int IDTrangThai { get; set; }
        public ICollection<SanPham> SanPham { get; set; }
    }
}
