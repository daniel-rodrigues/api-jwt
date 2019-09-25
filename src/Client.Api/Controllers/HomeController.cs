using Microsoft.AspNetCore.Mvc;

namespace Client.Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}