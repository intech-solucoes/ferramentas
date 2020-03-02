#region Usings
using Intech.Ferramentas.Dados.Entidades;
using Intech.Ferramentas.Dados.Proxy;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; 
#endregion

namespace Intech.Ferramentas.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {
        [HttpGet]
        public List<ProjetoEntidade> Listar() => new ProjetoProxy().Listar();

        [HttpGet("{oid}")]
        public ProjetoEntidade BuscarPorOID(decimal oid) => new ProjetoProxy().BuscarPorChave(oid);

        [HttpPost]
        public decimal Inserir([FromBody] ProjetoEntidade sistema) => new ProjetoProxy().Inserir(sistema);

        [HttpPatch]
        public bool Update([FromBody] ProjetoEntidade sistema) => new ProjetoProxy().Atualizar(sistema);

        [HttpDelete]
        public bool Delete([FromBody] ProjetoEntidade sistema) => new ProjetoProxy().Deletar(sistema);
    }
}