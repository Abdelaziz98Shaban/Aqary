using Microsoft.AspNetCore.Mvc;

namespace Aqar.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
