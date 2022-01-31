using Aqar.DataAccess.Repository.IRepository;
using Aqar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Aqar.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _dB;

        public HomeController(IUnitOfWork DB )
        {
            _dB = DB;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RealStateList()
        {
            
            return View(_dB.RealState.GetAll());
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
