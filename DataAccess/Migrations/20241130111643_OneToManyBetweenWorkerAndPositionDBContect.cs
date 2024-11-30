using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sosiska.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyBetweenWorkerAndPositionDBContect : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Workers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workers_PositionId",
                table: "Workers",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Positions_PositionId",
                table: "Workers",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Positions_PositionId",
                table: "Workers");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Workers_PositionId",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Workers");
        }
    }
}
