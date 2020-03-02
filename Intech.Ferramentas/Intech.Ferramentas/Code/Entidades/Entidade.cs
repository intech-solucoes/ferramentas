using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Intech.Ferramentas.Code.Entidades
{
    public class Entidade
    {
        public string Nome { get; set; }
        public string NomeTabela { get; set; }
        public bool? Sinonimo { get; set; }
        public string ChavePrimaria { get; set; }
        public List<EntidadeColuna> ColunasExtras { get; set; } = new List<EntidadeColuna>();
        public List<string> Imports { get; set; } = new List<string>();

        public static Entidade Buscar(DirectoryInfo diretorio)
        {
            var entidade = JsonConvert.DeserializeObject<Entidade>(File.ReadAllText(Path.Combine(diretorio.FullName, "entidade.json")));
            entidade.Nome = diretorio.Name;
            return entidade;
        }
    }
}