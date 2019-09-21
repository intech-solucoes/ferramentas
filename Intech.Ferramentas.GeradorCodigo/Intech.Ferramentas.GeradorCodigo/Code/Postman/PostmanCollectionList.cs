using System.Collections.Generic;

namespace Intech.Ferramentas.GeradorCodigo.Code.Postman
{
    public class PostmanCollectionList
    {
        public List<PostmanCollections> collections { get; set; }
    }

    public class PostmanCollections
    {
        public string id { get; set; }
        public string name { get; set; }
        public string owner { get; set; }
        public string uid { get; set; }
    }
}