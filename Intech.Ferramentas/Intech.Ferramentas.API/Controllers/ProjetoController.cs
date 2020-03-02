#region Usings
using Intech.Ferramentas.Dados.Entidades;
using Intech.Ferramentas.Dados.Proxy;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace Intech.Ferramentas.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {
        [HttpGet]
        public List<ProjetoEntidade> Listar() => 
            new ProjetoProxy().Listar().OrderBy(x => x.NOM_PROJETO).ToList();

        [HttpGet("{oid}")]
        public ProjetoEntidade BuscarPorOID(decimal oid) => 
            new ProjetoProxy().BuscarPorChave(oid);

        [HttpGet("[action]/{oidSistema}")]
        public List<ProjetoEntidade> BuscarPorOidSistema(decimal oidSistema) =>
            new ProjetoProxy().BuscarPorOidSistema(oidSistema).ToList();

        [HttpPost]
        public decimal Inserir([FromBody] ProjetoEntidade sistema) => 
            new ProjetoProxy().Inserir(sistema);

        [HttpPost("editar")]
        public bool Update([FromBody] ProjetoEntidade sistema) => 
            new ProjetoProxy().Atualizar(sistema);

        [HttpPost("deletar")]
        public bool Delete([FromBody] ProjetoEntidade sistema) => 
            new ProjetoProxy().Deletar(sistema);
    }
}