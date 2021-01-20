using Microsoft.EntityFrameworkCore.Migrations;

namespace MsSqlDb.EfDataProvider.Migrations
{
    public partial class Appended_ItemField_to_Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Items_ItemId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ItemId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Categories");

            migrationBuilder.CreateTable(
                name: "CategoryItem",
                columns: table => new
                {
                    CategoriesCategoryId = table.Column<int>(type: "int", nullable: false),
                    ItemsItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryItem", x => new { x.CategoriesCategoryId, x.ItemsItemId });
                    table.ForeignKey(
                        name: "FK_CategoryItem_Categories_CategoriesCategoryId",
                        column: x => x.CategoriesCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryItem_Items_ItemsItemId",
                        column: x => x.ItemsItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryItem_ItemsItemId",
                table: "CategoryItem",
                column: "ItemsItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryItem");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ItemId",
                table: "Categories",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Items_ItemId",
                table: "Categories",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
