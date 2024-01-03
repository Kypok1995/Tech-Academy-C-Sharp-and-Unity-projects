using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameShop.Migrations
{
    /// <inheritdoc />
    public partial class ShopCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gamesgameID = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    ShopCartID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopCartItems_Games_gamesgameID",
                        column: x => x.gamesgameID,
                        principalTable: "Games",
                        principalColumn: "gameID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItems_gamesgameID",
                table: "ShopCartItems",
                column: "gamesgameID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopCartItems");
        }
    }
}
