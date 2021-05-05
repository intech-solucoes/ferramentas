using Intech.Ferramentas.Code.Entidades;
using Intech.Ferramentas.Dados.Entidades;
using System.Text;

namespace Intech.Ferramentas.Code.Gerador.Classes
{
    public class GeradorProxy
    {
        public StringBuilder SB { get; private set; }

        private readonly SistemaEntidade Sistema;
        private readonly Entidade Entidade;

        public GeradorProxy(SistemaEntidade sistema, Entidade entidade)
        {
            Sistema = sistema;
            Entidade = entidade;
        }

        public string Gerar()
        {
            SB = new StringBuilder();

            GerarUsings();
            GerarDeclaracaoClasse();
            GerarConstrutor();
            Fechar();

            return SB.ToString();
        }

        #region Métodos Privados

        private void GerarUsings()
        {
            SB.AppendLine($"using {Sistema.TXT_NAMESPACE_DADOS}.DAO;");
            SB.AppendLine($"using System.Data;");
            SB.AppendLine();
        }

        private void GerarDeclaracaoClasse()
        {
            SB.AppendLine($"namespace {Sistema.TXT_NAMESPACE_NEGOCIO}.Proxy");
            SB.AppendLine("{");
            SB.AppendLine($"\tpublic class {Entidade.Nome}Proxy : {Entidade.Nome}DAO");
            SB.AppendLine("\t{");
        }

        private void GerarConstrutor()
        {
            SB.AppendLine($"\t\tpublic {Entidade.Nome}Proxy (IDbTransaction tx = null) : base(tx) {{ }}");
        }

        private void Fechar()
        {
            SB.AppendLine("\t}");
            SB.AppendLine("}");
        }

        #endregion
    }
}
