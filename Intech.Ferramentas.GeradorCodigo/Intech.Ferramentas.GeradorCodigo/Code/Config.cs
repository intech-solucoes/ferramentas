using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Intech.Ferramentas.GeradorCodigo.Code
{
    public class ConfigManager
    {
        public static Config Get() => 
            JsonConvert.DeserializeObject<Config>(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "sistemas.json")));
    }

    public class Config
    {
        public List<Sistema> Sistema { get; set; }
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