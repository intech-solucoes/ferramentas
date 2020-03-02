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
        public StringBuilder StringEntidade { get; private set; }

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
            StringEntidade = new StringBuilder();

            GerarUsings();
            GerarDeclaracaoClasse();
            GerarMetodos();
            Fechar();

            return StringEntidade.ToString();
        }

        #region Métodos Privados

        private void GerarUsings()
        {
            StringEntidade.AppendLine("using Dapper;");
            StringEntidade.AppendLine("using Intech.Lib.Dapper;");
            StringEntidade.AppendLine("using Intech.Lib.Web;");
            StringEntidade.AppendLine($"using {Sistema.TXT_NAMESPACE_ENTIDADES};");
            StringEntidade.AppendLine("using System;");
            StringEntidade.AppendLine("using System.Collections.Generic;");
            StringEntidade.AppendLine("using System.Linq;");
            StringEntidade.AppendLine();
        }

        private void GerarDeclaracaoClasse()
        {
            StringEntidade.AppendLine($"namespace {Sistema.TXT_NAMESPACE_DADOS}.DAO");
            StringEntidade.AppendLine("{");
            StringEntidade.AppendLine($"\tpublic abstract class {Entidade.Nome}DAO : BaseDAO<{Entidade.Nome}Entidade>");
            StringEntidade.AppendLine("\t{");
        }

        private void GerarMetodos()
        {
            foreach (var consulta in Consultas)
            {
                StringEntidade.Append($"\t\tpublic virtual ");

                if (consulta.RetornaLista)
                    StringEntidade.Append($"List<{consulta.Retorno}>");
                else
                    StringEntidade.Append($"{consulta.Retorno}");

                StringEntidade.Append($" {consulta.Nome}(");

                // Parametros
                for (var i = 0; i < consulta.Parametros.Count; i++)
                {
                    var parametro = consulta.Parametros[i];

                    StringEntidade.Append($"{parametro.Key} {parametro.Value}");

                    if (i + 1 < consulta.Parametros.Count)
                        StringEntidade.Append(", ");
                }

                StringEntidade.Append(")\n");
                StringEntidade.Append("\t\t");
                StringEntidade.Append("{\n");

                StringEntidade.Append("\t\t\t");
                StringEntidade.Append("try\n");
                StringEntidade.Append("\t\t\t");
                StringEntidade.Append("{\n");

                GerarQuery(consulta, true);
                GerarQuery(consulta, false);

                StringEntidade.Append("\t\t\t\t");
                StringEntidade.Append("else\n");

                StringEntidade.Append("\t\t\t\t\t");
                StringEntidade.Append("throw new Exception(\"Provider não suportado!\");\n");
                StringEntidade.Append("\t\t\t");
                StringEntidade.Append("}\n");

                StringEntidade.Append("\t\t\t");
                StringEntidade.Append("finally\n");
                StringEntidade.Append("\t\t\t");
                StringEntidade.Append("{\n");

                StringEntidade.Append("\t\t\t\t");
                StringEntidade.Append("Conexao.Close();\n");
                StringEntidade.Append("\t\t\t");
                StringEntidade.Append("}\n");

                StringEntidade.Append("\t\t");
                StringEntidade.Append("}\n\n");
            }
        }

        private void GerarQuery(EntidadeConsulta consulta, bool sqlServer)
        {
            StringEntidade.Append("\t\t\t\t");

            if(sqlServer)
                StringEntidade.AppendLine("if (AppSettings.IS_SQL_SERVER_PROVIDER)");
            else
                StringEntidade.AppendLine("else if (AppSettings.IS_ORACLE_PROVIDER)");

            StringEntidade.Append("\t\t\t\t\t");

            if (consulta.Retorno != "void")
                StringEntidade.Append($"return ");

            StringEntidade.Append("Conexao.");

            if (!consulta.RetornaLista && consulta.Retorno != "void")
                StringEntidade.Append("QuerySingleOrDefault");
            else if (consulta.Retorno == "void")
                StringEntidade.Append("Execute");
            else
                StringEntidade.Append("Query");

            if (consulta.Retorno != "void")
                StringEntidade.Append($"<{consulta.Retorno}>");

            if(sqlServer)
                StringEntidade.Append($"(\"{consulta.QuerySqlServer}\", new {{ ");
            else
                StringEntidade.Append($"(\"{consulta.QueryOracle}\", new {{ ");

            // Parametros
            for (var i = 0; i < consulta.Parametros.Count; i++)
            {
                var parametro = consulta.Parametros[i];

                StringEntidade.Append($"{parametro.Value}");

                if (i + 1 < consulta.Parametros.Count)
                    StringEntidade.Append(", ");
            }

            StringEntidade.Append(" })");

            if (consulta.RetornaLista)
                StringEntidade.Append(".ToList()");

            StringEntidade.Append(";\n");
        }

        private void Fechar()
        {
            StringEntidade.AppendLine("\t}");
            StringEntidade.AppendLine("}");
        }

        #endregion
    }
}