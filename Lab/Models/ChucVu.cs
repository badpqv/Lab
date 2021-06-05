using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_1.Models
{
    public class ChucVu
    {
        public int ID { get; set; }
        public int MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public ICollection<NhanVien> NhanVien { get; set; }
    }
}
