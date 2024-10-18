using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sosiska.Migrations
{
    /// <inheritdoc />
    public partial class Five : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "OrderId");

            migrationBuilder.AddColumn<int>(
                name: "CookerID",
                table: "Dishes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CookerID",
                table: "Dishes");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Orders",
                newName: "Id");
        }
    }
}
