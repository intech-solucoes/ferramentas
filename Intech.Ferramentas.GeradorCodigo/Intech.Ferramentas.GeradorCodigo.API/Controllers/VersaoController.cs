using Microsoft.AspNetCore.Mvc;

namespace Intech.Ferramentas.GeradorCodigo.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class VersaoController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Json("1.0.0");
        }
    }
}