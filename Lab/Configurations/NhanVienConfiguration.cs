using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab_1.Configurations
{
    public class NhanVienConfiguration:IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.HasOne(x => x.CuaHang).WithMany(x=>x.NhanVien).HasForeignKey(x=>x.IDCuaHang);
            builder.HasOne(x=>x.ChucVu).WithMany(x=>x.NhanVien).HasForeignKey(x=>x.IDChucVu);
        }
    }
}
