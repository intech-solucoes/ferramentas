#region Usings
using Intech.Ferramentas.Code.Entidades;
using Intech.Ferramentas.Code.Gerador.Classes;
using Intech.Ferramentas.Dados.Entidades;
using Intech.Ferramentas.Services;
using Intech.Lib.TradutorSqlOracle;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
#endregion

namespace Intech.Ferramentas.Code.Gerador
{
    public abstract class BaseGerador
    {
        protected ConexaoEntidade Conexao;
        protected SistemaEntidade Sistema;
        protected ProjetoEntidade Projeto;
        protected List<Entidade> Entidades;
        protected List<EntidadeConsulta> Consultas = new List<EntidadeConsulta>();
        protected List<EntidadeColuna> Colunas = new List<EntidadeColuna>();

        DirectoryInfo DirScripts => new DirectoryInfo(Path.Combine(UserConfigManager.Get().GitBase, Sistema.TXT_DIRETORIO_DADOS, "Scripts"));
        DirectoryInfo DirDAO => new DirectoryInfo(Path.Combine(UserConfigManager.Get().GitBase, Sistema.TXT_DIRETORIO_DADOS, "DAO"));
        DirectoryInfo DirProxy => new DirectoryInfo(Path.Combine(UserConfigManager.Get().GitBase, Sistema.TXT_DIRETORIO_NEGOCIO, "Proxy"));
        DirectoryInfo DirEntidades => new DirectoryInfo(Path.Combine(UserConfigManager.Get().GitBase, Sistema.TXT_DIRETORIO_ENTIDADES));

        public BaseGerador(ConexaoEntidade conexao, SistemaEntidade sistema, ProjetoEntidade projeto, List<Entidade> entidades)
        {
            Conexao = conexao;
            Entidades = entidades;
            Sistema = sistema;
            Projeto = projeto;
        }

        public void Gerar(bool gerarEntidade, bool gerarDAO, bool gerarProxy)
        {
            foreach (var configEntidade in Entidades)
            {
                BuscarColunas(configEntidade);
                BuscarConsultas(configEntidade);

                if (gerarEntidade) SalvarEntidade(configEntidade);
                if (gerarDAO) SalvarDAO(configEntidade);
                if (gerarProxy) SalvarProxy(configEntidade);

                Colunas.Clear();
                Consultas.Clear();
            }
        }

        public virtual void BuscarColunas(Entidade configEntidade) => throw new NotImplementedException();

