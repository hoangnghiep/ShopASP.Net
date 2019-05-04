namespace HNShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}