#region Usings
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq; 
#endregion

namespace Intech.Ferramentas.GeradorCodigo.Code.Gerador
{
    public class GeradorSqlServer : BaseGerador, IGerador
    {
        public GeradorSqlServer(Config config, Conexao conexao, Sistema sistemaSelecionado, List<Entidade> configsEntidades) 
            : base(config, conexao, sistemaSelecionado, configsEntidades) { }

        private SqlConnection Conexao;

        public override void CriarConexao()
        {
            Conexao = new SqlConnection(ConfigConexao.ConnectionString);
            Conexao.Open();
        }

        /// <summary>
        /// Faz select na tabela sys.columns para buscar as colunas da tabela
        /// </summary>
        /// <returns></returns>
        public override void BuscarColunas(Entidade configEntidade)
        {
            var listaColunas = new List<Coluna>();

            string sql;

            if (configEntidade.Sinonimo.HasValue && configEntidade.Sinonimo.Value)
            {
                sql = $"SELECT TOP(0) * INTO #tmpColumns FROM {configEntidade.NomeTabela};" +
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
                     $"WHERE OBJECT_NAME(object_id) = '{configEntidade.NomeTabela}';";
            }

            var result = Conexao.Query(sql).ToList();

            foreach (var column in result)
            {
                if (!listaColunas.Any(x => x.Nome == column.name))
                    listaColunas.Add(new Coluna
                    {
                        Nome = column.name,
                        Tipo = MapeiaTipo(column.type),
                        TipoTS = MapeiaTipoTS(column.type),
                        AceitaNulo = column.is_nullable,
                        IsColunaExtra = false,
                        ChavePrimaria = column.is_identity || column.name == configEntidade.ChavePrimaria
                    });
            }

            AdicionarColunas(configEntidade, listaColunas);
        }
    }
}
