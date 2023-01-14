using Microsoft.EntityFrameworkCore.Migrations;

namespace UTB.Eshop.Nagy.Web.Migrations
{
    public partial class _123_Update_database_photos_and_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                column: "Price",
                value: 7999.8999999999996);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                column: "Price",
                value: 0.0);
        }
    }
}
