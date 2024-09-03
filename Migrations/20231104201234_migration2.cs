using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLBH.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "Date", nullable: false),
                    DayWork = table.Column<DateTime>(type: "Date", nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    RoleID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5L,
                column: "Email",
                value: "HoangTHiBird@gmail.com");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 18L,
                column: "Email",
                value: "ThanhPhanTea@gmail.com");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Name" },
                values: new object[,]
                {
                    { 1L, "Tổng quản lý" },
                    { 2L, "Quản lý chuyến bay" },
                    { 3L, "Quản lý phi công" },
                    { 4L, "Quản lý hành khách" },
                    { 5L, "Phi công" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "BirthDay", "CCCD", "DayWork", "Email", "Gender", "Name", "Password", "Phone", "RoleID" },
                values: new object[,]
                {
                    { 1L, new DateTime(1993, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "079203024793", new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "nva@email.com", true, "Đỗ Bình An", "111", "0987654321", 1L },
                    { 2L, new DateTime(1988, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "079203024794", new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ttb@email.com", false, "Trần Thị Khánh Bâng", "111", "0901234567", 2L },
                    { 3L, new DateTime(1980, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "079203024795", new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "lqc@email.com", true, "Lê Quốc Cảnh", "111", "0912345678", 2L },
                    { 4L, new DateTime(1984, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "079203024796", new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "pad@email.com", true, "Phạm Anh Dũng", "111", "0923456789", 3L },
                    { 5L, new DateTime(2000, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "079203024797", new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "hte@email.com", false, "Emily Hoàng Thị", "111", "0934567890", 3L },
                    { 6L, new DateTime(2002, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "079203024798", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "vmf@email.com", true, "Vũ Minh Toàn", "111", "0945678901", 4L },
                    { 7L, new DateTime(2003, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "079203024799", new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "bvng@email.com", true, "Bùi Văn Nghị", "111", "0956789012", 4L },
                    { 8L, new DateTime(1978, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "079203024800", new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "nth@email.com", true, "Hoàng Hưu Hảo", "111", "0967890123", 5L },
                    { 9L, new DateTime(1997, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "079203024801", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "dti@email.com", false, "Đặng Thu Lam", "111", "0978901234", 5L },
                    { 10L, new DateTime(1993, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "079203024802", new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ttjudge@email.com", false, "Trương Tâm Trạng", "111", "0989012345", 5L },
                    { 11L, new DateTime(1994, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "079203024803", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "lqk@email.com", true, "Lâm Quang Lưu", "111", "0990123456", 5L },
                    { 12L, new DateTime(1999, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "079203024804", new DateTime(2003, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "htl@email.com", false, "Hồ Thị Liên", "111", "0901234567", 5L },
                    { 13L, new DateTime(1998, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "079203024805", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "dhm@email.com", true, "Đỗ Hoàng Hảo", "111", "0912345678", 5L },
                    { 14L, new DateTime(1996, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "079203024806", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "cmn@email.com", true, "Châu Minh Tiến", "111", "0923456789", 5L },
                    { 15L, new DateTime(1995, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "079203024807", new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "mto@email.com", false, "Mai Thị Thu Hoàng", "111", "0934567890", 5L },
                    { 16L, new DateTime(2001, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "079203024808", new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "nhp@email.com", false, "Nguyễn Hồng", "111", "0945678901", 5L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RoleID",
                table: "Employees",
                column: "RoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5L,
                column: "Email",
                value: "HoangHiBird@gmail.com");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 18L,
                column: "Email",
                value: "ThanhPhanTea @gmail.com");
        }
    }
}
