using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Third_ASP_EF_MVC.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceUnit",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PriceUnitPrice",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PriceUnit",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceUnitPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
