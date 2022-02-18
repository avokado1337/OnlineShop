using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Shop.Migrations
{
    public partial class ChangeToVirtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductPicture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "Id", "State" },
                values: new object[] { 1, 0 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "ProductName", "ProductPicture", "ProductPrice" },
                values: new object[,]
                {
                    { 1, "GeForce 1090", "https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png", 199.9m },
                    { 2, "GEFORCE RTX 3070", "https://assets.nvidia.partners/images/png/nvidia-geforce-rtx-3070.png", 499.9m },
                    { 3, "GEFORCE RTX 3060 Ti", "https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png", 399.99m },
                    { 4, "GEFORCE RTX 3080", "https://assets.nvidia.partners/images/png/nvidia-geforce-rtx-3080.png", 699.99m },
                    { 5, "GEFORCE RTX 3090", "https://assets.nvidia.partners/images/png/nvidia-geforce-rtx-3090.png", 1499m },
                    { 6, "GEFORCE RTX 3070 Ti", "https://assets.nvidia.partners/images/png/3070-ti-back-300x198.png", 599.9m },
                    { 7, "GEFORCE RTX 3080 Ti", "https://assets.nvidia.partners/images/png/3080-ti-back-300x198.png", 1199.9m },
                    { 8, "Gigabyte GV-N1650OC-4GD graphics card GeForce GTX 1650 4 GB GDDR5", "https://assets.nvidia.partners/images/png/DE_70360651_95478353_US.png", 159.9m },
                    { 9, "EVGA GeForce RTX 3060 XC Black GAMING", "https://assets.nvidia.partners/images/png/12G-P5-3655-KR.png", 329.9m },
                    { 10, "Gigabyte GeForce RTX 3070 EAGLE 8G", "https://assets.nvidia.partners/images/png/GV-N3070EAGLE-8GD.png", 499.9m },
                    { 11, "ASUS DUAL-RTX3070-8G", "https://assets.nvidia.partners/images/png/DUAL-RTX3070-8G.png", 624.9m },
                    { 12, "GIGABYTE GeForce GTX 1650 SUPER OC 4G", "https://assets.nvidia.partners/images/png/GV-N165SOC-4GD.png", 159.9m },
                    { 13, "ASUS Pheonix RTX 3050 8G", "https://assets.nvidia.partners/images/png/PH-RTX3050-8G.png", 249.9m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CartId",
                table: "CartItem",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_ProductId",
                table: "CartItem",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
