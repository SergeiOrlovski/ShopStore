using System.Collections.Generic;
using System.Linq;
using ShopStore.Repository.DbContext;
using ShopStore.Repository.Interfaces;

namespace ShopStore.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly ShopDb _dbContext;

        public ProductRepository()
        {
            _dbContext = new ShopDb();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public IEnumerable<Product> GetProducts(int shopId)
        {
            return _dbContext.Products.Where(w => w.Shop_ID == shopId).ToList();
        }
    }
}