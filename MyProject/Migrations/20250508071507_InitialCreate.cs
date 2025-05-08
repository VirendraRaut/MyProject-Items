using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_serialNumbers_items_itemId",
                table: "serialNumbers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_serialNumbers",
                table: "serialNumbers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_items",
                table: "items");

            migrationBuilder.RenameTable(
                name: "serialNumbers",
                newName: "SerialNumbers");

            migrationBuilder.RenameTable(
                name: "items",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_serialNumbers_itemId",
                table: "SerialNumbers",
                newName: "IX_SerialNumbers_itemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SerialNumbers",
                table: "SerialNumbers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SerialNumbers_Items_itemId",
                table: "SerialNumbers",
                column: "itemId",
                principalTable: "Items",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SerialNumbers_Items_itemId",
                table: "SerialNumbers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SerialNumbers",
                table: "SerialNumbers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "SerialNumbers",
                newName: "serialNumbers");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "items");

            migrationBuilder.RenameIndex(
                name: "IX_SerialNumbers_itemId",
                table: "serialNumbers",
                newName: "IX_serialNumbers_itemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_serialNumbers",
                table: "serialNumbers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_items",
                table: "items",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_serialNumbers_items_itemId",
                table: "serialNumbers",
                column: "itemId",
                principalTable: "items",
                principalColumn: "Id");
        }
    }
}
