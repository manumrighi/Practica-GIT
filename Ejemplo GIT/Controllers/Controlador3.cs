using Microsoft.AspNetCore.Mvc;

namespace Ejemplo_GIT.Controllers
{
    public class Controlador3 : Controller
    {
        [HttpGet]
        [Route("Controllador3")]
        public IActionResult Index()
        {
            Console.WriteLine("Hello World im Controller3");
            return View();
        }

    }
}
