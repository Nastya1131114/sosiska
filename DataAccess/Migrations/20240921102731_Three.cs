using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sosiska.Migrations
{
    /// <inheritdoc />
    public partial class Three : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Workers",
                newName: "WorkerId");

            migrationBuilder.RenameColumn(
                name: "GradeName",
                table: "Grades",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cookers",
                newName: "CookerId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Cookers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cookers_CategoryId",
                table: "Cookers",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cookers_Grades_CategoryId",
                table: "Cookers",
                column: "CategoryId",
                principalTable: "Grades",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cookers_Grades_CategoryId",
                table: "Cookers");

            migrationBuilder.DropIndex(
                name: "IX_Cookers_CategoryId",
                table: "Cookers");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Cookers");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "Workers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Grades",
                newName: "GradeName");

            migrationBuilder.RenameColumn(
                name: "CookerId",
                table: "Cookers",
                newName: "Id");
        }
    }
}
