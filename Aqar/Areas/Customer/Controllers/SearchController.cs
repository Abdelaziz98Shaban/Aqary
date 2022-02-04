using Aqar.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AqarWeb.Areas.Customer.Controllers
{
    public class SearchController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public SearchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            ViewData["Cat"] = _unitOfWork.Category.GetAll().ToList();
            ViewData["Sat"] = _unitOfWork.RealState.GetAll().ToList();
            return View("search");
        }
        [HttpPost]
        public IActionResult Search(int CategoryId, string State)
        {
            ViewData["Cat"] = _unitOfWork.Category.GetAll().ToList();
            ViewData["Sat"] = _unitOfWork.RealState.GetAll().ToList();
            var ers = _unitOfWork.RealState.SearchByID(CategoryId, State);
           if(ers.Any())
            {
            return View("_SearchResult", ers);
            }
            else { return View("_NotFound"); }
        }
    }
}
