using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab_1.Migrations
{
    public partial class AddtableV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaChucVu = table.Column<int>(nullable: false),
                    TenChucVu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CuaHang",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCH = table.Column<int>(nullable: false),
                    TenCH = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    ThanhPho = table.Column<string>(nullable: true),
                    QuocGia = table.Column<string>(nullable: true),
                    IDTrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuaHang", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DongSanPham",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDSP = table.Column<int>(nullable: false),
                    TenDSP = table.Column<string>(nullable: true),
                    IDTrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongSanPham", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKH = table.Column<int>(nullable: false),
                    TenKH = table.Column<string>(nullable: true),
                    TenDemKH = table.Column<string>(nullable: true),
                    HoKH = table.Column<string>(nullable: true),
                    GioiTinh = table.Column<string>(nullable: true),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    DiaChi = table.Column<string>(nullable: true),
                    SDT = table.Column<string>(nullable: true),
                    ThanhPho = table.Column<string>(nullable: true),
                    MaCty = table.Column<int>(nullable: false),
                    TenCty = table.Column<string>(nullable: true),
                    Mst = table.Column<string>(nullable: true),
                    IDTrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ThuongHieu",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTH = table.Column<int>(nullable: false),
                    TenTH = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    IDTrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongHieu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCuaHang = table.Column<int>(nullable: false),
                    MaNv = table.Column<int>(nullable: false),
                    TenNv = table.Column<string>(nullable: true),
                    HoNv = table.Column<string>(nullable: true),
                    TenDemNv = table.Column<string>(nullable: true),
                    GioiTinh = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    LuongNv = table.Column<decimal>(nullable: false),
                    Sdt = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IDChucVu = table.Column<int>(nullable: false),
                    IDTrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IDChucVu",
                        column: x => x.IDChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanVien_CuaHang_IDCuaHang",
                        column: x => x.IDCuaHang,
                        principalTable: "CuaHang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSP = table.Column<int>(nullable: false),
                    TenSP = table.Column<string>(nullable: true),
                    ManHinh = table.Column<string>(nullable: true),
                    MoTaSP = table.Column<string>(nullable: true),
                    TrongLuongSP = table.Column<int>(nullable: false),
                    GiaNhap = table.Column<decimal>(nullable: false),
                    GiaBan = table.Column<decimal>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    IDDongSP = table.Column<int>(nullable: false),
                    IDThuongHieu = table.Column<int>(nullable: false),
                    IDTrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SanPham_DongSanPham_IDDongSP",
                        column: x => x.IDDongSP,
                        principalTable: "DongSanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_ThuongHieu_IDThuongHieu",
                        column: x => x.IDThuongHieu,
                        principalTable: "ThuongHieu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDKhachHang = table.Column<int>(nullable: false),
                    IDNhanVien = table.Column<int>(nullable: false),
                    MaHD = table.Column<int>(nullable: false),
                    NgayTaoHD = table.Column<DateTime>(nullable: false),
                    NgayThanhToanHD = table.Column<DateTime>(nullable: false),
                    NgayShipHang = table.Column<DateTime>(nullable: false),
                    NgayNhanHang = table.Column<DateTime>(nullable: false),
                    DiaChiGiaoHang = table.Column<string>(nullable: true),
                    IDTrangThai = table.Column<int>(nullable: false),
                    NhanVienID = table.Column<int>(nullable: true),
                    KhachHangID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHang_KhachHangID",
                        column: x => x.KhachHangID,
                        principalTable: "KhachHang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDons_NhanVien_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    IDHoaDon = table.Column<int>(nullable: false),
                    IDSanPham = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    DonGia = table.Column<decimal>(nullable: false),
                    SanPhamID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => new { x.IDHoaDon, x.IDSanPham });
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDons_IDHoaDon",
                        column: x => x.IDHoaDon,
                        principalTable: "HoaDons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_SanPham_SanPhamID",
                        column: x => x.SanPhamID,
                        principalTable: "SanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhieuBaoHanh",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhieu = table.Column<int>(nullable: false),
                    IDSanPham = table.Column<int>(nullable: false),
                    IDHoaDon = table.Column<int>(nullable: false),
                    NgayBatDau = table.Column<DateTime>(nullable: false),
                    NgayKetThuc = table.Column<DateTime>(nullable: false),
                    MoTa = table.Column<string>(nullable: true),
                    IMEI = table.Column<string>(nullable: true),
                    IDTrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuBaoHanh", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhieuBaoHanh_HoaDons_IDHoaDon",
                        column: x => x.IDHoaDon,
                        principalTable: "HoaDons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuBaoHanh_SanPham_IDSanPham",
                        column: x => x.IDSanPham,
                        principalTable: "SanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_SanPhamID",
                table: "HoaDonChiTiet",
                column: "SanPhamID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_KhachHangID",
                table: "HoaDons",
                column: "KhachHangID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_NhanVienID",
                table: "HoaDons",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IDChucVu",
                table: "NhanVien",
                column: "IDChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IDCuaHang",
                table: "NhanVien",
                column: "IDCuaHang");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuBaoHanh_IDHoaDon",
                table: "PhieuBaoHanh",
                column: "IDHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuBaoHanh_IDSanPham",
                table: "PhieuBaoHanh",
                column: "IDSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IDDongSP",
                table: "SanPham",
                column: "IDDongSP");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IDThuongHieu",
                table: "SanPham",
                column: "IDThuongHieu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "PhieuBaoHanh");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "DongSanPham");

            migrationBuilder.DropTable(
                name: "ThuongHieu");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "CuaHang");
        }
    }
}
