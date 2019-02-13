using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Intech.Ferramentas.GeradorCodigo.Code
{
    public class ConfigManager
    {
        public static Config Get() => 
            JsonConvert.DeserializeObject<Config>(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "config.json")));
    }

    public class Config
    {
        public List<Sistema> Sistema { get; set; }
        public Conexao Conexao { get; set; }

        public string ConnectionString =>
            PROVIDER_ORACLE ?
            $"data source={Conexao.DataSource};user id={Conexao.Username};password={Conexao.Password};persist security info=True" :
            $"Data Source={Conexao.DataSource};Initial Catalog={Conexao.Database};User ID={Conexao.Username};Password={Conexao.Password};Persist Security Info=True";

        public bool PROVIDER_ORACLE => Conexao.Provider == "oracle";
        public bool PROVIDER_SQL_SERVER => Conexao.Provider == "sqlserver";
    }

    public class Sistema
    {
        public string Nome { get; set; }
        public Camadas Diretorios { get; set; }
        public Camadas Namespaces { get; set; }
    }

    public class Camadas
    {
        public string Dados { get; set; }
        public string Entidades { get; set; }
        public string Negocio { get; set; }
    }
}
