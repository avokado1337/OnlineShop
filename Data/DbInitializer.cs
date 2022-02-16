using Online_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any())
            {
                return;
            }

            var products = new Product[]
            {
                new Product {ProductId=1,ProductName="GeForce 1090", ProductPrice=199.9M, ProductPicture="https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png"},
                new Product {ProductId=2,ProductName="GEFORCE RTX 3070", ProductPrice=499.9M, ProductPicture="https://assets.nvidia.partners/images/png/nvidia-geforce-rtx-3070.png"},
                new Product {ProductId=3,ProductName="GEFORCE RTX 3060 Ti", ProductPrice=399.99M, ProductPicture="https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png"},
                new Product {ProductId=4,ProductName="GEFORCE RTX 3080", ProductPrice=699.99M, ProductPicture="https://assets.nvidia.partners/images/png/nvidia-geforce-rtx-3080.png"},
                new Product {ProductId=5,ProductName="GEFORCE RTX 3090", ProductPrice=1499, ProductPicture="https://assets.nvidia.partners/images/png/nvidia-geforce-rtx-3090.png"},
                new Product {ProductId=6,ProductName="GEFORCE RTX 3070 Ti", ProductPrice=599.9M, ProductPicture="https://assets.nvidia.partners/images/png/3070-ti-back-300x198.png"},
                new Product {ProductId=7,ProductName="GEFORCE RTX 3080 Ti", ProductPrice=1199.9M, ProductPicture="https://assets.nvidia.partners/images/png/3080-ti-back-300x198.png"},
                new Product {ProductId=8,ProductName="Gigabyte GV-N1650OC-4GD graphics card GeForce GTX 1650 4 GB GDDR5", ProductPrice=159.9M, ProductPicture="https://assets.nvidia.partners/images/png/DE_70360651_95478353_US.png"},
                new Product {ProductId=9,ProductName="EVGA GeForce RTX 3060 XC Black GAMING", ProductPrice=329.9M, ProductPicture="https://assets.nvidia.partners/images/png/12G-P5-3655-KR.png"},
                new Product {ProductId=10,ProductName="Gigabyte GeForce RTX 3070 EAGLE 8G", ProductPrice=499.9M, ProductPicture="https://assets.nvidia.partners/images/png/GV-N3070EAGLE-8GD.png"},
                new Product {ProductId=11,ProductName="ASUS DUAL-RTX3070-8G", ProductPrice=624.9M, ProductPicture="https://assets.nvidia.partners/images/png/DUAL-RTX3070-8G.png"},
                new Product {ProductId=12,ProductName="GIGABYTE GeForce GTX 1650 SUPER OC 4G", ProductPrice=159.9M, ProductPicture="https://assets.nvidia.partners/images/png/GV-N165SOC-4GD.png"},
                new Product {ProductId=13,ProductName="ASUS Pheonix RTX 3050 8G", ProductPrice=249.9M, ProductPicture="https://assets.nvidia.partners/images/png/PH-RTX3050-8G.png"}

            };

            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();
        }
    }
}
