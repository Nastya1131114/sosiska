using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sosiska.Migrations
{
    /// <inheritdoc />
    public partial class ИзменениеклассаOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_DishOrders_OrderID",
                table: "DishOrders",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_DishOrders_Orders_OrderID",
                table: "DishOrders",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DishOrders_Orders_OrderID",
                table: "DishOrders");

            migrationBuilder.DropIndex(
                name: "IX_DishOrders_OrderID",
                table: "DishOrders");
        }
    }
}
