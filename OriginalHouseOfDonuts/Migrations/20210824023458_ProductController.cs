using Microsoft.EntityFrameworkCore.Migrations;

namespace OriginalHouseOfDonuts.Migrations
{
    public partial class ProductController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Products",
                newName: "ItemTitle");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "ItemPrice");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemTitle",
                table: "Products",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ItemPrice",
                table: "Products",
                newName: "Price");
        }
    }
}
