using Microsoft.AspNetCore.Mvc;

namespace Aqar.Controllers
{
    public class UserController : Controller
    {
        public IActionResult getstudent()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
