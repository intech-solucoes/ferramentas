using Intech.Ferramentas.Code.Entidades;
using Intech.Ferramentas.Dados.Entidades;
using Intech.Ferramentas.Services;
using System.Collections.Generic;
using System.Linq;

namespace Intech.Ferramentas.Code.Gerador
{
    public class GeradorSqlServer : BaseGerador, IGerador
    {
        public GeradorSqlServer(ConexaoEntidade conexao, SistemaEntidade sistema, ProjetoEntidade projeto, List<Entidade> entidades)
            : base(conexao, sistema, projeto, entidades) { }

        public override void BuscarColunas(Entidade entidade)
        {
            var listaColunas = new List<EntidadeColuna>();

            var colunas = ConexaoService.BuscarColunas(Conexao.SERVIDOR, Conexao.USUARIO, Conexao.SENHA, Conexao.BANCO, entidade.NomeTabela, entidade.Sinonimo.HasValue ? entidade.Sinonimo.Value : false);

            foreach (var column in colunas)
            {
                if (!((string)column.type).Contains("Entidade") || !listaColunas.Any(x => x.Nome == column.name))
                    listaColunas.Add(new EntidadeColuna
                    {
                        Nome = (string)column.name,
                        Tipo = MapeiaTipo((string)column.type),
                        TipoTS = MapeiaTipoTS((string)column.type),
                        AceitaNulo = column.is_nullable,
                        IsColunaExtra = false,
                        ChavePrimaria = (bool)column.is_identity || (string)column.name == entidade.ChavePrimaria
                    });
            }

            AdicionarColunas(entidade, listaColunas);
        }
    }
}