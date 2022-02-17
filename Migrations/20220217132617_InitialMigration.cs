using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Shop.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.CartId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductPicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartItemCartId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_CartItem_CartItemCartId",
                        column: x => x.CartItemCartId,
                        principalTable: "CartItem",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CartItemCartId", "ProductName", "ProductPicture", "ProductPrice" },
                values: new object[,]
                {
                    { 1, null, "GeForce 1090", "https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png", 199.9m },
                    { 2, null, "GEFORCE RTX 3070", "https://assets.nvidia.partners/images/png/nvidia-geforce-rtx-3070.png", 499.9m },
                    { 3, null, "GEFORCE RTX 3060 Ti", "https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png", 399.99m },
                    { 4, null, "GEFORCE RTX 3080", "https://assets.nvidia.partners/images/png/nvidia-geforce-rtx-3080.png", 699.99m },
                    { 5, null, "GEFORCE RTX 3090", "https://assets.nvidia.partners/images/png/nvidia-geforce-rtx-3090.png", 1499m },
                    { 6, null, "GEFORCE RTX 3070 Ti", "https://assets.nvidia.partners/images/png/3070-ti-back-300x198.png", 599.9m },
                    { 7, null, "GEFORCE RTX 3080 Ti", "https://assets.nvidia.partners/images/png/3080-ti-back-300x198.png", 1199.9m },
                    { 8, null, "Gigabyte GV-N1650OC-4GD graphics card GeForce GTX 1650 4 GB GDDR5", "https://assets.nvidia.partners/images/png/DE_70360651_95478353_US.png", 159.9m },
                    { 9, null, "EVGA GeForce RTX 3060 XC Black GAMING", "https://assets.nvidia.partners/images/png/12G-P5-3655-KR.png", 329.9m },
                    { 10, null, "Gigabyte GeForce RTX 3070 EAGLE 8G", "https://assets.nvidia.partners/images/png/GV-N3070EAGLE-8GD.png", 499.9m },
                    { 11, null, "ASUS DUAL-RTX3070-8G", "https://assets.nvidia.partners/images/png/DUAL-RTX3070-8G.png", 624.9m },
                    { 12, null, "GIGABYTE GeForce GTX 1650 SUPER OC 4G", "https://assets.nvidia.partners/images/png/GV-N165SOC-4GD.png", 159.9m },
                    { 13, null, "ASUS Pheonix RTX 3050 8G", "https://assets.nvidia.partners/images/png/PH-RTX3050-8G.png", 249.9m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CartItemCartId",
                table: "Product",
                column: "CartItemCartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "CartItem");
        }
    }
}
