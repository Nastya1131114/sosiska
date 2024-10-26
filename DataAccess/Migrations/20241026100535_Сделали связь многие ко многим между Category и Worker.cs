using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sosiska.Migrations
{
    /// <inheritdoc />
    public partial class СделалисвязьмногиекомногиммеждуCategoryиWorker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cookers_Grades_CategoryId",
                table: "Cookers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grades",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Workers");

            migrationBuilder.RenameTable(
                name: "Grades",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "CookerID",
                table: "Dishes",
                newName: "DishCost");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CategoryWorker",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    WorkersWorkerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryWorker", x => new { x.CategoriesId, x.WorkersWorkerId });
                    table.ForeignKey(
                        name: "FK_CategoryWorker_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryWorker_Workers_WorkersWorkerId",
                        column: x => x.WorkersWorkerId,
                        principalTable: "Workers",
                        principalColumn: "WorkerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryWorker_WorkersWorkerId",
                table: "CategoryWorker",
                column: "WorkersWorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cookers_Categories_CategoryId",
                table: "Cookers",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cookers_Categories_CategoryId",
                table: "Cookers");

            migrationBuilder.DropTable(
                name: "CategoryWorker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Grades");

            migrationBuilder.RenameColumn(
                name: "DishCost",
                table: "Dishes",
                newName: "CookerID");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grades",
                table: "Grades",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cookers_Grades_CategoryId",
                table: "Cookers",
                column: "CategoryId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
