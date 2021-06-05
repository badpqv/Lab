using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab_1.Configurations
{
    public class HoaDonChiTietConfiguration:IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(x => new {x.IDHoaDon, x.IDSanPham});
            builder.HasOne(x => x.HoaDon).WithMany(x => x.HoaDonChiTiet).HasForeignKey(x => x.IDHoaDon);
        }
    }
}
