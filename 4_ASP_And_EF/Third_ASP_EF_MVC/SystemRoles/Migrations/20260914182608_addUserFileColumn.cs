using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemRoles.Migrations
{
    /// <inheritdoc />
    public partial class addUserFileColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileURL",
                table: "userFiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileURL",
                table: "userFiles");
        }
    }
}
