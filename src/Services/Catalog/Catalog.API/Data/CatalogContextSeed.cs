using Catalog.API.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            
            if (!existProduct) 
            {
                productCollection.InsertManyAsync(GetPreConfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreConfiguredProducts()
        {
            var products = new[]
            {
                new Product
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = "Laptop",
                    Category = "Electronics",
                    Summary = "High-performance laptop with Intel processor",
                    Description = "This laptop is perfect for both work and entertainment. It features a powerful Intel processor, a sleek design, and a high-resolution display.",
                    ImageFile = "laptop.jpg",
                    Price = 999
                },
                new Product
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = "Smartphone",
                    Category = "Electronics",
                    Summary = "Latest smartphone with advanced camera features",
                    Description = "Stay connected with the latest smartphone. It comes with a stunning camera setup, fast performance, and a beautiful OLED screen.",
                    ImageFile = "smartphone.jpg",
                    Price = 799
                },
                new Product
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = "Running Shoes",
                    Category = "Sports & Outdoors",
                    Summary = "Premium running shoes for athletes",
                    Description = "These running shoes are designed for serious athletes. They provide excellent support and cushioning, making them perfect for long runs and races.",
                    ImageFile = "runningshoes.jpg",
                    Price = 129
                },
                new Product
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = "Coffee Maker",
                    Category = "Home & Kitchen",
                    Summary = "Automatic coffee maker with programmable timer",
                    Description = "Start your day with a freshly brewed cup of coffee. This coffee maker comes with a programmable timer, so your coffee is ready when you wake up.",
                    ImageFile = "coffeemaker.jpg",
                    Price = 49
                },
                new Product
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = "Books Set",
                    Category = "Books & Literature",
                    Summary = "Best-selling book set with 5 novels",
                    Description = "Immerse yourself in a world of literature with this book set. It includes five best-selling novels that will captivate your imagination.",
                    ImageFile = "bookset.jpg",
                    Price = 39
                },
                new Product
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = "Desk Chair",
                    Category = "Furniture",
                    Summary = "Ergonomic desk chair for comfortable work",
                    Description = "Upgrade your workspace with this ergonomic desk chair. It offers great lumbar support and is designed for extended periods of comfortable work.",
                    ImageFile = "deskchair.jpg",
                    Price = 199
                }
            };

            return products;
        }
    }
}
