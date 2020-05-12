#region Usings
using Intech.Lib.TradutorSqlOracle;
using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
#endregion

namespace Intech.Ferramentas.GeradorCodigo.Code.Gerador
{
    public abstract class BaseGerador
    {
        protected Config Config;
        protected Conexao ConfigConexao;
        protected Sistema Sistema;
        protected List<Entidade> ConfigsEntidades;
        protected List<Consulta> Consultas = new List<Consulta>();
        protected List<Coluna> ColunasEntidade = new List<Coluna>();

        DirectoryInfo DirScripts => new DirectoryInfo(Path.Combine(Sistema.Diretorios.Dados, "Scripts"));
        DirectoryInfo DirDAO => new DirectoryInfo(Path.Combine(Sistema.Diretorios.Dados, "DAO"));
        DirectoryInfo DirProxy => new DirectoryInfo(Path.Combine(Sistema.Diretorios.Negocio, "Proxy"));
        DirectoryInfo DirEntidades => new DirectoryInfo(Sistema.Diretorios.Entidades);

        public BaseGerador(Config config, Conexao conexao, Sistema sistemaSelecionado, List<Entidade> configsEntidades)
        {
            Config = config;
            ConfigConexao = conexao;
            ConfigsEntidades = configsEntidades;
            Sistema = sistemaSelecionado;
        }

