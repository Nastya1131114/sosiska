using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sosiska.Migrations
{
    /// <inheritdoc />
    public partial class Четыре : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DishID",
                table: "Cookers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DishID",
                table: "Cookers");
        }
    }
}
