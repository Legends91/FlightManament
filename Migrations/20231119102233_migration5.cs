using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLBH.Migrations
{
    /// <inheritdoc />
    public partial class migration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_ChuyenBays_ChuyenBayID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderTicket_Customers_CustomerID",
                table: "OrderTicket");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ChuyenBays_ChuyenBayID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ChuyenBayID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ChuyenBayID",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderTicket",
                table: "OrderTicket");

            migrationBuilder.DeleteData(
                table: "SanBays",
                keyColumn: "SanBayID",
                keyValue: "DAD");

            migrationBuilder.DeleteData(
                table: "SanBays",
                keyColumn: "SanBayID",
                keyValue: "HAN");

            migrationBuilder.DeleteData(
                table: "SanBays",
                keyColumn: "SanBayID",
                keyValue: "HPH");

            migrationBuilder.DeleteData(
                table: "SanBays",
                keyColumn: "SanBayID",
                keyValue: "HUI");

            migrationBuilder.DeleteData(
                table: "SanBays",
                keyColumn: "SanBayID",
                keyValue: "PQC");

            migrationBuilder.DeleteData(
                table: "SanBays",
                keyColumn: "SanBayID",
                keyValue: "SGN");

            migrationBuilder.DropColumn(
                name: "ChuyenBayID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ChuyenBayID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "ChuyenBays");

            migrationBuilder.RenameTable(
                name: "OrderTicket",
                newName: "OrderTickets");

            migrationBuilder.RenameIndex(
                name: "IX_OrderTicket_CustomerID",
                table: "OrderTickets",
                newName: "IX_OrderTickets_CustomerID");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "OrderTickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderTickets",
                table: "OrderTickets",
                column: "OrderTicketID");

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketID);
                });

            migrationBuilder.CreateTable(
                name: "OrderTicketDetails",
                columns: table => new
                {
                    OrderTicketDetailID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderTicketID = table.Column<long>(type: "bigint", nullable: false),
                    TicketID = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTicketDetails", x => x.OrderTicketDetailID);
                    table.ForeignKey(
                        name: "FK_OrderTicketDetails_OrderTickets_OrderTicketID",
                        column: x => x.OrderTicketID,
                        principalTable: "OrderTickets",
                        principalColumn: "OrderTicketID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderTicketDetails_Tickets_TicketID",
                        column: x => x.TicketID,
                        principalTable: "Tickets",
                        principalColumn: "TicketID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 1L,
                columns: new[] { "SanBayDen", "SanBayDi", "ThoiGianDi" },
                values: new object[] { "SG", "HN", new TimeSpan(0, 7, 15, 0, 0) });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 2L,
                columns: new[] { "SanBayDen", "SanBayDi" },
                values: new object[] { "HUE", "DN" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 3L,
                columns: new[] { "SanBayDen", "SanBayDi" },
                values: new object[] { "HN", "HP" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 4L,
                columns: new[] { "SanBayDen", "SanBayDi" },
                values: new object[] { "HUE", "SG" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 5L,
                columns: new[] { "SanBayDen", "SanBayDi" },
                values: new object[] { "DN", "KG" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 6L,
                columns: new[] { "SanBayDen", "SanBayDi" },
                values: new object[] { "KG", "HUE" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 7L,
                columns: new[] { "SanBayDen", "SanBayDi" },
                values: new object[] { "HN", "HUE" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 8L,
                columns: new[] { "SanBayDen", "SanBayDi" },
                values: new object[] { "DN", "SG" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 9L,
                columns: new[] { "SanBayDen", "SanBayDi" },
                values: new object[] { "HP", "KG" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 10L,
                columns: new[] { "ProductID", "SanBayDen", "SanBayDi" },
                values: new object[] { 7L, "HP", "DN" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 11L,
                columns: new[] { "SanBayDen", "SanBayDi" },
                values: new object[] { "SG", "HP" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 12L,
                columns: new[] { "SanBayDen", "SanBayDi" },
                values: new object[] { "SG", "HUE" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 13L,
                columns: new[] { "ProductID", "SanBayDen", "SanBayDi" },
                values: new object[] { 7L, "DN", "HN" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 14L,
                columns: new[] { "SanBayDen", "SanBayDi" },
                values: new object[] { "SG", "KG" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 15L,
                columns: new[] { "SanBayDen", "SanBayDi" },
                values: new object[] { "HUE", "HP" });

            migrationBuilder.InsertData(
                table: "OrderTickets",
                columns: new[] { "OrderTicketID", "ChuyenBayID", "CustomerID", "Description", "OrderDate" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, "khách không ăn thịt đỏ", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, 1L, 2L, "Khách ăn chay", new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, 2L, 3L, "Khách có vấn đề về thận (bạn Én)", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, 2L, 4L, "Khách VIP", new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, 7L, 5L, "Khách ăn chay", new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, 10L, 6L, "Khách là người già cần hỗ trợ kỹ lưỡng", new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, 15L, 7L, "Khách ăn chay", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, 8L, 8L, "Khách không ăn thịt đỏ", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9L, 9L, 9L, "Khách ăn chay", new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10L, 14L, 10L, "Khách VIP", new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11L, 1L, 11L, "Khách VIP", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12L, 4L, 12L, "Khách VIP", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13L, 11L, 13L, "Khách không ăn thịt đỏ", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14L, 12L, 14L, "Khách mang thai", new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15L, 8L, 15L, "Khách ăn chay", new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "SanBays",
                columns: new[] { "SanBayID", "Address", "TenSanBay" },
                values: new object[,]
                {
                    { "DN", "Đà Nẵng", "Quốc Tế Đà Nẵng" },
                    { "HN", "Hà Nội", "Quốc Tế Nội Bài" },
                    { "HP", "Hải Phòng", "Quốc Tế Cát Bi" },
                    { "HUE", "Huế", "Quốc Tế Phú Bài" },
                    { "KG", "Kiên Giang", "Quốc Tế Phú Quốc" },
                    { "SG", "TP HCM", "Quốc Tế Tân Sân Nhất" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketID", "Name", "Price" },
                values: new object[,]
                {
                    { 1L, "Vé Thường", 500.000m },
                    { 2L, "Vé Phổ Thông", 350.000m },
                    { 3L, "Vé Kinh Doanh", 800.000m },
                    { 4L, "Vé Hạng Nhất", 1500.000m },
                    { 5L, "Vé Economic", 450.000m },
                    { 6L, "Vé Premium Economy", 700.000m },
                    { 7L, "Vé Business Class", 1200.000m },
                    { 8L, "Vé First Class", 2000.000m },
                    { 9L, "Vé Cơ Bản", 300.000m },
                    { 10L, "Vé Tiết Kiệm", 250.000m },
                    { 11L, "Vé Linh Hoạt", 400.000m },
                    { 12L, "Vé Super Saver", 220.000m },
                    { 13L, "Vé Thương Gia", 1000.000m }
                });

            migrationBuilder.InsertData(
                table: "OrderTicketDetails",
                columns: new[] { "OrderTicketDetailID", "OrderDate", "OrderTicketID", "Price", "Quantity", "Status", "TicketID" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 500.000m, 1, true, 1L },
                    { 2L, new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, 500.000m, 3, true, 1L },
                    { 3L, new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3L, 350.000m, 1, false, 2L },
                    { 4L, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L, 400.000m, 1, true, 11L },
                    { 5L, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L, 300.000m, 1, true, 9L },
                    { 6L, new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L, 200.000m, 1, false, 7L },
                    { 7L, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7L, 350.000m, 4, true, 2L },
                    { 8L, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 8L, 450.000m, 1, true, 5L },
                    { 9L, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L, 220.000m, 1, false, 12L },
                    { 10L, new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 10L, 1000.000m, 1, true, 13L },
                    { 11L, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 11L, 220.000m, 1, true, 12L },
                    { 12L, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 12L, 500.000m, 1, true, 1L },
                    { 13L, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 13L, 700.000m, 1, false, 6L },
                    { 14L, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14L, 300.000m, 2, true, 9L },
                    { 15L, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 15L, 2000.000m, 2, true, 8L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenBays_ProductID",
                table: "ChuyenBays",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTickets_ChuyenBayID",
                table: "OrderTickets",
                column: "ChuyenBayID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTicketDetails_OrderTicketID",
                table: "OrderTicketDetails",
                column: "OrderTicketID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTicketDetails_TicketID",
                table: "OrderTicketDetails",
                column: "TicketID");

            migrationBuilder.AddForeignKey(
                name: "FK_ChuyenBays_Products_ProductID",
                table: "ChuyenBays",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTickets_ChuyenBays_ChuyenBayID",
                table: "OrderTickets",
                column: "ChuyenBayID",
                principalTable: "ChuyenBays",
                principalColumn: "ChuyenBayID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTickets_Customers_CustomerID",
                table: "OrderTickets",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChuyenBays_Products_ProductID",
                table: "ChuyenBays");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderTickets_ChuyenBays_ChuyenBayID",
                table: "OrderTickets");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderTickets_Customers_CustomerID",
                table: "OrderTickets");

            migrationBuilder.DropTable(
                name: "OrderTicketDetails");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_ChuyenBays_ProductID",
                table: "ChuyenBays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderTickets",
                table: "OrderTickets");

            migrationBuilder.DropIndex(
                name: "IX_OrderTickets_ChuyenBayID",
                table: "OrderTickets");

            migrationBuilder.DeleteData(
                table: "OrderTickets",
                keyColumn: "OrderTicketID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "OrderTickets",
                keyColumn: "OrderTicketID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "OrderTickets",
                keyColumn: "OrderTicketID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "OrderTickets",
                keyColumn: "OrderTicketID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "OrderTickets",
                keyColumn: "OrderTicketID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "OrderTickets",
                keyColumn: "OrderTicketID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "OrderTickets",
                keyColumn: "OrderTicketID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "OrderTickets",
                keyColumn: "OrderTicketID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "OrderTickets",
                keyColumn: "OrderTicketID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "OrderTickets",
                keyColumn: "OrderTicketID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "OrderTickets",
                keyColumn: "OrderTicketID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "OrderTickets",
                keyColumn: "OrderTicketID",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "OrderTickets",
                keyColumn: "OrderTicketID",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "OrderTickets",
                keyColumn: "OrderTicketID",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "OrderTickets",
                keyColumn: "OrderTicketID",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "SanBays",
                keyColumn: "SanBayID",
                keyValue: "DN");

            migrationBuilder.DeleteData(
                table: "SanBays",
                keyColumn: "SanBayID",
                keyValue: "HN");

            migrationBuilder.DeleteData(
                table: "SanBays",
                keyColumn: "SanBayID",
                keyValue: "HP");

            migrationBuilder.DeleteData(
                table: "SanBays",
                keyColumn: "SanBayID",
                keyValue: "HUE");

            migrationBuilder.DeleteData(
                table: "SanBays",
                keyColumn: "SanBayID",
                keyValue: "KG");

            migrationBuilder.DeleteData(
                table: "SanBays",
                keyColumn: "SanBayID",
                keyValue: "SG");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "OrderTickets");

            migrationBuilder.RenameTable(
                name: "OrderTickets",
                newName: "OrderTicket");

            migrationBuilder.RenameIndex(
                name: "IX_OrderTickets_CustomerID",
                table: "OrderTicket",
                newName: "IX_OrderTicket_CustomerID");

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

            migrationBuilder.AddColumn<long>(
                name: "EmployeeID",
                table: "ChuyenBays",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderTicket",
                table: "OrderTicket",
                column: "OrderTicketID");

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 1L,
                columns: new[] { "EmployeeID", "SanBayDen", "SanBayDi", "ThoiGianDi" },
                values: new object[] { 19L, "SGN", "HAN", new TimeSpan(0, 7, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 2L,
                columns: new[] { "EmployeeID", "SanBayDen", "SanBayDi" },
                values: new object[] { 18L, "HUI", "DAD" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 3L,
                columns: new[] { "EmployeeID", "SanBayDen", "SanBayDi" },
                values: new object[] { 13L, "HAN", "HPH" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 4L,
                columns: new[] { "EmployeeID", "SanBayDen", "SanBayDi" },
                values: new object[] { 10L, "HUI", "SGN" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 5L,
                columns: new[] { "EmployeeID", "SanBayDen", "SanBayDi" },
                values: new object[] { 14L, "DAD", "PQC" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 6L,
                columns: new[] { "EmployeeID", "SanBayDen", "SanBayDi" },
                values: new object[] { 13L, "PQC", "HUI" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 7L,
                columns: new[] { "EmployeeID", "SanBayDen", "SanBayDi" },
                values: new object[] { 8L, "HAN", "HUI" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 8L,
                columns: new[] { "EmployeeID", "SanBayDen", "SanBayDi" },
                values: new object[] { 12L, "DAD", "SGN" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 9L,
                columns: new[] { "EmployeeID", "SanBayDen", "SanBayDi" },
                values: new object[] { 9L, "HPH", "PQC" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 10L,
                columns: new[] { "EmployeeID", "ProductID", "SanBayDen", "SanBayDi" },
                values: new object[] { 7L, 17L, "HPH", "DAD" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 11L,
                columns: new[] { "EmployeeID", "SanBayDen", "SanBayDi" },
                values: new object[] { 2L, "SGN", "HPH" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 12L,
                columns: new[] { "EmployeeID", "SanBayDen", "SanBayDi" },
                values: new object[] { 14L, "SGN", "HUI" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 13L,
                columns: new[] { "EmployeeID", "ProductID", "SanBayDen", "SanBayDi" },
                values: new object[] { 8L, 16L, "DAD", "HAN" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 14L,
                columns: new[] { "EmployeeID", "SanBayDen", "SanBayDi" },
                values: new object[] { 17L, "SGN", "PQC" });

            migrationBuilder.UpdateData(
                table: "ChuyenBays",
                keyColumn: "ChuyenBayID",
                keyValue: 15L,
                columns: new[] { "EmployeeID", "SanBayDen", "SanBayDi" },
                values: new object[] { 15L, "HUI", "HPH" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_ChuyenBays_ChuyenBayID",
                table: "Employees",
                column: "ChuyenBayID",
                principalTable: "ChuyenBays",
                principalColumn: "ChuyenBayID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTicket_Customers_CustomerID",
                table: "OrderTicket",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ChuyenBays_ChuyenBayID",
                table: "Products",
                column: "ChuyenBayID",
                principalTable: "ChuyenBays",
                principalColumn: "ChuyenBayID");
        }
    }
}
