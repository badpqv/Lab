using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab_1.Configurations
{
    public class HoaDonConfiguration:IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.HasOne(x => x.NhanVien).WithMany(x => x.HoaDon).HasForeignKey(x => x.IDNhanVien);
            builder.HasOne(x => x.KhachHang).WithMany(x => x.HoaDon).HasForeignKey(x => x.IDKhachHang);
        }
    }
}
