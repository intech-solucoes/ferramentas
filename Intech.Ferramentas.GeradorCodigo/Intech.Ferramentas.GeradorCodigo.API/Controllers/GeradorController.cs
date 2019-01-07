#region Usings
using Intech.Lib.Data.Util.Tradutor;
using Microsoft.AspNetCore.Mvc;
using System;
#endregion

namespace Intech.Ferramentas.GeradorCodigo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeradorController : Controller
    {
        [HttpPost("traduzir/{gerarInsertComPK}")]
        public ActionResult GetSistemas(bool gerarInsertComPK, [FromBody] dynamic data)
        {
            try
            {
                var queryOracle = new TradutorSqlToOracle().Traduz(data.query.Value, gerarInsertComPK);

                return Json(new
                {
                    query = queryOracle
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}