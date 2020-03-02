#region Usings
using Newtonsoft.Json;
using System;
using System.IO; 
#endregion

namespace Intech.Ferramentas.Code
{
    public class UserConfigManager
    {
        public static string DiretorioArquivoUserConfig =>
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Intech");

        public static string CaminhoArquivoUserConfig =>
            Path.Combine(DiretorioArquivoUserConfig, "user_config.json");

        public static UserConfig Get()
        {
            if (File.Exists(CaminhoArquivoUserConfig))
                return JsonConvert.DeserializeObject<UserConfig>(File.ReadAllText(CaminhoArquivoUserConfig));

            return null;
        }

        public void Salvar(UserConfig userConfig)
        {
            if (!Directory.Exists(DiretorioArquivoUserConfig))
                Directory.CreateDirectory(DiretorioArquivoUserConfig);

            if (!File.Exists(CaminhoArquivoUserConfig))
                File.Create(CaminhoArquivoUserConfig).Close();

            File.WriteAllText(CaminhoArquivoUserConfig, JsonConvert.SerializeObject(userConfig, Formatting.Indented));
        }
    }

    public class UserConfig
    {
        public string GitBase { get; set; }
        public string UrlApi { get; set; }
    }
}