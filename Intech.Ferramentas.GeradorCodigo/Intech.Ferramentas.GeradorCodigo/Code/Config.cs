using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Intech.Ferramentas.GeradorCodigo.Code
{
    public class ConfigManager
    {
        public static Config Config =>
            JsonConvert.DeserializeObject<Config>(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../config.json")));

        public static UserConfig UserConfig =>
            UserConfigManager.Get();
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
        private string _dados;
        public string Dados
        {
            get => string.Format(_dados, UserConfigManager.Get().GitBase);
            set => _dados = value;
        }

        private string _entidades;
        public string Entidades
        {
            get => string.Format(_entidades, UserConfigManager.Get().GitBase);
            set => _entidades = value;
        }

        private string _negocio;
        public string Negocio
        {
            get => string.Format(_negocio, UserConfigManager.Get().GitBase);
            set => _negocio = value;
        }
    }
}