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
        public StringBuilder StringEntidade { get; private set; }

        private readonly Entidade Entidade;
        private readonly List<EntidadeColuna> Colunas;

        public GeradorEntidadeTS(Entidade entidade, List<EntidadeColuna> colunas)
        {
            Entidade = entidade;
            Colunas = colunas;
        }

        public string Gerar()
        {
            StringEntidade = new StringBuilder();

            if(Entidade.Imports.Count > 0)
                GerarImports();

            GerarDeclaracaoClasse();
            GerarColunas();
            Fechar();

            return StringEntidade.ToString();
        }

        #region Métodos Privados

        private void GerarImports()
        {
            foreach (var import in Entidade.Imports)
            {
                StringEntidade.AppendLine($"import {import} from \"./{import}\";");
            }

            StringEntidade.AppendLine();
        }

        private void GerarDeclaracaoClasse()
        {
            StringEntidade.AppendLine($"export class {Entidade.Nome}Entidade {{");
        }

        private void GerarColunas()
        {
            foreach (var coluna in Colunas)
            {
                StringEntidade.Append($"\tpublic {coluna.Nome}");

                if (coluna.AceitaNulo && coluna.TipoTS != "string")
                    StringEntidade.Append("?");

                StringEntidade.Append($": {coluna.TipoTS};\n");
            }
        }

        private void Fechar()
        {
            StringEntidade.AppendLine("}");
        }

        #endregion
    }
}