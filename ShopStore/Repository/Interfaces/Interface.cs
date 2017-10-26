using System;
using System.Collections.Generic;
using ShopStore.Repository.DbContext;

namespace ShopStore.Repository.Interfaces
{
    public interface IShop : IDisposable
    {
        IEnumerable<Shop> GetShops();
    }

    public interface IProduct : IDisposable
    {
        IEnumerable<Product> GetProducts(int shopId);
    }
}
