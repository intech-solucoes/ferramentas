using Intech.Lib.TradutorSqlOracle;
using Microsoft.AspNetCore.Mvc;

namespace Intech.Ferramentas.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TradutorController : ControllerBase
    {
        [HttpPost("[action]")]
        public string TraduzirParaOracle([FromBody] DadosTraducao dados)
        {
            var queryTraduzida = new TradutorSqlToOracle().Traduz(dados.Query, dados.GerarInsertComPK);
            return queryTraduzida;
        }
    }

    public class DadosTraducao
    {
        public string Query { get; set; }
        public bool GerarInsertComPK { get; set; }
    }
}
