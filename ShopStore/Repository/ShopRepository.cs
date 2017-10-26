using System.Collections.Generic;
using System.Linq;
using ShopStore.Repository.DbContext;
using ShopStore.Repository.Interfaces;

namespace ShopStore.Repository
{
    public class ShopRepository : IShop
    {
        private readonly ShopDb _dbContext;

        public ShopRepository()
        {
            _dbContext= new ShopDb();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public IEnumerable<Shop> GetShops()
        {
           return _dbContext.Shops.Select(s => s).ToList();
        }
    }
}