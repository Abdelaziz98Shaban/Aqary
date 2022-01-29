using Microsoft.AspNetCore.Mvc;

namespace Aqar.Controllers
{
    public class RealStateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
