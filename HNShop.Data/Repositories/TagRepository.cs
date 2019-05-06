using HNShop.Data.Infrastructure;
using HNShop.Model.Models;

namespace HNShop.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag> { }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}