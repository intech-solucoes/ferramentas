using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Intech.Ferramentas.GeradorCodigo.Code
{
    public abstract class JsonListHelper<T> where T : JsonListItem
    {
        public string FilePath { get; private set; }

        public JsonListHelper(string filePath)
        {
            FilePath = filePath;
        }

        public List<T> Lista
        {
            get
            {
                if (File.Exists(FilePath))
                    return JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(FilePath));

                return null;
            }
        }

        public T BuscarPorID(Guid ID)
        {
            var arquivo = File.OpenText(FilePath);
            var conteudo = arquivo.ReadToEnd();

            var lista = JsonConvert.DeserializeObject<List<T>>(conteudo);

            return lista.SingleOrDefault(x => x.ID == ID);
        }

        public void Deletar(T obj)
        {
            var arquivo = File.OpenText(FilePath);
            var conteudo = arquivo.ReadToEnd();

            var lista = JsonConvert.DeserializeObject<List<T>>(conteudo);

            var objExistente = lista.SingleOrDefault(x => x.ID == obj.ID);

            if (objExistente != null)
                lista.Remove(objExistente);

            arquivo.Close();

            File.WriteAllText(FilePath, JsonConvert.SerializeObject(lista, Formatting.Indented));
        }

        public void Salvar(T obj)
        {
            if (!File.Exists(FilePath))
                File.Create(FilePath).Close();

            var arquivo = File.OpenText(FilePath);
            var conteudo = arquivo.ReadToEnd();

            List<T> lista;

            if (string.IsNullOrEmpty(conteudo))
                lista = new List<T>();
            else
                lista = JsonConvert.DeserializeObject<List<T>>(conteudo);

            var objExistente = lista.SingleOrDefault(x => x.ID == obj.ID);

            if (objExistente != null)
                lista.Remove(objExistente);

            lista.Add(obj);

            arquivo.Close();

            File.WriteAllText(FilePath, JsonConvert.SerializeObject(lista, Formatting.Indented));
        }
    }
}