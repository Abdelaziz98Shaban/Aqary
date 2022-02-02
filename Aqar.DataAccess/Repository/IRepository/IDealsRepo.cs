using Aqar.Models;

namespace Aqar.DataAccess.Repository.IRepository
{
    public interface IDealsRepo : IRepository<UserDealRealstate>
    {
        public void update(UserDealRealstate obj);
    }
}
