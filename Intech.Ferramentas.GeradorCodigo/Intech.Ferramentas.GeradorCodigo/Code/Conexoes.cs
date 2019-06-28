using Newtonsoft.Json;
using System.IO;

namespace Intech.Ferramentas.GeradorCodigo.Code
{
    public class Conexoes : JsonListHelper<Conexao>
    {
        public Conexoes() :
            base(Path.Combine(Directory.GetCurrentDirectory(), "../conexoes.json"))
        {
            
        }
    }

    public class Conexao : JsonListItem
    {
        public string Provider { get; set; }
        public string DataSource { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }

        [JsonIgnore]
        public string ConnectionString =>
            $"Data Source={DataSource};Initial Catalog={Database};User ID={Username};Password={Password};Persist Security Info=True";
    }
}