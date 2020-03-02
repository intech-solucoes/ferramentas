#region Usings
using Dapper;
using Intech.Ferramentas.Dados.Entidades;
using Intech.Ferramentas.Dados.Proxy;
using Intech.Lib.Dapper;
using Intech.Lib.Web;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq; 
#endregion

namespace Intech.Ferramentas.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConexaoController : ControllerBase
    {
        [HttpGet]
        public List<ConexaoEntidade> Listar() =>
            new ConexaoProxy().Listar().OrderBy(x => x.NOME).ToList();

        [HttpGet("{oid}")]
        public ConexaoEntidade BuscarPorOID(decimal oid) =>
            new ConexaoProxy().BuscarPorChave(oid);

        [HttpGet("[action]/{oidSistema}")]
        public List<ConexaoEntidade> BuscarPorOidSistema(decimal oidSistema) =>
            new ConexaoProxy().BuscarPorOidSistema(oidSistema).ToList();

        [HttpPost]
        public decimal Inserir([FromBody] ConexaoEntidade Conexao) =>
            new ConexaoProxy().Inserir(Conexao);

        [HttpPost("editar")]
        public bool Update([FromBody] ConexaoEntidade Conexao) =>
            new ConexaoProxy().Atualizar(Conexao);

        [HttpPost("deletar")]
        public bool Delete([FromBody] ConexaoEntidade Conexao) =>
            new ConexaoProxy().Deletar(Conexao);

        [HttpGet("[action]/{server}/{user}/{senha}")]
        public IActionResult BuscarBancos(string server, string user, string senha)
        {
            var conexao = BaseDAO.CriarConexao(new AppSettings
            {
                ConnectionProvider = "sqlserver",
                ConnectionString = $"Data Source={server};User ID={user};Password={senha};Initial Catalog=master;Persist Security Info=True"
            });

            var databases = conexao.Query<string>("SELECT name FROM master.dbo.sysdatabases WHERE dbid > 6 ORDER BY name");

            return Ok(databases);
        }

        [HttpGet("[action]/{server}/{user}/{senha}/{database}/{tabela}/{sinonimo}")]
        public IActionResult BuscarColunas(string server, string user, string senha, string database, string tabela, bool sinonimo)
        {
            var conexao = BaseDAO.CriarConexao(new AppSettings
            {
                ConnectionProvider = "sqlserver",
                ConnectionString = $"Data Source={server};User ID={user};Password={senha};Initial Catalog={database};Persist Security Info=True"
            });

            string sql;

            if (sinonimo)
            {
                sql = $"SELECT TOP(0) * INTO #tmpColumns FROM {tabela};" +
                      "SELECT tempdb.sys.columns.name, tempdb.sys.columns.max_length, tempdb.sys.columns.precision, tempdb.sys.columns.scale, tempdb.sys.columns.is_nullable, tempdb.sys.columns.is_identity, sys.types.name as type " +
                      "FROM tempdb.sys.columns " +
                      "INNER JOIN sys.types ON tempdb.sys.columns.user_type_id = sys.types.user_type_id " +
                      "WHERE object_id = OBJECT_ID('tempdb.dbo.#tmpColumns');" +
                      "DROP TABLE #tmpColumns;";
            }
            else
            {
                sql = "SELECT sys.columns.name, sys.columns.max_length, sys.columns.precision, sys.columns.scale, sys.columns.is_nullable, sys.columns.is_identity, sys.types.name as type " +
                      "FROM sys.columns " +
                      "INNER JOIN sys.types ON sys.columns.user_type_id = sys.types.user_type_id " +
                     $"WHERE OBJECT_NAME(object_id) = '{tabela}';";
            }

            var colunas = conexao.Query(sql).ToList();

            var listaColunas = new List<dynamic>();

            foreach (var column in colunas)
            {
                listaColunas.Add(new
                {
                    column.name,
                    column.type,
                    column.is_nullable,
                    column.is_identity
                });
            }

            return Ok(listaColunas);
        }
    }
}