#region Usings
using Intech.Ferramentas.Code.Entidades;
using Intech.Ferramentas.Dados.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Intech.Ferramentas.Code.Gerador.Classes
{
    public class GeradorEntidadeTS
    {
        public StringBuilder SB { get; private set; }

        private readonly Entidade Entidade;
        private readonly List<EntidadeColuna> Colunas;

        public GeradorEntidadeTS(Entidade entidade, List<EntidadeColuna> colunas)
        {
            Entidade = entidade;
            Colunas = colunas;
        }

        public string Gerar()
        {
            SB = new StringBuilder();

            if(Entidade.Imports.Count > 0)
                GerarImports();

            GerarDeclaracaoClasse();
            GerarColunas();
            Fechar();

            return SB.ToString();
        }

        #region Métodos Privados

        private void GerarImports()
        {
            foreach (var import in Entidade.Imports)
            {
                SB.AppendLine($"import {{ {import} }} from \"./{import}\";");
            }

            SB.AppendLine();
        }

        private void GerarDeclaracaoClasse()
        {
            SB.AppendLine($"export class {Entidade.Nome}Entidade {{");
        }

        private void GerarColunas()
        {
            foreach (var coluna in Colunas)
            {
                if (coluna.IsColunaExtra.HasValue && coluna.IsColunaExtra.Value)
                    SB.Append($"\tpublic {coluna.Nome}");
                else
                    SB.Append($"\tpublic {coluna.Nome.ToUpper()}");

                if (coluna.AceitaNulo && coluna.TipoTS != "string")
                    SB.Append("?");

                SB.Append($": {coluna.TipoTS};\n");
            }
        }

        private void Fechar()
        {
            SB.AppendLine("}");
        }

        #endregion
    }
}