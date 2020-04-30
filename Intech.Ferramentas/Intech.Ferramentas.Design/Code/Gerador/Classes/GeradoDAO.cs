#region Usings
using Intech.Ferramentas.Code.Entidades;
using Intech.Ferramentas.Dados.Entidades;
using System;
using System.Collections.Generic;
using System.Text; 
#endregion

namespace Intech.Ferramentas.Code.Gerador.Classes
{
    public class GeradorDAO
    {
        public StringBuilder SB { get; private set; }

        private readonly SistemaEntidade Sistema;
        private readonly Entidade Entidade;
        private readonly List<EntidadeConsulta> Consultas;

        public GeradorDAO(SistemaEntidade sistema, ProjetoEntidade projeto, Entidade entidade, List<EntidadeConsulta> consultas)
        {
            Sistema = sistema;
            Entidade = entidade;
            Consultas = consultas;
        }

        public string Gerar()
        {
            SB = new StringBuilder();

            GerarUsings();
            GerarDeclaracaoClasse();
            GerarMetodos();
            Fechar();

            return SB.ToString();
        }

        #region Métodos Privados

        private void GerarUsings()
        {
            SB.AppendLine("using Dapper;");
            SB.AppendLine("using Intech.Lib.Dapper;");
            SB.AppendLine("using Intech.Lib.Web;");
            SB.AppendLine($"using {Sistema.TXT_NAMESPACE_ENTIDADES};");
            SB.AppendLine("using System;");
            SB.AppendLine("using System.Collections.Generic;");
            SB.AppendLine("using System.Linq;");
            SB.AppendLine();
        }

        private void GerarDeclaracaoClasse()
        {
            SB.AppendLine($"namespace {Sistema.TXT_NAMESPACE_DADOS}.DAO");
            SB.AppendLine("{");
            SB.AppendLine($"\tpublic abstract class {Entidade.Nome}DAO : BaseDAO<{Entidade.Nome}Entidade>");
            SB.AppendLine("\t{");
        }

        private void GerarMetodos()
        {
            foreach (var consulta in Consultas)
            {
                SB.Append($"\t\tpublic virtual ");

                if (consulta.RetornaLista)
                    SB.Append($"List<{consulta.Retorno}>");
                else
                    SB.Append($"{consulta.Retorno}");

                SB.Append($" {consulta.Nome}(");

                // Parametros
                for (var i = 0; i < consulta.Parametros.Count; i++)
                {
                    var parametro = consulta.Parametros[i];

                    SB.Append($"{parametro.Key} {parametro.Value}");

                    if (i + 1 < consulta.Parametros.Count)
                        SB.Append(", ");
                }

                SB.Append(")\n");
                SB.Append("\t\t");
                SB.Append("{\n");

                GerarQuery(consulta, true);
                GerarQuery(consulta, false);

                SB.Append("\t\t\t");
                SB.Append("else\n");

                SB.Append("\t\t\t\t");
                SB.Append("throw new Exception(\"Provider não suportado!\");\n");

                SB.Append("\t\t");
                SB.Append("}\n\n");
            }
        }

        private void GerarQuery(EntidadeConsulta consulta, bool sqlServer)
        {
            SB.Append("\t\t\t");

            if(sqlServer)
                SB.AppendLine("if (AppSettings.IS_SQL_SERVER_PROVIDER)");
            else
                SB.AppendLine("else if (AppSettings.IS_ORACLE_PROVIDER)");

            SB.Append("\t\t\t\t");

            if (consulta.Retorno != "void")
                SB.Append($"return ");

            SB.Append("Conexao.");

            if (!consulta.RetornaLista && consulta.Retorno != "void")
                SB.Append("QuerySingleOrDefault");
            else if (consulta.Retorno == "void")
                SB.Append("Execute");
            else
                SB.Append("Query");

            if (consulta.Retorno != "void")
                SB.Append($"<{consulta.Retorno}>");

            if(sqlServer)
                SB.Append($"(\"{consulta.QuerySqlServer}\", new {{ ");
            else
                SB.Append($"(\"{consulta.QueryOracle}\", new {{ ");

            // Parametros
            for (var i = 0; i < consulta.Parametros.Count; i++)
            {
                var parametro = consulta.Parametros[i];

                SB.Append($"{parametro.Value}");

                if (i + 1 < consulta.Parametros.Count)
                    SB.Append(", ");
            }

            SB.Append(" })");

            if (consulta.RetornaLista)
                SB.Append(".ToList()");

            SB.Append(";\n");
        }

        private void Fechar()
        {
            SB.AppendLine("\t}");
            SB.AppendLine("}");
        }

        #endregion
    }
}