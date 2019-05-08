using HNShop.Data.Infrastructure;
using HNShop.Model.Models;
using System.Collections.Generic;

namespace HNShop.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> GetRevenueStatistic(string fromDate, string toDate);
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Order> GetRevenueStatistic(string fromDate, string toDate)
        {
            throw new System.NotImplementedException();
        }
    }
}