#region Usings
using Intech.Ferramentas.Code.Entidades;
using Intech.Ferramentas.Dados.Entidades;
using System;
using System.Collections.Generic;
using System.Text; 
#endregion

namespace Intech.Ferramentas.Code.Gerador.Classes
{
    public class GeradorEntidade
    {
        public StringBuilder StringEntidade { get; private set; }

        private readonly SistemaEntidade Sistema;
        private readonly Entidade Entidade;
        private readonly List<EntidadeColuna> Colunas;

        public GeradorEntidade(SistemaEntidade sistema, Entidade entidade, List<EntidadeColuna> colunas)
        {
            Sistema = sistema;
            Entidade = entidade;
            Colunas = colunas;
        }

        public string Gerar()
        {
            StringEntidade = new StringBuilder();

            GerarUsings();
            GerarDeclaracaoClasse();
            GerarColunas();
            Fechar();

            return StringEntidade.ToString();
        }

        #region Métodos Privados

        private void GerarUsings()
        {
            StringEntidade.AppendLine("using System;");
            StringEntidade.AppendLine("using System.Collections.Generic;");
            StringEntidade.AppendLine("using Dapper.Contrib.Extensions;");
            StringEntidade.AppendLine();
        }

        private void GerarDeclaracaoClasse()
        {
            StringEntidade.AppendLine($"namespace {Sistema.TXT_NAMESPACE_ENTIDADES}");
            StringEntidade.AppendLine("{");
            StringEntidade.AppendLine($"\t[Table(\"{Entidade.NomeTabela}\")]");
            StringEntidade.AppendLine($"\tpublic class {Entidade.Nome}Entidade");
            StringEntidade.AppendLine("\t{");
        }

        private void GerarColunas()
        {
            foreach (var coluna in Colunas)
            {
                if(coluna.ChavePrimaria.HasValue && coluna.ChavePrimaria.Value)
                    StringEntidade.AppendLine($"\t\t[Key]");

                StringEntidade.Append("\t\t");

                if (coluna.IsColunaExtra.HasValue && coluna.IsColunaExtra.Value)
                    StringEntidade.Append("[Write(false)] ");

                StringEntidade.Append($"public {coluna.Tipo}");

                if (coluna.AceitaNulo && coluna.Tipo != "string")
                    StringEntidade.Append("?");

                StringEntidade.Append($" {coluna.Nome} {{ get; set; }}\n");
            }
        }

        private void Fechar()
        {
            StringEntidade.AppendLine("\t}");
            StringEntidade.AppendLine("}");
        }

        #endregion
    }
}