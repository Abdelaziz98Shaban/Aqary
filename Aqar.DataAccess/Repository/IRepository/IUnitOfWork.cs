namespace Aqar.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IRealStateRepositroy RealState { get; }
        IUserRepo User { get; }
        IDealsRepo Deals { get; }
        IImageRepo Image { get; }
        void Save();
    }
}