        private void BuscarConsultas(Entidade configEntidade)
        {
            var arquivosSQL = DirScripts.GetDirectories(configEntidade.Nome).Single().EnumerateFiles().Where(x => x.Name.EndsWith(".sql"));
            var arquivosJaProcessados = new List<string>();

            // Executa a busca de consultas e parâmetros em todos os arquivos do diretório base
            foreach (var sqlFile in arquivosSQL)
            {
                if (arquivosJaProcessados.Contains(sqlFile.Name))
                    return;

                var nomeQuery = sqlFile.Name.Replace(".oracle", string.Empty).Replace(".sqlserver", string.Empty).Replace(".sql", string.Empty);

                var consultaOracle = false;
                var consultaSQLServer = false;
                var consultasSeparadas = false;

                if (arquivosSQL.Any(x => x.Name.Contains(nomeQuery + ".sqlserver.")) && arquivosSQL.Any(x => x.Name.Contains(nomeQuery + ".oracle.")))
                    consultasSeparadas = true;

                else if (sqlFile.Name.Contains(".oracle."))
                    consultaOracle = true;

                else if (sqlFile.Name.Contains(".sqlserver."))
                    consultaSQLServer = true;

                var gerarInsertComPK = Colunas.Any(x => x.ChavePrimaria.HasValue && x.ChavePrimaria.Value);

                // Caso uma mesma query tenha a versão sqlserver e oracle separadas
                if (consultasSeparadas)
                {
                    var querySqlServer = arquivosSQL
                        .Single(x => x.Name.Contains(nomeQuery + ".sqlserver."))
                        .OpenText()
                        .ReadToEnd();

                    var EntidadeConsulta = ExtrairEntidadeConsulta(querySqlServer);

                    querySqlServer = new Regex("\n").Replace(querySqlServer, " ");
                    querySqlServer = new Regex("\r").Replace(querySqlServer, " ")
                        .Substring(querySqlServer.IndexOf("*/") + 2).Trim();

                    var queryOracle = arquivosSQL
                        .Single(x => x.Name.Contains(nomeQuery + ".oracle."))
                        .OpenText()
                        .ReadToEnd();

                    queryOracle = new Regex("\n").Replace(queryOracle, " ");
                    queryOracle = new Regex("\r").Replace(queryOracle, " ")
                        .Substring(queryOracle.IndexOf("*/") + 2).Trim();

                    if (EntidadeConsulta?.Retorno == null)
                        throw new Exception($"E necessario especificar um tipo de retorno na consulta {sqlFile.Name}");

                    var consulta = new EntidadeConsulta
                    {
                        Nome = nomeQuery,
                        QuerySqlServer = querySqlServer,
                        QueryOracle = queryOracle,
                        Parametros = EntidadeConsulta.Parametros,
                        Retorno = EntidadeConsulta.Retorno,
                        RetornaLista = EntidadeConsulta.RetornaLista
                    };

                    Consultas.Add(consulta);
                    arquivosJaProcessados.Add(arquivosSQL.Single(x => x.Name.Contains(nomeQuery + ".sqlserver.")).Name);
                    arquivosJaProcessados.Add(arquivosSQL.Single(x => x.Name.Contains(nomeQuery + ".oracle.")).Name);
                }

                // Caso exista uma query apenas para sqlserver
                else if (consultaSQLServer)
                {
                    var querySqlServer = sqlFile
                        .OpenText()
                        .ReadToEnd();

                    var EntidadeConsulta = ExtrairEntidadeConsulta(querySqlServer);

                    querySqlServer = new Regex("\n").Replace(querySqlServer, " ");
                    querySqlServer = new Regex("\r").Replace(querySqlServer, " ")
                        .Substring(querySqlServer.IndexOf("*/") + 2).Trim();

                    if (EntidadeConsulta?.Retorno == null)
                        throw new Exception($"E necessario especificar um tipo de retorno na consulta {sqlFile.Name}");

                    var consulta = new EntidadeConsulta
                    {
                        Nome = nomeQuery,
                        QuerySqlServer = querySqlServer,
                        QueryOracle = string.Empty,
                        Parametros = EntidadeConsulta.Parametros,
                        Retorno = EntidadeConsulta.Retorno,
                        RetornaLista = EntidadeConsulta.RetornaLista
                    };

                    Consultas.Add(consulta);
                    arquivosJaProcessados.Add(sqlFile.Name);
                }

                // Caso exista uma query apenas para oracle
                else if (consultaOracle)
                {
                    var queryOracle = sqlFile
                        .OpenText()
                        .ReadToEnd();

                    var EntidadeConsulta = ExtrairEntidadeConsulta(queryOracle);

                    queryOracle = new Regex("\n").Replace(queryOracle, " ");
                    queryOracle = new Regex("\r").Replace(queryOracle, " ")
                        .Substring(queryOracle.IndexOf("*/") + 2).Trim();

                    if (EntidadeConsulta?.Retorno == null)
                        throw new Exception($"E necessario especificar um tipo de retorno na consulta {sqlFile.Name}");

                    var consulta = new EntidadeConsulta
                    {
                        Nome = nomeQuery,
                        QuerySqlServer = string.Empty,
                        QueryOracle = queryOracle,
                        Parametros = EntidadeConsulta.Parametros,
                        Retorno = EntidadeConsulta.Retorno,
                        RetornaLista = EntidadeConsulta.RetornaLista
                    };

                    Consultas.Add(consulta);
                    arquivosJaProcessados.Add(sqlFile.Name);
                }

                // Caminho padrão. Gera sqlserver e traduz para oracle
                else
                {
                    var querySqlServer = sqlFile
                        .OpenText()
                        .ReadToEnd();

                    var EntidadeConsulta = ExtrairEntidadeConsulta(querySqlServer);

                    querySqlServer = new Regex("\n").Replace(querySqlServer, " ");
                    querySqlServer = new Regex("\r").Replace(querySqlServer, " ")
                        .Substring(querySqlServer.IndexOf("*/") + 2).Trim();

                    var queryOracle = new TradutorSqlToOracle().Traduz(querySqlServer, gerarInsertComPK);

                    if (EntidadeConsulta?.Retorno == null)
                        throw new Exception($"E necessario especificar um tipo de retorno na consulta {sqlFile.Name}");

                    var consulta = new EntidadeConsulta
                    {
                        Nome = nomeQuery,
                        QuerySqlServer = querySqlServer,
                        QueryOracle = queryOracle,
                        Parametros = EntidadeConsulta.Parametros,
                        Retorno = EntidadeConsulta.Retorno,
                        RetornaLista = EntidadeConsulta.RetornaLista
                    };

                    Consultas.Add(consulta);
                    arquivosJaProcessados.Add(sqlFile.Name);
                }
            }
        }

