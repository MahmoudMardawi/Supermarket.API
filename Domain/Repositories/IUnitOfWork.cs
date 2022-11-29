namespace Supermarket.API.Domain.Repositories
{
    public interface IUnitOfWork
    {
        internal Task CompleteAsync();
    }
}
