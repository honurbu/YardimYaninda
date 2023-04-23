using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BspAcademy.Repository.Migrations
{
    /// <inheritdoc />
    public partial class place_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "AidNotices",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Place",
                table: "AidNotices");
        }
    }
}