        public void AdicionarColunas(Entidade configEntidade, List<EntidadeColuna> colunas)
        {
            colunas.ForEach(coluna =>
            {
                if (!Colunas.Any(x => x.Nome == coluna.Nome))
                    Colunas.Add(coluna);
            });

            foreach (var colunaExtra in configEntidade.ColunasExtras)
            {
                colunaExtra.TipoTS = MapeiaTipoDotNetParaTS(colunaExtra.Tipo);
                colunaExtra.ChavePrimaria = false;
                colunaExtra.IsColunaExtra = true;
                Colunas.Add(colunaExtra);

                if (colunaExtra.TipoTS.Contains("Entidade"))
                {
                    configEntidade.Imports.Add(colunaExtra.TipoTS.Replace("Array<", "").Replace(">", ""));
                }
            }
        }

        protected void SalvarEntidade(Entidade entidade)
        {
            var entidadeString = new GeradorEntidade(Sistema, entidade, Colunas).Gerar();
            File.WriteAllText(Path.Combine(DirEntidades.FullName, $"{entidade.Nome}Entidade.cs"), entidadeString, Encoding.UTF8);

            if (Projeto != null)
            {
                SalvarEntidadeTS(Projeto, entidade);
            }
            else
            {
                var projetosDependentes = ProjetoService.BuscarPorOidSistema(Sistema.OID_SISTEMA);

                foreach (var projeto in projetosDependentes)
                {
                    SalvarEntidadeTS(projeto, entidade);
                }
            }
        }

        protected void SalvarEntidadeTS(ProjetoEntidade projeto, Entidade entidade)
        {
            var dirEntidades = Path.Combine(UserConfigManager.Get().GitBase, projeto.TXT_DIRETORIO, "src", "entidades");

            if (!Directory.Exists(dirEntidades))
                Directory.CreateDirectory(dirEntidades);

            var entidadeTS = new GeradorEntidadeTS(entidade, Colunas).Gerar();

            File.WriteAllText(Path.Combine(dirEntidades, $"{entidade.Nome}Entidade.tsx"), entidadeTS, Encoding.UTF8);

            // Salva index.tsx
            var listaEntidades = Directory.GetFiles(dirEntidades).ToList();
            var entidadesIndex = new List<string>();
            foreach (var ent in listaEntidades)
            {
                var arquivo = new FileInfo(ent);
                if (arquivo.Name != "index.tsx")
                    entidadesIndex.Add(arquivo.Name.Replace(".tsx", ""));
            }

            var entidadeTSIndex = new GeradorEntidadeTSIndex(entidadesIndex).Gerar();
            File.WriteAllText(Path.Combine(dirEntidades, $"index.tsx"), entidadeTSIndex, Encoding.UTF8);
        }

        protected void SalvarDAO(Entidade entidade)
        {
            var entidadeDAO = new GeradorDAO(Sistema, Projeto, entidade, Consultas).Gerar();
            File.WriteAllText(Path.Combine(DirDAO.FullName, $"{entidade.Nome}DAO.cs"), entidadeDAO, Encoding.UTF8);
        }

        protected void SalvarProxy(Entidade entidade)
        {
            var entidadeProxy = new GeradorProxy(Sistema, entidade).Gerar();
            File.WriteAllText(Path.Combine(DirProxy.FullName, $"{entidade.Nome}Proxy.cs"), entidadeProxy, Encoding.UTF8);
        }

