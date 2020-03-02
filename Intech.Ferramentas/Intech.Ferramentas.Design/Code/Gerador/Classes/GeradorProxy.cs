using Intech.Ferramentas.Code.Entidades;
using Intech.Ferramentas.Dados.Entidades;
using System.Text;

namespace Intech.Ferramentas.Code.Gerador.Classes
{
    public class GeradorProxy
    {
        public StringBuilder StringEntidade { get; private set; }

        private readonly SistemaEntidade Sistema;
        private readonly Entidade Entidade;

        public GeradorProxy(SistemaEntidade sistema, Entidade entidade)
        {
            Sistema = sistema;
            Entidade = entidade;
        }

        public string Gerar()
        {
            StringEntidade = new StringBuilder();

            GerarUsings();
            GerarDeclaracaoClasse();
            Fechar();

            return StringEntidade.ToString();
        }

        #region Métodos Privados

        private void GerarUsings()
        {
            StringEntidade.AppendLine($"using {Sistema.TXT_NAMESPACE_DADOS}.DAO;");
            StringEntidade.AppendLine();
        }

        private void GerarDeclaracaoClasse()
        {
            StringEntidade.AppendLine($"namespace {Sistema.TXT_NAMESPACE_NEGOCIO}.Proxy");
            StringEntidade.AppendLine("{");
            StringEntidade.AppendLine($"\tpublic class {Entidade.Nome}Proxy : {Entidade.Nome}DAO");
            StringEntidade.AppendLine("\t{");
        }

        private void Fechar()
        {
            StringEntidade.AppendLine("\t}");
            StringEntidade.AppendLine("}");
        }

        #endregion
    }
}
