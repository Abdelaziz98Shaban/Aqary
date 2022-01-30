using Aqar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aqar.DataAccess.Repository.IRepository
{
    public interface IRealStateRepositroy : IRepository<RealState>
    {
        void Update(RealState obj);
    }
}
