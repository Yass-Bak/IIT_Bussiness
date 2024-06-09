using Microsoft.AspNetCore.Mvc;

namespace ProjetPFA.Controllers
{
    public class SharedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _LoginPartial()
        {
            return View();
        }
    }
}
