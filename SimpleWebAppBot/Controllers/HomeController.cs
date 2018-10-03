using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAppBot.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}