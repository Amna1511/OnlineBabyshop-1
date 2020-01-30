using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBabyshop.Data.Migrations
{
    public partial class fifthmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ShoppingCartId",
                table: "ShoppingCartItems",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "Product",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    ShoppingCartId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.ShoppingCartId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ShoppingCartId",
                table: "ShoppingCartItems",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductId1",
                table: "Product",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Product_ProductId1",
                table: "Product",
                column: "ProductId1",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_ShoppingCart_ShoppingCartId",
                table: "ShoppingCartItems",
                column: "ShoppingCartId",
                principalTable: "ShoppingCart",
                principalColumn: "ShoppingCartId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Product_ProductId1",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_ShoppingCart_ShoppingCartId",
                table: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "ShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCartItems_ShoppingCartId",
                table: "ShoppingCartItems");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductId1",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "ShoppingCartId",
                table: "ShoppingCartItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
