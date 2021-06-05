using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity_API.Configurations
{
    public class StudentCfg:IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.HasKey(x => x.Id);
        }
    }
}
