using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLBH.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImageFile = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1L, "Máy bay hạng trung" },
                    { 2L, "Máy bay hạng rộng mở rộng" },
                    { 3L, "Máy bay hạng nhẹ" },
                    { 4L, "Máy bay hạng rộng" },
                    { 5L, "Máy bay kỹ thuật số" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "ImageFile", "Manufacturer", "Name", "Status" },
                values: new object[,]
                {
                    { 1L, 1L, "1.png", "Airbus S.A.S", "Airbus A320", true },
                    { 2L, 1L, "2.png", "Airbus S.A.S", "Airbus A321", true },
                    { 3L, 2L, "3.png", "Boeing", "Boeing 787-9", true },
                    { 4L, 3L, "4.png", "Embraer", "Embraer E-Jet - E170", false },
                    { 5L, 4L, "5.png", "Boeing", "Boeing 767-300", false },
                    { 6L, 4L, "6.png", "Airbus S.A.S", "Airbus A330-200", true },
                    { 7L, 4L, "7.png", "Boeing", "Boeing 777-200", true },
                    { 8L, 3L, "8.png", "Embraer", "Embraer E-Jet - E175", true },
                    { 9L, 4L, "9.png", "Airbus S.A.S", "Airbus A330-300", true },
                    { 10L, 3L, "10.png", "Embraer", "Embraer E-Jet - E190", true },
                    { 11L, 2L, "11.png", "Airbus S.A.S", "Airbus A350 - 900", true },
                    { 12L, 3L, "12.png", "Embraer", "Embraer E-Jet E-195", true },
                    { 13L, 5L, "13.png", "China Eastern Airlines", "COMAC C919", false },
                    { 14L, 2L, "14.png", "Airbus S.A.S", "Airbus A350 - 1000", true },
                    { 15L, 3L, "15.png", "Air Mekong", "Bombardier CRJ-200", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
