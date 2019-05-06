using HNShop.Data.Infrastructure;
using HNShop.Model.Models;

namespace HNShop.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    { }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}