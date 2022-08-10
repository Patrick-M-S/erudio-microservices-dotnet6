using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 1L, "T-shirt", "m has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to mak", "https://images.pexels.com/photos/1844132/pexels-photo-1844132.jpeg?cs=srgb&dl=pexels-gabriela-pereira-1844132.jpg&fm=jpg", "Name", 69.9m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 1L);
        }
    }
}
