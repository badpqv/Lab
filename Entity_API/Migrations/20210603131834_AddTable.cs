using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity_API.Migrations
{
    public partial class AddTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Msv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamSinh = table.Column<int>(type: "int", nullable: false),
                    NganhHoc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Msv", "NamSinh", "NganhHoc" },
                values: new object[] { new Guid("240195ba-a1e8-4400-8ecf-f558efa726fc"), "PH001", 2000, "UPPM" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Msv", "NamSinh", "NganhHoc" },
                values: new object[] { new Guid("4e29f593-f2da-4c3a-b82b-7f1e1696bacb"), "PH002", 2001, "UPPM" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Msv", "NamSinh", "NganhHoc" },
                values: new object[] { new Guid("8e1c787d-5c87-45cb-97ef-385b1ad3b01b"), "PH003", 2002, "UPPM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
