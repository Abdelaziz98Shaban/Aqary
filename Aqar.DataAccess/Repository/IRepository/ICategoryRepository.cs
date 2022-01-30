using Aqar.Models;

namespace Aqar.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : Repository<Category>
    {
        void Update(Category obj);

    }
}
