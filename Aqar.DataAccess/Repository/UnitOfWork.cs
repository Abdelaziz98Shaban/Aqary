using Aqar.DataAccess.Repository.IRepository;

namespace Aqar.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            RealState = new RealstateRepo(_db);
        }
        public ICategoryRepository Category { get; private set; }
        public IRealStateRepositroy RealState { get; private set; }
        public IUserRepo User { get; private set; }
        public IDealsRepo Deals { get; private set; }
        public IImageRepo Image { get; private set; }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
