using Microsoft.EntityFrameworkCore.Migrations;

namespace UTB.Eshop.Nagy.Web.Migrations
{
    public partial class _131_Update_database_and_syntax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Varanty",
                table: "Product",
                newName: "Warranty");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Warranty",
                table: "Product",
                newName: "Varanty");
        }
    }
}
