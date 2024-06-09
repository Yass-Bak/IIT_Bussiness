using Microsoft.AspNetCore.Mvc;

namespace ProjetPFA.Controllers
{
    public class Marketing : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
