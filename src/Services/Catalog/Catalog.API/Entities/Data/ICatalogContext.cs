using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Entities.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
