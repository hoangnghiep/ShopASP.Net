using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HNShopDbContext dbContext;

        public HNShopDbContext Init()
        {
            return dbContext ?? (dbContext = new HNShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
