using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_1.Models
{
    public class ThuongHieu
    {
        [Key]
        public int ID { get; set; }
        public int MaTH { get; set; }
        public string TenTH { get; set; }
        public string Website { get; set; }
        public int IDTrangThai { get; set; }
        public ICollection<SanPham> SanPham { get; set; }
    }
}
