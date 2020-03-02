using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Intech.Ferramentas.API.Controllers
{
    [ApiController]
    [Route("/")]
    public class MainController : ControllerBase
    {
        [HttpGet]
        public IActionResult Versao()
        {
            var version = Assembly.GetExecutingAssembly().GetName();
            return Ok(version.Version.ToString(3));
        }
    }
}