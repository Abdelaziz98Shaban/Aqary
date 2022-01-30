namespace Aqar.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IRealStateRepositroy RealState { get; }

        void Save();
    }
}
