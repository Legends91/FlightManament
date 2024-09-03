using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLBH.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ChuyenBayID",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ChuyenBayID",
                table: "Employees",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderTicket",
                columns: table => new
                {
                    OrderTicketID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<long>(type: "bigint", nullable: false),
                    ChuyenBayID = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTicket", x => x.OrderTicketID);
                    table.ForeignKey(
                        name: "FK_OrderTicket_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanBays",
                columns: table => new
                {
                    SanBayID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenSanBay = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanBays", x => x.SanBayID);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenBays",
                columns: table => new
                {
                    ChuyenBayID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeID = table.Column<long>(type: "bigint", nullable: false),
                    SanBayDi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SanBayDen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGianDi = table.Column<TimeSpan>(type: "time", nullable: false),
                    ThoiGianDen = table.Column<TimeSpan>(type: "time", nullable: false),
                    SanBaysSanBayID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenBays", x => x.ChuyenBayID);
                    table.ForeignKey(
                        name: "FK_ChuyenBays_SanBays_SanBaysSanBayID",
                        column: x => x.SanBaysSanBayID,
                        principalTable: "SanBays",
                        principalColumn: "SanBayID");
                });

            migrationBuilder.InsertData(
                table: "ChuyenBays",
                columns: new[] { "ChuyenBayID", "EmployeeID", "ProductID", "SanBayDen", "SanBayDi", "SanBaysSanBayID", "ThoiGianDen", "ThoiGianDi" },
                values: new object[,]
                {
                    { 1L, 4L, 8L, "SGN", "HAN", null, new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 7, 30, 0, 0) },
                    { 2L, 11L, 11L, "HUI", "DAD", null, new TimeSpan(0, 19, 30, 0, 0), new TimeSpan(0, 18, 30, 0, 0) },
                    { 3L, 13L, 7L, "HAN", "HPH", null, new TimeSpan(0, 7, 0, 0, 0), new TimeSpan(0, 5, 30, 0, 0) },
                    { 4L, 10L, 1L, "HUI", "SGN", null, new TimeSpan(0, 22, 0, 0, 0), new TimeSpan(0, 20, 30, 0, 0) },
                    { 5L, 14L, 15L, "DAD", "PQC", null, new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 14, 0, 0, 0) },
                    { 6L, 13L, 14L, "PQC", "HUI", null, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 11, 30, 0, 0) },
                    { 7L, 8L, 15L, "HAN", "HUI", null, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 15, 30, 0, 0) },
                    { 8L, 12L, 1L, "DAD", "SGN", null, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 9L, 9L, 9L, "HPH", "PQC", null, new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 0, 0, 0) },
                    { 10L, 7L, 7L, "HPH", "DAD", null, new TimeSpan(0, 8, 30, 0, 0), new TimeSpan(0, 6, 30, 0, 0) },
                    { 11L, 2L, 15L, "SGN", "HPH", null, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 12L, 14L, 8L, "SGN", "HUI", null, new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0) },
                    { 13L, 8L, 7L, "DAD", "HAN", null, new TimeSpan(0, 1, 30, 0, 0), new TimeSpan(0, 23, 0, 0, 0) },
                    { 14L, 12L, 6L, "SGN", "PQC", null, new TimeSpan(0, 5, 30, 0, 0), new TimeSpan(0, 4, 0, 0, 0) },
                    { 15L, 15L, 3L, "HUI", "HPH", null, new TimeSpan(0, 20, 30, 0, 0), new TimeSpan(0, 19, 0, 0, 0) }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 4L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 5L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 6L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 7L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 8L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 9L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 10L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 11L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 12L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 13L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 14L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 15L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 16L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 15L,
                column: "ChuyenBayID",
                value: null);

            migrationBuilder.InsertData(
                table: "SanBays",
                columns: new[] { "SanBayID", "Address", "TenSanBay" },
                values: new object[,]
                {
                    { "DAD", "Đà Nẵng", "Quốc Tế Đà Nẵng" },
                    { "HAN", "Hà Nội", "Quốc Tế Nội Bài" },
                    { "HPH", "Hải Phòng", "Quốc Tế Cát Bi" },
                    { "HUI", "Huế", "Quốc Tế Phú Bài" },
                    { "PQC", "Kiên Giang", "Quốc Tế Phú Quốc" },
                    { "SGN", "TP HCM", "Quốc Tế Tân Sân Nhất" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ChuyenBayID",
                table: "Products",
                column: "ChuyenBayID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ChuyenBayID",
                table: "Employees",
                column: "ChuyenBayID");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenBays_SanBaysSanBayID",
                table: "ChuyenBays",
                column: "SanBaysSanBayID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTicket_CustomerID",
                table: "OrderTicket",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_ChuyenBays_ChuyenBayID",
                table: "Employees",
                column: "ChuyenBayID",
                principalTable: "ChuyenBays",
                principalColumn: "ChuyenBayID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ChuyenBays_ChuyenBayID",
                table: "Products",
                column: "ChuyenBayID",
                principalTable: "ChuyenBays",
                principalColumn: "ChuyenBayID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_ChuyenBays_ChuyenBayID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ChuyenBays_ChuyenBayID",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ChuyenBays");

            migrationBuilder.DropTable(
                name: "OrderTicket");

            migrationBuilder.DropTable(
                name: "SanBays");

            migrationBuilder.DropIndex(
                name: "IX_Products_ChuyenBayID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ChuyenBayID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ChuyenBayID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ChuyenBayID",
                table: "Employees");
        }
    }
}
