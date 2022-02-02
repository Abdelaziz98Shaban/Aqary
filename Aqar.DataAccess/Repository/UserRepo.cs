using Aqar.DataAccess.Repository.IRepository;
using Aqar.Models;

namespace Aqar.DataAccess.Repository
{
    public class UserRepo : Repository<User>, IUserRepo
    {
        private readonly ApplicationDbContext _db;

        public UserRepo(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }

        public void update(User obj)
        {
            _db.Users.Update(obj);
        }
    }
}
