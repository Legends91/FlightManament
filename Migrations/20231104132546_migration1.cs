using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLBH.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CCCD = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "BirthDay", "CCCD", "Email", "Gender", "Name", "Phone" },
                values: new object[,]
                {
                    { 1L, new DateTime(2000, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "012345678901", "NguyenVanT@gmail.com", false, "Nguyễn Văn Thơ", "0757294361" },
                    { 2L, new DateTime(1999, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "068903241849", "THNT56565@email.com", true, "Trần Thị Hồng Ngọc", "0989102574" },
                    { 3L, new DateTime(1987, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "054321319302", "LeQuocSong@gmail.com", true, "Lê Quốc Ca", "0343671829" },
                    { 4L, new DateTime(2001, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "097654810294", "PhamAnhCope@email.com", true, "Phạm Anh Đồng", "0460492715" },
                    { 5L, new DateTime(1995, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "024683719492", "HoangHiBird@gmail.com", true, "Hoàng Thị Én", "0431568942" },
                    { 6L, new DateTime(1996, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "015793819201", "VuMinhFea@email.com", false, "Vũ Minh Phương", "0520873456" },
                    { 7L, new DateTime(1998, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "086420728192", "GiangBui@email.com", null, "Bùi Văn Giang", "0678941320" },
                    { 8L, new DateTime(1999, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "075314839292", "NgoThank@gmail.com", false, "Ngô Thanh Huyền", "0412456789" },
                    { 9L, new DateTime(1994, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "062082738592", "ThuThao123@email.com", true, "Đặng Thu Thảo", "0793502748" },
                    { 10L, new DateTime(1993, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "031425928473", "TamTu@gmail.com", true, "Trương Tâm Tú", "0736251849" },
                    { 11L, new DateTime(1992, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "076542819382", "HaiQuan@gmail.com", true, "Lâm Quang Khải", "0750781693" },
                    { 12L, new DateTime(1997, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "020987371284", "LaiHo@email.com", true, "Hồ Thị Lai", "0568923147" },
                    { 13L, new DateTime(1978, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "057898392012", "HoangMink@email.com", false, "Đỗ Hoàng Minh", "0424589310" },
                    { 14L, new DateTime(2003, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "013404859402", "ChildNkee@gmail.com", false, "Châu Minh Nhi", "0371820394" },
                    { 15L, new DateTime(2002, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "045672817492", "MaiTki@email.com", true, "Mai Thị Oanh", "0296047258" },
                    { 16L, new DateTime(2000, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "09760385748", "PinkHappy@gmail.com", false, "Nguyễn Hồng Phúc", "0512345678" },
                    { 17L, new DateTime(1984, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "05310758492", "LTTQuỳnh@email.com", true, "Lê Thị thanh Quỳnh", "0787463291" },
                    { 18L, new DateTime(1980, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "068904657322", "ThanhPhanTea@gmail.com", true, "Phan Thanh Trà", "0953127964" },
                    { 19L, new DateTime(1988, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "034567271392", "TranSVan@gmail.com", true, "Trần Văn Sĩ", "0974920518" },
                    { 20L, new DateTime(1993, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "080121839201", "ILoveHN@gmail.com", true, "Đinh Quốc Tuân", "0938562914" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
