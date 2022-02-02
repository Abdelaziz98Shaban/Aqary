using Aqar.Models;

namespace Aqar.DataAccess.Repository.IRepository
{
    public interface IImageRepo : IRepository<RealStateImage>
    {
        public void update(RealStateImage obj);
    }
}
