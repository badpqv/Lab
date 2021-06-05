﻿// <auto-generated />
using System;
using Entity_API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entity_API.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity_API.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Msv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NamSinh")
                        .HasColumnType("int");

                    b.Property<string>("NganhHoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = new Guid("240195ba-a1e8-4400-8ecf-f558efa726fc"),
                            Msv = "PH001",
                            NamSinh = 2000,
                            NganhHoc = "UPPM"
                        },
                        new
                        {
                            Id = new Guid("4e29f593-f2da-4c3a-b82b-7f1e1696bacb"),
                            Msv = "PH002",
                            NamSinh = 2001,
                            NganhHoc = "UPPM"
                        },
                        new
                        {
                            Id = new Guid("8e1c787d-5c87-45cb-97ef-385b1ad3b01b"),
                            Msv = "PH003",
                            NamSinh = 2002,
                            NganhHoc = "UPPM"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
