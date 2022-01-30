using Aqar.DataAccess.Repository.IRepository;
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
            var cat = _unitOfWork.Category.GetAll();

            return View();
        }
    }
}
