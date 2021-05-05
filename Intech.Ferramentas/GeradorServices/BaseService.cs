using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace GeradorServices
{
    public class BaseService
    {
        public static void CriarRequisicaoGet(string url)
        {
            var webRequest = WebRequest.Create(url);
            webRequest.Method = WebRequestMethods.Http.Get;
            webRequest.ContentType = "application/json; charset=utf-8";

            var response = (HttpWebResponse)webRequest.GetResponse();

            string resultadoJson = null;

            using (var streamReader = new StreamReader(response.GetResponseStream()))
                resultadoJson = streamReader.ReadToEnd();
        }

        public static TRetorno CriarRequisicaoGet<TRetorno>(string url)
        {
            var webRequest = WebRequest.Create(url);
            webRequest.Method = WebRequestMethods.Http.Get;
            webRequest.ContentType = "application/json; charset=utf-8";

            var response = (HttpWebResponse)webRequest.GetResponse();

            string resultadoJson = null;

            using (var streamReader = new StreamReader(response.GetResponseStream()))
                resultadoJson = streamReader.ReadToEnd();

            return JsonConvert.DeserializeObject<TRetorno>(resultadoJson, new JsonSerializerSettings() { DateFormatString = "dd/MM/yyyy hh:mm:ss" });
        }

        public static TRetorno CriarRequisicaoEnvio<TEnvio, TRetorno>(string url, TEnvio dados, string tipoRequisicao = WebRequestMethods.Http.Post)
        {
            try
            {
                var webRequest = WebRequest.Create(url);
                webRequest.Method = tipoRequisicao;
                webRequest.ContentType = "application/json; charset=utf-8";

                var jsonSerialize = JsonConvert.SerializeObject(dados);

                using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
                {
                    streamWriter.Write(jsonSerialize);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var response = (HttpWebResponse)webRequest.GetResponse();

                string resultadoJson = null;

                using (var streamReader = new StreamReader(response.GetResponseStream()))
                    resultadoJson = streamReader.ReadToEnd();

                return JsonConvert.DeserializeObject<TRetorno>(resultadoJson);
            }
            catch (WebException ex)
            {
                using (var stream = ex.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    throw new Exception(reader.ReadToEnd());
                }

                throw;
            }
        }
    }
}
