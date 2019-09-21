using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intech.Ferramentas.GeradorCodigo.Code.Postman
{
    public class PostmanCollection
    {
        public PostmanCollectionObj collection { get; set; }
    }

    public class PostmanCollectionObj
    {
        public PostmanCollectionInfo info { get; set; }
        public List<PostmanCollectionItem> item { get; set; }
    }

    public class PostmanCollectionInfo
    {
        [JsonProperty(PropertyName = "_postman_id")]
        public string postmanID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string schema { get; set; }
    }

    public class PostmanCollectionItem
    {
        [JsonProperty(PropertyName = "_postman_id")]
        public string postmanID { get; set; }
        public string name { get; set; }
        public List<PostmanCollectionItem> item { get; set; }
        public PostmanRequest request { get; set; }
    }

    public class PostmanRequest
    {
        public PostmanUrl url { get; set; }
        public string method { get; set; }
        public string description { get; set; }
        public List<PostmanHeader> header { get; set; }
        public PostmanBody body { get; set; }
    }

    public class PostmanUrl
    {
        public string raw { get; set; }
        public List<string> host { get; set; }
        public List<string> path { get; set; }
    }

    public class PostmanHeader
    {
        public PostmanHeader(string key, string value)
        {
            this.key = key;
            this.value = value;
        }

        public string key { get; set; }
        public string value { get; set; }
    }

    public class PostmanBody
    {
        public PostmanBody()
        {
            mode = "raw";
            //raw = JsonConvert.SerializeObject(data, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Include });
        }

        public string mode { get; set; }
        public string raw { get; set; }
    }
}