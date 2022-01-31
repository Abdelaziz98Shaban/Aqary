using Aqar.DataAccess.Repository.IRepository;
using Aqar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aqar.DataAccess.Repository
{
    internal class ImagesRepo : Repository<RealStateImage>, IImageRepo
    {
        private readonly ApplicationDbContext _db;

        public ImagesRepo(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void update(RealStateImage obj)
        {
            _db.Images.Update(obj);
        }
    }
}
