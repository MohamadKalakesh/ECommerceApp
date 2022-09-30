using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products =
                new List<Product> {
                    new Product {
                        Name = "Product1",
                        Description = "Product 1",
                        Price = 10000,
                        PictureUrl = "/images/products/product1.png",
                        Type = "Type1",
                        Brand = "Brand1",
                        QuantityInStock = 100
                    },
                    new Product {
                        Name = "Product2",
                        Description = "Product 2",
                        Price = 20000,
                        PictureUrl = "/images/products/product2.png",
                        Type = "Type2",
                        Brand = "Brand3",
                        QuantityInStock = 100
                    },
                    new Product {
                        Name = "Product3",
                        Description = "Product 3",
                        Price = 15000,
                        PictureUrl = "/images/products/product3.png",
                        Type = "Type4",
                        Brand = "Brand2",
                        QuantityInStock = 100
                    },
                    new Product {
                        Name = "Product4",
                        Description = "Product 4",
                        Price = 13000,
                        PictureUrl = "/images/products/product4.png",
                        Type = "Type2",
                        Brand = "Brand1",
                        QuantityInStock = 100
                    },
                    new Product {
                        Name = "Product5",
                        Description = "Product 5",
                        Price = 10000,
                        PictureUrl = "/images/products/product5.png",
                        Type = "Type3",
                        Brand = "Brand2",
                        QuantityInStock = 100
                    }
                };

            foreach (var product in products)
            {
                context.Products.Add (product);
            }

            context.SaveChanges();
        }
    }
}
