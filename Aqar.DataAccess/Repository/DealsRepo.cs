using Aqar.DataAccess.Repository.IRepository;
using Aqar.Models;

namespace Aqar.DataAccess.Repository
{
    public class DealsRepo : Repository<UserDealRealstate>, IDealsRepo
    {
        private readonly ApplicationDbContext _db;

        public DealsRepo(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void update(UserDealRealstate obj)
        {
            _db.Deals.Update(obj);
        }
    }
}
