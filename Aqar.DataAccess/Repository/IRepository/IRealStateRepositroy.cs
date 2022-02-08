using Aqar.Models;
using Aqar.Models.ViewModels;
using System.Collections.Generic;

namespace Aqar.DataAccess.Repository.IRepository
{
    public interface IRealStateRepositroy : IRepository<RealState>
    {
        void Update(RealState obj);
        void AddNewRealState(RealStateVM vm);
        public IEnumerable<RealState> GetAllWithImgs();

        IEnumerable<RealState> SearchByID(int CatID, string st);

    }

}
