using Aqar.DataAccess.Repository.IUserRepo;
using Microsoft.AspNetCore.Mvc;

namespace Aqar.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View(_unitOfWork.Category.GetAll());
        }
    }
}