        public void Gerar(bool gerarEntidade, bool gerarDAO, bool gerarProxy)
        {
            try
            {
                CriarConexao();

                foreach (var configEntidade in ConfigsEntidades)
                {
                    BuscarColunas(configEntidade);
                    BuscarConsultas(configEntidade);

                    if (gerarEntidade) SalvarEntidade(configEntidade);
                    if (gerarDAO) SalvarDAO(configEntidade);
                    if (gerarProxy) SalvarProxy(configEntidade);

                    ColunasEntidade.Clear();
                    Consultas.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public virtual void CriarConexao() => throw new NotImplementedException();
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

                var gerarInsertComPK = ColunasEntidade.Any(x => x.ChavePrimaria.HasValue && x.ChavePrimaria.Value);

                // Caso uma mesma query tenha a versão sqlserver e oracle separadas
                if (consultasSeparadas)
                {
                    var querySqlServer = arquivosSQL
                        .Single(x => x.Name.Contains(nomeQuery + ".sqlserver."))
                        .OpenText()
                        .ReadToEnd();

                    var configConsulta = ExtrairConfigConsulta(querySqlServer);

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

                    if (configConsulta?.Retorno == null)
                        throw new Exception($"E necessario especificar um tipo de retorno na consulta {sqlFile.Name}");

                    var consulta = new Consulta
                    {
                        Nome = nomeQuery,
                        QuerySqlServer = querySqlServer,
                        QueryOracle = queryOracle,
                        Parametros = configConsulta.ParametrosConsulta,
                        Retorno = configConsulta.Retorno,
                        RetornaLista = configConsulta.RetornaLista
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

                    var configConsulta = ExtrairConfigConsulta(querySqlServer);

                    querySqlServer = new Regex("\n").Replace(querySqlServer, " ");
                    querySqlServer = new Regex("\r").Replace(querySqlServer, " ")
                        .Substring(querySqlServer.IndexOf("*/") + 2).Trim();

                    if (configConsulta?.Retorno == null)
                        throw new Exception($"E necessario especificar um tipo de retorno na consulta {sqlFile.Name}");

                    var consulta = new Consulta
                    {
                        Nome = nomeQuery,
                        QuerySqlServer = querySqlServer,
                        QueryOracle = string.Empty,
                        Parametros = configConsulta.ParametrosConsulta,
                        Retorno = configConsulta.Retorno,
                        RetornaLista = configConsulta.RetornaLista
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

                    var configConsulta = ExtrairConfigConsulta(queryOracle);

                    queryOracle = new Regex("\n").Replace(queryOracle, " ");
                    queryOracle = new Regex("\r").Replace(queryOracle, " ")
                        .Substring(queryOracle.IndexOf("*/") + 2).Trim();

                    if (configConsulta?.Retorno == null)
                        throw new Exception($"E necessario especificar um tipo de retorno na consulta {sqlFile.Name}");

                    var consulta = new Consulta
                    {
                        Nome = nomeQuery,
                        QuerySqlServer = string.Empty,
                        QueryOracle = queryOracle,
                        Parametros = configConsulta.ParametrosConsulta,
                        Retorno = configConsulta.Retorno,
                        RetornaLista = configConsulta.RetornaLista
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

                    var configConsulta = ExtrairConfigConsulta(querySqlServer);

                    querySqlServer = new Regex("\n").Replace(querySqlServer, " ");
                    querySqlServer = new Regex("\r").Replace(querySqlServer, " ")
                        .Substring(querySqlServer.IndexOf("*/") + 2).Trim();

                    var queryOracle = new TradutorSqlToOracle().Traduz(querySqlServer, gerarInsertComPK);

                    if (configConsulta?.Retorno == null)
                        throw new Exception($"E necessario especificar um tipo de retorno na consulta {sqlFile.Name}");

                    var consulta = new Consulta
                    {
                        Nome = nomeQuery,
                        QuerySqlServer = querySqlServer,
                        QueryOracle = queryOracle,
                        Parametros = configConsulta.ParametrosConsulta,
                        Retorno = configConsulta.Retorno,
                        RetornaLista = configConsulta.RetornaLista
                    };

                    Consultas.Add(consulta);
                    arquivosJaProcessados.Add(sqlFile.Name);
                }

                //var sql = sqlFile.OpenText().ReadToEnd();
                //// Extrai config da consulta
                //var configConsulta = ExtrairConfigConsulta(sql);

                //if (configConsulta?.Retorno == null)
                //    throw new Exception($"E necessario especificar um tipo de retorno na consulta {sqlFile.Name}");

                //var querySqlServer = new Regex("\n").Replace(sql, " ");
                //querySqlServer = new Regex("\r").Replace(querySqlServer, " ");
                //querySqlServer = querySqlServer.Substring(querySqlServer.IndexOf("*/") + 2).Trim();

                //var gerarInsertComPK = ColunasEntidade.Any(x => x.ChavePrimaria.HasValue && x.ChavePrimaria.Value);

                //var queryOracle = "";

                //// Se não tiver .sqlserver nem .oracle no nome, traduz pra oracle normalmente
                //if (!sqlFile.Name.Contains(".sqlserver.") && !sqlFile.Name.Contains(".oracle."))
                //{
                //    queryOracle = new TradutorSqlToOracle().Traduz(querySqlServer, gerarInsertComPK);
                //}
                //// se tiver .oracle, a query do arquivo será a query do oracle sem tradução
                //else if (sqlFile.Name.Contains(".oracle."))
                //{
                //    queryOracle = querySqlServer;
                //}

                //var consulta = new Consulta
                //{
                //    Nome = nomeQuery,
                //    QuerySqlServer = querySqlServer,
                //    QueryOracle = queryOracle,
                //    Parametros = configConsulta.ParametrosConsulta,
                //    Retorno = configConsulta.Retorno,
                //    RetornaLista = configConsulta.RetornaLista
                //};

                //Consultas.Add(consulta);
            }
        }

        public void AdicionarColunas(Entidade configEntidade, List<Coluna> colunas)
        {
            colunas.ForEach(coluna =>
            {
                if (!ColunasEntidade.Any(x => x.Nome == coluna.Nome))
                    ColunasEntidade.Add(coluna);
            });

            foreach (var colunaExtra in configEntidade.ColunasExtras)
            {
                colunaExtra.TipoTS = MapeiaTipoDotNetParaTS(colunaExtra.Tipo);
                colunaExtra.ChavePrimaria = false;
                colunaExtra.IsColunaExtra = true;
                ColunasEntidade.Add(colunaExtra);

                if (colunaExtra.TipoTS.Contains("Entidade"))
                {
                    configEntidade.Imports.Add(colunaExtra.TipoTS.Replace("Array<", "").Replace(">", ""));
                }
            }
        }

        protected void SalvarEntidade(Entidade configEntidade)
        {
            var model = new
            {
                Config,
                Sistema,
                ConfigEntidade = configEntidade,
                ColunasEntidade
            };

            var template = File.ReadAllText("Templates/Entidade.template");
            var entidade = RazorEngine.Engine.Razor.RunCompile(template, "templateEntidade", null, model);

            File.WriteAllText(Path.Combine(DirEntidades.FullName, $"{configEntidade.Nome}Entidade.cs"), entidade, Encoding.UTF8);

            var projetosDependentes = new Projetos().BuscarPorSistema(Sistema.Nome);

            foreach (var projeto in projetosDependentes)
            {
                var dirEntidades = Path.Combine(projeto.Diretorio, "src", "entidades");

                if (!Directory.Exists(dirEntidades))
                    Directory.CreateDirectory(dirEntidades);

                var templateTS = File.ReadAllText("Templates/EntidadeTS.template");
                var entidadeTS = RazorEngine.Engine.Razor.RunCompile(templateTS, "templateEntidadeTS", null, model);

                File.WriteAllText(Path.Combine(dirEntidades, $"{configEntidade.Nome}Entidade.tsx"), entidadeTS, Encoding.UTF8);

                // Salva index.tsx
                var listaEntidades = Directory.GetFiles(dirEntidades).ToList();
                var entidadesIndex = new List<string>();
                foreach (var ent in listaEntidades)
                {
                    var arquivo = new FileInfo(ent);
                    if (arquivo.Name != "index.tsx")
                        entidadesIndex.Add(arquivo.Name.Replace(".tsx", ""));
                }

                var entidadesIndexTemplateFile = File.ReadAllText("Templates/EntidadeTSIndex.template");
                var serviceIndexTemplate = RazorEngine.Engine.Razor.RunCompile(entidadesIndexTemplateFile, "templateEntidadesIndex", null, entidadesIndex);
                File.WriteAllText(Path.Combine(dirEntidades, $"index.tsx"), serviceIndexTemplate, Encoding.UTF8);
            }
        }

        protected void SalvarDAO(Entidade configEntidade)
        {
            var model = new
            {
                Config,
                Sistema,
                ConfigEntidade = configEntidade,
                Consultas,
                ColunasEntidade
            };

            var template = File.ReadAllText("Templates/DAO.template");
            var dao = RazorEngine.Engine.Razor.RunCompile(template, "templateDao", null, model);

            File.WriteAllText(Path.Combine(DirDAO.FullName, $"{configEntidade.Nome}DAO.cs"), dao, Encoding.UTF8);
        }

        protected void SalvarProxy(Entidade configEntidade)
        {
            var model = new
            {
                Config,
                Sistema,
                ConfigEntidade = configEntidade,
                Consultas,
                ColunasEntidade
            };

            var template = File.ReadAllText("Templates/Proxy.template");
            var dao = RazorEngine.Engine.Razor.RunCompile(template, "templateProxy", null, model);

            File.WriteAllText(Path.Combine(DirProxy.FullName, $"{configEntidade.Nome}Proxy.cs"), dao, Encoding.UTF8);
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
            var lista = type.Contains("List<");
            var tipo = type.Replace("List<", "").Replace(">", "");
            string tipoTraduzido;

            switch (tipo.ToUpper())
            {
                case "DECIMAL":
                case "INT":
                    tipoTraduzido = "number";
                    break;
                case "BOOL":
                    tipoTraduzido = "boolean";
                    break;
                case "DATE":
                case "DATETIME":
                    tipoTraduzido = "Date";
                    break;
                case "STRING":
                    tipoTraduzido = "string";
                    break;
                default:
                    if (type.Contains("List<"))
                    {
                        type = type.Replace("List<", "").Replace(">", "");
                        type = MapeiaTipoDotNetParaTS(type);
                        return $"Array<{type}>";
                    }
                    else if (type.Contains("Entidade"))
                        return type;
                    else
                        throw new Exception(string.Format("Tipo não mapeado: {0}", type));
            }

            if (lista)
                return $"Array<{tipoTraduzido}>";
            else
                return tipoTraduzido;
        }

        #region Métodos Privados

        private static ConfigConsulta ExtrairConfigConsulta(string sql)
        {
            var reader = new StringReader(sql);

            // Lê a primeira linha e verifica se utiliza parametrização
            var linha = reader.ReadLine();

            if (linha != "/*Config")
                return null;

            var parametros = new ConfigConsulta();
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
        private static void ProcessaRetorno(ConfigConsulta parametros, StringReader reader, out string linha)
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
        private static void ProcessaParametros(ConfigConsulta parametros, StringReader reader, out string linha)
        {
            linha = reader.ReadLine().Trim();

            while (linha.StartsWith("-"))
            {
                var nomeParametro = linha.Substring(1, linha.IndexOf(":") - 1);
                var tipoParametro = linha.Substring(linha.IndexOf(":") + 1);

                parametros.ParametrosConsulta.Add(new KeyValuePair<string, string>(tipoParametro, nomeParametro));

                linha = reader.ReadLine().Trim();
            }
        }

        #endregion
    }
}
