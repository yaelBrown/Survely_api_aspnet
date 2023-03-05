using Microsoft.AspNetCore.Mvc;

namespace Survely_api_aspnet.Controllers
{
    public class UserController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
