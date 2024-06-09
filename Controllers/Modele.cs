using Microsoft.AspNetCore.Mvc;

namespace ProjetPFA.Controllers
{
    public class Modele : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
