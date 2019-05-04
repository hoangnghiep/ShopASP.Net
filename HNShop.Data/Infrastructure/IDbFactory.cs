using System;

namespace HNShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        HNShopDbContext Init();
    }
}