        /// <summary>
        /// Mapeia os tipos de colunas para tipos do .net
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        protected string MapeiaTipo(string type)
        {
            switch (type.ToUpper())
            {
                case "BIGINT":
                case "FLOAT":
                case "LONG":
                case "MONEY":
                case "NUMERIC":
                case "NUMBER":
                case "SMALLINT":
                case "SMALLMONEY":
                case "DECIMAL":
                    return "decimal";
                case "STRING":
                case "TEXT":
                case "CHAR":
                case "VARCHAR":
                case "VARCHAR2":
                case "NVARCHAR":
                case "ANSISTRING":
                case "VARBINARY":
                case "NCHAR":
                    return "string";
                case "DATE":
                case "DATETIME":
                    return "DateTime";
                case "INT":
                case "INT32":
                case "INT16":
                    return "int";
                default:
                    throw new Exception(string.Format("Tipo não mapeado: {0}", type));
            }
        }

        /// <summary>
        /// Mapeia os tipos de colunas para tipos do Typescript
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        protected string MapeiaTipoTS(string type)
        {
            switch (type.ToUpper())
            {
                case "BIGINT":
                case "FLOAT":
                case "LONG":
                case "MONEY":
                case "NUMERIC":
                case "NUMBER":
                case "SMALLINT":
                case "SMALLMONEY":
                case "DECIMAL":
                case "INT":
                case "INT32":
                case "INT16":
                    return "number";
                case "STRING":
                case "TEXT":
                case "CHAR":
                case "VARCHAR":
                case "VARCHAR2":
                case "NVARCHAR":
                case "ANSISTRING":
                case "VARBINARY":
                case "NCHAR":
                    return "string";
                case "DATE":
                case "DATETIME":
                    return "Date";
                default:
                    throw new Exception(string.Format("Tipo não mapeado: {0}", type));
            }
        }

        /// <summary>
        /// Mapeia os tipos de colunas para tipos do .Net para Typescript
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        protected string MapeiaTipoDotNetParaTS(string type)
        {
            switch (type.ToUpper())
            {
                case "DECIMAL":
                case "INT":
                    return "number";
                case "BOOL":
                    return "boolean";
                case "STRING":
                    return "string";
                case "DATE":
                case "DATETIME":
                    return "Date";
                default:
                    if (type.Contains("List<"))
                        return type.Replace("List", "Array");
                    else if (type.Contains("Entidade"))
                        return type;
                    else
                        throw new Exception(string.Format("Tipo não mapeado: {0}", type));
            }
        }

        #region Métodos Privados

        private static EntidadeConsulta ExtrairEntidadeConsulta(string sql)
        {
            var reader = new StringReader(sql);

            // Lê a primeira linha e verifica se utiliza parametrização
            var linha = reader.ReadLine();

            if (linha != "/*Config")
                return null;

            var parametros = new EntidadeConsulta();
            linha = reader.ReadLine();

            while (linha != null && linha != "*/")
            {
                if (linha.Trim() == "RetornaLista")
                {
                    parametros.RetornaLista = true;
                    linha = reader.ReadLine();
                }
                else if (linha.Trim() == "Retorno")
                    ProcessaRetorno(parametros, reader, out linha);
                else if (linha.Trim() == "Parametros")
                    ProcessaParametros(parametros, reader, out linha);
            }

            reader.Close();
            reader.Dispose();

            return parametros;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parametros"></param>
        /// <param name="reader"></param>
        /// <param name="linha"></param>
        private static void ProcessaRetorno(EntidadeConsulta parametros, StringReader reader, out string linha)
        {
            linha = reader.ReadLine().Trim();

            while (linha.StartsWith("-"))
            {
                parametros.Retorno = linha.Substring(1);
                linha = reader.ReadLine().Trim();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parametros"></param>
        /// <param name="reader"></param>
        /// <param name="linha"></param>
        private static void ProcessaParametros(EntidadeConsulta parametros, StringReader reader, out string linha)
        {
            linha = reader.ReadLine().Trim();

            while (linha.StartsWith("-"))
            {
                var nomeParametro = linha.Substring(1, linha.IndexOf(":") - 1);
                var tipoParametro = linha.Substring(linha.IndexOf(":") + 1);

                parametros.Parametros.Add(new KeyValuePair<string, string>(tipoParametro, nomeParametro));

                linha = reader.ReadLine().Trim();
            }
        }

        #endregion
    }
}
