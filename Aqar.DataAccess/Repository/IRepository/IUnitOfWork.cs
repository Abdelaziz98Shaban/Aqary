namespace Aqar.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IUserRepo User { get; }
        ICategoryRepository Category { get; }
        void Save();
    }
}
