using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetPFA.Contants;

namespace ProjetPFA.Controllers
{
    public class Finance : Controller
    {
        [Authorize(Permissions.Products.Edit)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
