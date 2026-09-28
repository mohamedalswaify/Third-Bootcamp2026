using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Third_ASP_EF_MVC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addUIDUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UID",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UID",
                table: "Users");
        }
    }
}
