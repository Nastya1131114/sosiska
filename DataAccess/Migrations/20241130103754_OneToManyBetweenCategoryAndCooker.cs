using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sosiska.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyBetweenCategoryAndCooker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryWorker");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
