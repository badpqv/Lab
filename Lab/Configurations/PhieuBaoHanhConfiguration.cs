using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Lab_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab_1.Configurations
{
    public class PhieuBaoHanhConfiguration:IEntityTypeConfiguration<PhieuBaoHanh>
    {
        public void Configure(EntityTypeBuilder<PhieuBaoHanh> builder)
        {
            builder.ToTable("PhieuBaoHanh");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.HasOne(x => x.HoaDon).WithMany(x => x.PhieuBaoHanh).HasForeignKey(x => x.IDHoaDon);
            builder.HasOne(x => x.SanPham).WithMany(x => x.PhieuBaoHanh).HasForeignKey(x => x.IDSanPham);
        }
    }
}
