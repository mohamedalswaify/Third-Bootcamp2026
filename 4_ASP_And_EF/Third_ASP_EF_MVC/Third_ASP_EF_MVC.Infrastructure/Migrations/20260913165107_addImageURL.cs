using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Third_ASP_EF_MVC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addImageURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Users");
        }
    }
}
