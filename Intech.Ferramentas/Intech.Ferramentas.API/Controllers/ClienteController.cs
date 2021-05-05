using Intech.Ferramentas.Dados.Entidades;
using Intech.Ferramentas.Dados.Proxy;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Intech.Ferramentas.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public List<ClienteEntidade> Listar() =>
            new ClienteProxy().Listar().OrderBy(x => x.NOME).ToList();

        [HttpGet("{oid}")]
        public ClienteEntidade BuscarPorOID(decimal oid) =>
            new ClienteProxy().BuscarPorChave(oid);

        [HttpPost]
        public decimal Inserir([FromBody] ClienteEntidade Conexao) =>
            new ClienteProxy().Inserir(Conexao);

        [HttpPost("editar")]
        public bool Update([FromBody] ClienteEntidade Conexao) =>
            new ClienteProxy().Atualizar(Conexao);

        [HttpPost("deletar")]
        public bool Delete([FromBody] ClienteEntidade Conexao) =>
            new ClienteProxy().Deletar(Conexao);
    }
}
