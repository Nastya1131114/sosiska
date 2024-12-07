using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sosiska.Migrations
{
    /// <inheritdoc />
    public partial class изменениявклассеCooker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cookers_Categories_CategoryId",
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CookerBirthday",
                table: "Cookers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CookerMiddleName",
                table: "Cookers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CookerName",
                table: "Cookers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CookerSurname",
                table: "Cookers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Cookers_Categories_CategoryId",
                table: "Cookers",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cookers_Categories_CategoryId",
                table: "Cookers");

            migrationBuilder.DropColumn(
                name: "CookerBirthday",
                table: "Cookers");

            migrationBuilder.DropColumn(
                name: "CookerMiddleName",
                table: "Cookers");

            migrationBuilder.DropColumn(
                name: "CookerName",
                table: "Cookers");

            migrationBuilder.DropColumn(
                name: "CookerSurname",
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
                name: "FK_Cookers_Categories_CategoryId",
                table: "Cookers",
                column: "CategoryId",
                principalTable: "Categories",
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
    }
}
