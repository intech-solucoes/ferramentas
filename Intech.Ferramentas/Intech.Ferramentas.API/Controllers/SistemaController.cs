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
    public class SistemaController : ControllerBase
    {
        [HttpGet]
        public List<SistemaEntidade> Listar() => 
            new SistemaProxy().Listar().OrderBy(x =>x.NOM_SISTEMA).ToList();

        [HttpGet("{oid}")]
        public SistemaEntidade BuscarPorOID(decimal oid) => 
            new SistemaProxy().BuscarPorChave(oid);

        [HttpPost]
        public decimal Inserir([FromBody] SistemaEntidade sistema) =>
            new SistemaProxy().Inserir(sistema);

        [HttpPost("editar")]
        public bool Update([FromBody] SistemaEntidade sistema) => 
            new SistemaProxy().Atualizar(sistema);

        [HttpPost("deletar")]
        public bool Delete([FromBody] SistemaEntidade sistema) => 
            new SistemaProxy().Deletar(sistema);
    }
}