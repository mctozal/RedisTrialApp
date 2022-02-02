using Microsoft.AspNetCore.Mvc;

namespace RedisTrialApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
