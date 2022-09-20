using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejemplo_GIT
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controlador2 : ControllerBase
    {
        [HttpGet]
        [Route("Controlador2")]
        public ActionResult Index()
        {
            return View();
        }

        private ActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
