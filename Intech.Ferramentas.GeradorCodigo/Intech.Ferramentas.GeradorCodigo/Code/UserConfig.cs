using Newtonsoft.Json;
using System;
using System.IO;

namespace Intech.Ferramentas.GeradorCodigo.Code
{
    public class UserConfigManager
    {


        public static string DiretorioArquivoUserConfig =>
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Intech", "user_config.json");

        public static UserConfig Get()
        {
            if (File.Exists(DiretorioArquivoUserConfig))
                return JsonConvert.DeserializeObject<UserConfig>(File.ReadAllText(DiretorioArquivoUserConfig));

            return null;
        }

        public void Salvar(UserConfig userConfig)
        {
            File.WriteAllText(DiretorioArquivoUserConfig, JsonConvert.SerializeObject(userConfig, Formatting.Indented));
        }
    }

    public class UserConfig
    {
        public string GitBase { get; set; }
    }
}