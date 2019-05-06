using HNShop.Data.Infrastructure;
using HNShop.Model.Models;

namespace HNShop.Data.Repositories
{
    public interface IMenuGroupRepository : IRepository<MenuGroup>
    { }

    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}