using Microsoft.EntityFrameworkCore.Migrations;

namespace UTB.Eshop.Nagy.Web.Migrations
{
    public partial class _111_Fix_image_src_mistake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DescriptionImageSrc", "imageSrc" },
                values: new object[] { "/img/product/descriptionImg/iPhone3G.jpg", "/img/product/homeImg/iPhone3G.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                column: "imageSrc",
                value: "/img/product/homeImg/Nokia3310.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DescriptionImageSrc", "imageSrc" },
                values: new object[] { "/img/product/descriptionImg/iPhone.jpg", "/img/product/homeImg/iPhone.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                column: "imageSrc",
                value: "/img/product/homeImg/Nokkia3310.jpg");
        }
    }
}
