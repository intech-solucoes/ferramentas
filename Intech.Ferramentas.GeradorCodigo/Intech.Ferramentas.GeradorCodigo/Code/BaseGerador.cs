#region Usings
using Intech.Lib.Data.Util.Tradutor;
using RazorEngine.Templating;
using Scriban;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; 
#endregion

namespace Intech.Ferramentas.GeradorCodigo.Code
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
            CriarConexao();

            foreach (var configEntidade in ConfigsEntidades)
            {
                BuscarColunas(configEntidade);
                BuscarConsultas(configEntidade);

                if(gerarEntidade) SalvarEntidade(configEntidade);
                if(gerarDAO) SalvarDAO(configEntidade);
                if (gerarProxy) SalvarProxy(configEntidade);

                ColunasEntidade.Clear();
                Consultas.Clear();
            }
        }

        public virtual void CriarConexao() => throw new NotImplementedException();
        public virtual void BuscarColunas(Entidade configEntidade) => throw new NotImplementedException();

        private void BuscarConsultas(Entidade configEntidade)
        {
            var arquivosSQL = DirScripts.GetDirectories(configEntidade.Nome).Single().EnumerateFiles().Where(x => x.Name.Contains(".sql"));

            // Executa a busca de consultas e parâmetros em todos os arquivos do diretório base
            foreach (var sqlFile in arquivosSQL)
            {
                var sql = sqlFile.OpenText().ReadToEnd();
                // Extrai config da consulta
                var configConsulta = ExtrairConfigConsulta(sql);

                if (configConsulta?.Retorno == null)
                    throw new Exception($"E necessario especificar um tipo de retorno na consulta {sqlFile.Name}");

                var querySqlServer = new Regex("\n").Replace(sql, " ");
                querySqlServer = new Regex("\r").Replace(querySqlServer, " ");
                querySqlServer = querySqlServer.Substring(querySqlServer.IndexOf("*/") + 2).Trim();

                var gerarInsertComPK = ColunasEntidade.Any(x => x.ChavePrimaria.HasValue && x.ChavePrimaria.Value);

                var queryOracle = new TradutorSqlToOracle().Traduz(querySqlServer, gerarInsertComPK);

                var consulta = new Consulta
                {
                    Nome = sqlFile.Name.Replace(".sql", string.Empty),
                    QuerySqlServer = querySqlServer,
                    QueryOracle = queryOracle,
                    Parametros = configConsulta.ParametrosConsulta,
                    Retorno = configConsulta.Retorno,
                    RetornaLista = configConsulta.RetornaLista
                };

                Consultas.Add(consulta);
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
                colunaExtra.IsColunaExtra = true;
                ColunasEntidade.Add(colunaExtra);
            }
        }

        protected void SalvarEntidade(Entidade configEntidade)
        {
            try
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
            } catch(Exception ex) { }
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
