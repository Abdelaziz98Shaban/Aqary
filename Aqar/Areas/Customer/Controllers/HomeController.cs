using Aqar.DataAccess.Repository;
using Aqar.DataAccess.Repository.IRepository;
using Aqar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Aqar.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<HomeController> _logger;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            
            return View();
        } 
        [HttpGet]
        public IActionResult Add()
        {
            return View(new RealState());
        }

        [HttpPost]
        public IActionResult saveAdd(RealState realState)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.RealState.Add(realState);
                return RedirectToAction("Index");
            }
            return View("Add",realState);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
