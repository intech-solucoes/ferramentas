using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Tiny.RestClient;

namespace Intech.Ferramentas.GeradorCodigo.Code.Postman
{
    public class PostmanService
    {
        private TinyRestClient Client;

        public PostmanService()
        {
            Client = new TinyRestClient(new HttpClient(), "https://api.getpostman.com/");
            Client.Settings.DefaultHeaders.Add("X-Api-Key", "88d96b1dbe8946ecaecee62807879e86");
        }

        public async Task<PostmanCollectionList> BuscarCollections()
            => await Client.GetRequest("collections").ExecuteAsync<PostmanCollectionList>();

        public async Task<PostmanCollection> BuscarCollectionPorNome(string nome)
        {
            var collections = await BuscarCollections();
            var collectionInfo = collections.collections.SingleOrDefault(x => x.name == nome);

            if (collectionInfo == null)
                return null;

            return await Client.GetRequest($"collections/{collectionInfo.uid}").ExecuteAsync<PostmanCollection>();
        }
        public async Task CriarCollection(PostmanCollection collection)
        {
            var content = JsonConvert.SerializeObject(collection, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var responseString = await "https://api.getpostman.com/collections"
                .WithHeader("X-Api-Key", "88d96b1dbe8946ecaecee62807879e86")
                .PostStringAsync(content)
                .ReceiveString();
        }

        public async Task AtualizarCollection(PostmanCollection collection)
        {
            var collections = await BuscarCollections();
            var collectionInfo = collections.collections.SingleOrDefault(x => x.name == collection.collection.info.name);

            var content = JsonConvert.SerializeObject(collection, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var responseString = await $"https://api.getpostman.com/collections/{collectionInfo.uid}"
                .WithHeader("X-Api-Key", "88d96b1dbe8946ecaecee62807879e86")
                .PutStringAsync(content)
                .ReceiveString();
        }

        public async Task DeletarCollection(string uid)
            => await Client.DeleteRequest($"collections/{uid}").ExecuteAsync();


        public async Task CriarOuAtualizarCollection(PostmanCollection collection)
        {
            var collectionExistente = await BuscarCollectionPorNome(collection.collection.info.name);

            if (collectionExistente != null)
                await AtualizarCollection(collection);
            else
                await CriarCollection(collection);
        }
    }
}