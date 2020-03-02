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
    public class SistemaController : ControllerBase
    {
        [HttpGet]
        public List<SistemaEntidade> Listar() => new SistemaProxy().Listar();

        [HttpGet("{oid}")]
        public SistemaEntidade BuscarPorOID(decimal oid) => new SistemaProxy().BuscarPorChave(oid);

        [HttpPost]
        public decimal Inserir([FromBody] SistemaEntidade sistema) => new SistemaProxy().Inserir(sistema);

        [HttpPatch]
        public bool Update([FromBody] SistemaEntidade sistema) => new SistemaProxy().Atualizar(sistema);

        [HttpDelete]
        public bool Delete([FromBody] SistemaEntidade sistema) => new SistemaProxy().Deletar(sistema);
    }
}