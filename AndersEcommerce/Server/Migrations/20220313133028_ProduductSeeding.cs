using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AndersEcommerce.Server.Migrations
{
    public partial class ProduductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Vår bipollen hjälper till med att öppna upp lungornas alveoler rejält.", "https://fincasolmark.com/wp-content/uploads/2021/07/finca-solmark-bipollen-225g.jpg", 150.50m, "Bipollen" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Vår unika avokadohonung passar perfekt till rejäla ostar och att marinera köttbitar med.", "https://fincasolmark.com/wp-content/uploads/2020/10/finca-solmark-honung-avokado-1.jpg", 129.99m, "Honung Avokado" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Vår mest populära honung kommer från blommorna på berget ovanför gården.", "https://fincasolmark.com/wp-content/uploads/2020/10/finca-solmark-honung-bergsblommor-1.jpg", 89.99m, "Honung Bergsblommor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
