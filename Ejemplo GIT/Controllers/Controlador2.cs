using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejemplo_GIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controlador2 : ControllerBase
    {
        [HttpPost]
        [Route("Controlador 2")]
        public ActionResult Index()
        {
            Console.WriteLine("Hello World im controller 1");
            return View();
        }

        private ActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
