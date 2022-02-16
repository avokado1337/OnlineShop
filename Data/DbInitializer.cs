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
                new Product {ProductId=4,ProductName="GeForce 1090", ProductPrice=199.9M, ProductPicture="https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png"},
                new Product {ProductId=5,ProductName="GeForce 1090", ProductPrice=199.9M, ProductPicture="https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png"},
                new Product {ProductId=6,ProductName="GeForce 1090", ProductPrice=199.9M, ProductPicture="https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png"},
                new Product {ProductId=7,ProductName="GeForce 1090", ProductPrice=199.9M, ProductPicture="https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png"},
                new Product {ProductId=8,ProductName="GeForce 1090", ProductPrice=199.9M, ProductPicture="https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png"},
                new Product {ProductId=9,ProductName="GeForce 1090", ProductPrice=199.9M, ProductPicture="https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png"},
                new Product {ProductId=10,ProductName="GeForce 1090", ProductPrice=199.9M, ProductPicture="https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png"},
                new Product {ProductId=11,ProductName="GeForce 1090", ProductPrice=199.9M, ProductPicture="https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png"},
                new Product {ProductId=12,ProductName="GeForce 1090", ProductPrice=199.9M, ProductPicture="https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png"},
                new Product {ProductId=13,ProductName="GeForce 1090", ProductPrice=199.9M, ProductPicture="https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png"},
                new Product {ProductId=14,ProductName="GeForce 1090", ProductPrice=199.9M, ProductPicture="https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png"},
                new Product {ProductId=15,ProductName="GeForce 1090", ProductPrice=199.9M, ProductPicture="https://www.nvidia.com/content/dam/en-zz/Solutions/GeForce/campaigns/10-series/geforce-gtx-1080-ti-2c50-P@2x.png"},

            }
        }
    }
}
