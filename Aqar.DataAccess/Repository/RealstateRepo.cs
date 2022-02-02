using Aqar.DataAccess.Repository.IRepository;
using Aqar.Models;
using System.Collections.Generic;
using System.Linq;

namespace Aqar.DataAccess.Repository
{
    public class RealstateRepo : Repository<RealStateVM>, IRealStateRepositroy
    {
        private readonly ApplicationDbContext _db;

        public RealstateRepo(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<RealStateVM> SearchByID(int CatID, string st)
        {
            return _db.RealStates.Where(x => x.CategoryId == CatID && x.State == st).ToList();
        }

        public void Update(RealStateVM obj)
        {
            _db.RealStates.Update(obj);
        }
    }
}
