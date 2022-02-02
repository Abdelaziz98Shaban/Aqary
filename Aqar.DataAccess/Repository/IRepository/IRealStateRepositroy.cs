using Aqar.Models;
using System.Collections.Generic;

namespace Aqar.DataAccess.Repository.IRepository
{
    public interface IRealStateRepositroy : IRepository<RealStateVM>
    {
        void Update(RealStateVM obj);

        IEnumerable<RealStateVM> SearchByID(int CatID, string st);
    }
}
