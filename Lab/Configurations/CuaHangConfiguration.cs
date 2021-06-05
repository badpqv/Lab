using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab_1.Configurations
{
    public class CuaHangConfiguration:IEntityTypeConfiguration<CuaHang>
    {
        public void Configure(EntityTypeBuilder<CuaHang> builder)
        {
            builder.ToTable("CuaHang");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
        }
    }
}
