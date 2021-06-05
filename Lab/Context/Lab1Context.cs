using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_1.Configurations;
using Lab_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab_1.Context
{
    public class Lab1Context:DbContext
    {
        public DbSet<PhieuBaoHanh> PhieuBaoHanhs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<CuaHang> CuaHangs { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<DongSanPham> DongSanPhams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<ThuongHieu> ThuongHieus { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChucVuConfiguration());
            modelBuilder.ApplyConfiguration(new CuaHangConfiguration());
            modelBuilder.ApplyConfiguration(new DongSanPhamConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonChiTietConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonChiTietConfiguration());
            modelBuilder.ApplyConfiguration(new KhachHangConfiguration());
            modelBuilder.ApplyConfiguration(new NhanVienConfiguration());
            modelBuilder.ApplyConfiguration(new PhieuBaoHanhConfiguration());
            modelBuilder.ApplyConfiguration(new SanPhamConfiguration());
            modelBuilder.ApplyConfiguration(new ThuongHieuConfiguration());
        }
        public Lab1Context(DbContextOptions<Lab1Context> options):base(options)
        {
            
        }
    }
}
