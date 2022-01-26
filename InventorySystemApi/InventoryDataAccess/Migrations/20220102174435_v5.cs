using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryDataAccess.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_categories_CategoryID",
                table: "categories");

            migrationBuilder.DropIndex(
                name: "IX_categories_CategoryID",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_categories_CategoryID",
                table: "categories",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_categories_CategoryID",
                table: "categories",
                column: "CategoryID",
                principalTable: "categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
