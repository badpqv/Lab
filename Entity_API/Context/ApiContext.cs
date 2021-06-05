using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity_API.Configurations;
using Entity_API.Extension;
using Entity_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity_API.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentCfg());
            modelBuilder.Seed();
        }

        public DbSet<Student> Student { get; set; }
    }
}
