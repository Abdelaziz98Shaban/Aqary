using Aqar.DataAccess.Repository.IRepository;
using Aqar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
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
