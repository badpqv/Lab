using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab_1.Configurations
{
    public class SanPhamConfiguration:IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPham");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.HasOne(x => x.ThuongHieu).WithMany(x => x.SanPham).HasForeignKey(x => x.IDThuongHieu);
            builder.HasOne(x => x.DongSP).WithMany(x => x.SanPham).HasForeignKey(x => x.IDDongSP);
        }
    }
}
