using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Intech.Ferramentas.GeradorCodigo.Code
{
    public class Conexoes
    {
        public static string DiretorioArquivoConexoes =>
            Path.Combine(Directory.GetCurrentDirectory(), "conexoes.json");

        public static List<Conexao> Get()
        {
            if(File.Exists(DiretorioArquivoConexoes))
                return JsonConvert.DeserializeObject<List<Conexao>>(File.ReadAllText(DiretorioArquivoConexoes));

            return null;
        }

        public void Deletar(Conexao conexao)
        {
            var arquivo = File.OpenText(DiretorioArquivoConexoes);
            var conteudo = arquivo.ReadToEnd();

            var lista = JsonConvert.DeserializeObject<List<Conexao>>(conteudo);

            var conexaoExistente = lista.SingleOrDefault(x => x.ID == conexao.ID);

            if (conexaoExistente != null)
                lista.Remove(conexaoExistente);

            arquivo.Close();

            File.WriteAllText(DiretorioArquivoConexoes, JsonConvert.SerializeObject(lista, Formatting.Indented));
        }
        
        public void Salvar(Conexao conexao)
        {
            if (!File.Exists(DiretorioArquivoConexoes))
                File.Create(DiretorioArquivoConexoes).Close();

            var arquivo = File.OpenText(DiretorioArquivoConexoes);
            var conteudo = arquivo.ReadToEnd();

            List<Conexao> lista;

            if (string.IsNullOrEmpty(conteudo))
                lista = new List<Conexao>();
            else
                lista = JsonConvert.DeserializeObject<List<Conexao>>(conteudo);

            var conexaoExistente = lista.SingleOrDefault(x => x.ID == conexao.ID);

            if(conexaoExistente != null)
                lista.Remove(conexaoExistente);

            lista.Add(conexao);

            arquivo.Close();

            File.WriteAllText(DiretorioArquivoConexoes, JsonConvert.SerializeObject(lista, Formatting.Indented));
        }
    }

    public class Conexao
    {
        public Guid ID { get; set; }
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