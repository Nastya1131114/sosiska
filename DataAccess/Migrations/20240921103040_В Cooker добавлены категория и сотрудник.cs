using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sosiska.Migrations
{
    /// <inheritdoc />
    public partial class ВCookerдобавленыкатегорияисотрудник : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cookers_Grades_CategoryId",
                table: "Cookers");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Cookers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkerId",
                table: "Cookers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cookers_WorkerId",
                table: "Cookers",
                column: "WorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cookers_Grades_CategoryId",
                table: "Cookers",
                column: "CategoryId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cookers_Workers_WorkerId",
                table: "Cookers",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "WorkerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cookers_Grades_CategoryId",
                table: "Cookers");

            migrationBuilder.DropForeignKey(
                name: "FK_Cookers_Workers_WorkerId",
                table: "Cookers");

            migrationBuilder.DropIndex(
                name: "IX_Cookers_WorkerId",
                table: "Cookers");

            migrationBuilder.DropColumn(
                name: "WorkerId",
                table: "Cookers");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Cookers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cookers_Grades_CategoryId",
                table: "Cookers",
                column: "CategoryId",
                principalTable: "Grades",
                principalColumn: "Id");
        }
    }
}
