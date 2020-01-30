using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBabyshop.Data.Migrations
{
    public partial class ninthmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "ShoppingCartItems",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "ShoppingCartItems");
        }
    }
}
