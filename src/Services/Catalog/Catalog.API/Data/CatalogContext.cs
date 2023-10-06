using Amazon.Util.Internal.PlatformServices;
using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        private IMongoDatabase _database;
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            _database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
            Products = _database.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));


        }
        public IMongoCollection<Product> Products { get; }
    }
}
