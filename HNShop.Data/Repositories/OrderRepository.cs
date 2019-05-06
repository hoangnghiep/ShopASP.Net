using HNShop.Data.Infrastructure;
using HNShop.Model.Models;

namespace HNShop.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    { }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}