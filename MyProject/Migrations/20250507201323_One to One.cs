using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Migrations
{
    /// <inheritdoc />
    public partial class OnetoOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "serialNumberId",
                table: "items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "serialNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    itemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serialNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_serialNumbers_items_itemId",
                        column: x => x.itemId,
                        principalTable: "items",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "serialNumbers",
                columns: new[] { "Id", "Name", "itemId" },
                values: new object[] { 10, "JioRouter111", 4 });

            migrationBuilder.CreateIndex(
                name: "IX_serialNumbers_itemId",
                table: "serialNumbers",
                column: "itemId",
                unique: true,
                filter: "[itemId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "serialNumbers");

            migrationBuilder.DropColumn(
                name: "serialNumberId",
                table: "items");
        }
    }
}
