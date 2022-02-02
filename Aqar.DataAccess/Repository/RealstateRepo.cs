using Aqar.DataAccess.Repository.IRepository;
using Aqar.Models;
using Aqar.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Aqar.DataAccess.Repository
{
    public class RealstateRepo : Repository<RealState>, IRealStateRepositroy
    {
        private readonly ApplicationDbContext _db;

        public RealstateRepo(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void AddNewRealState(RealStateVM vm)
        {
            var newRealstate = new RealState()
            {
                Name = vm.Name,
                Description = vm.Description,
                State = vm.State,
                City = vm.City,
                Street = vm.Street,
                BuildingNumber = vm.BuildingNumber,
                AppartmentNumber = vm.AppartmentNumber,
                Area = vm.Area,
                Rooms = vm.Rooms,
                Baths = vm.Baths,
                Price = vm.Price,
                Status = vm.Status,
                EmergencyExit = vm.EmergencyExit,
                FirePlace = vm.FirePlace,
                SwimmingPool = vm.SwimmingPool,
                LaundryRoom = vm.LaundryRoom,
                UserId = vm.UserId,
                CategoryId = vm.CategoryId
            };

            newRealstate.Images = new List<RealStateImage>();

            foreach (var file in vm.Images)
            {
                newRealstate.Images.Add(new RealStateImage()
                {
                    ImageUrl = file.ImageUrl
                });
            }
            _db.RealStates.Add(newRealstate);
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
