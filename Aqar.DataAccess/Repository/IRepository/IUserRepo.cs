using Aqar.Models;

namespace Aqar.DataAccess.Repository.IRepository
{
    public interface IUserRepo : IRepository<User>
    {
        public void update(User obj);

    }
}
