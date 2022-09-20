using Microsoft.AspNetCore.Mvc;

namespace Ejemplo_GIT.Controllers
{
    public class Controlador3 : Controller
    {
        [HttpGet]
        [Route("Controllador3")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
