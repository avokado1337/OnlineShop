using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Shop.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13);
        }
    }
}
