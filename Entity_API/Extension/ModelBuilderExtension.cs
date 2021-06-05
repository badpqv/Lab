using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity_API.Extension
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student
                {Id = Guid.NewGuid(), Msv = "PH001", NamSinh = 2000, NganhHoc = "UPPM"});
            modelBuilder.Entity<Student>().HasData(new Student
                {Id = Guid.NewGuid(), Msv = "PH002", NamSinh = 2001, NganhHoc = "UPPM"});
            modelBuilder.Entity<Student>().HasData(new Student
                {Id = Guid.NewGuid(), Msv = "PH003", NamSinh = 2002, NganhHoc = "UPPM"});
        }
    }
}
