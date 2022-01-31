using Aqar.DataAccess.Repository.IRepository;
using Aqar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aqar.DataAccess.Repository
{
    public class RealstateRepo : Repository<RealState>, IRealStateRepositroy
    {
        private readonly ApplicationDbContext _db;

        public RealstateRepo(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<RealState> SearchByID(int CatID, string st)
        {
            return _db.RealStates.Where(x => x.CategoryId == CatID && x.State == st).ToList(); 
        }

        public void Update(RealState obj)
        {
            _db.RealStates.Update(obj);
        }
    }
}
