using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aqar.Models;

namespace Aqar.DataAccess.Repository.IRepository
{
    public  interface IDealsRepo: IRepository<UserDealRealstate>
    {
        public void update (UserDealRealstate obj); 
    }
}
