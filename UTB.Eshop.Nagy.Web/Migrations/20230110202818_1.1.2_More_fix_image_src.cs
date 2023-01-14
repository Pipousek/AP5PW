using Microsoft.EntityFrameworkCore.Migrations;

namespace UTB.Eshop.Nagy.Web.Migrations
{
    public partial class _112_More_fix_image_src : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                column: "DescriptionImageSrc",
                value: "/img/product/descriptionImg/Nokia3310.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                column: "DescriptionImageSrc",
                value: "/img/product/descriptionImg/Nokkia3310.jpg");
        }
    }
}
