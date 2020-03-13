using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "ADV", "Adventure" },
                    { "ACT", "Action" },
                    { "ROL", "Role" },
                    { "STR", "Strategy" },
                    { "SPR", "Sports" },
                    { "PZZ", "Puzzle" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "d8a3fad6-5846-4dd6-8efa-43a28d2baeb7", "932 Pallet Street, La Grange (Dutchess), NY 12540", "Main Warehouse" },
                    { "21a8d04a-946f-4724-8bc1-dd0411b3c83e", "4447 Dane Street, Yakima, WA 98908", "Second Warehouse" },
                    { "e5e77390-337e-4cfd-93c4-26e76c1967c6", "3003 Arrowood Drive, Jacksonville, FL 32257", "Third Warehouse" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ACT");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ADV");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "PZZ");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ROL");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "SPR");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "STR");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "21a8d04a-946f-4724-8bc1-dd0411b3c83e");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "d8a3fad6-5846-4dd6-8efa-43a28d2baeb7");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "e5e77390-337e-4cfd-93c4-26e76c1967c6");
        }
    }
}
