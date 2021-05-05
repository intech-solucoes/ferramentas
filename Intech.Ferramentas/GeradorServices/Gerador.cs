using Intech.Lib.Web.API;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;

namespace GeradorServices
{
    public class Gerador
    {
        public StringBuilder SB { get; set; }
        internal static ProxyDomain AsmLoaderProxy { get; set; }
        public string DiretorioGit { get; }
        public string ApiUrl { get; }
        public ProjetoEntidade Projeto { get; }

        private readonly List<Service> ListaServices = new List<Service>();

        public Gerador(decimal oidPprojeto, string diretorioGit, string apiUrl)
        {
            DiretorioGit = diretorioGit;
			ApiUrl = apiUrl;

			Projeto = BuscarProjeto(oidPprojeto);
		}

		public void Gerar()
        {
            ExtrairDados();
            GerarClasse();

            Console.WriteLine("Services gerados com sucesso!");
        }

        private void ExtrairDados()
        {
            var caminho = Path.Combine(DiretorioGit, Projeto.TXT_DIRETORIO, $"bin\\Debug\\netcoreapp2.2\\{Projeto.TXT_NAMESPACE}.dll");
            var assembly = Assembly.LoadFile(caminho);

            var caminhoEntidades = $"{DiretorioGit}\\{Projeto.Sistema.TXT_DIRETORIO_ENTIDADES}\\bin\\Debug\\netstandard2.0\\{Projeto.Sistema.TXT_NAMESPACE_ENTIDADES}.dll";
            CarregarDLL(caminhoEntidades);

            var apis = AppDomain.CurrentDomain.GetAssemblies()
                .Single(x => x.GetName().Name == assembly.GetName().Name)
                .GetTypes();

            var controllers = apis
                .Where(x => x.CustomAttributes.Any(x => x.AttributeType.Name == "ApiControllerAttribute"))
                .ToList();

            foreach (var controller in controllers)
            {
                var serviceObj = new Service
                {
                    Nome = controller.Name.Replace("Controller", ""),
                    Metodos = new List<ServiceMetodo>(),
                    Imports = new List<string>()
                };

                var endpoints = controller
                    .GetMethods()
                    .Where(x => x.DeclaringType.Name == controller.Name)
                    .ToList();

                foreach (var endpoint in endpoints)
                {
                    var httpMethodAttribute = endpoint.CustomAttributes.FirstOrDefault(x => x.AttributeType.BaseType.Name == "HttpMethodAttribute");

                    if (httpMethodAttribute == null)
                        continue;
                    //throw new Exception($"Nenhum atributo HttpGet ou HttpPost encontrado no método {endpoint.Name}");

                    var caminhoRota = httpMethodAttribute.ConstructorArguments.Count > 0 ? (string)httpMethodAttribute.ConstructorArguments[0].Value : "";
                    caminhoRota = caminhoRota.Replace("{", "${");
                    var tipoRota = httpMethodAttribute.AttributeType.Name == "HttpGetAttribute" ? "GET" : "POST";

                    TipoResposta resposta = TipoResposta.Normal;
                    var retorno = "any";

                    var retornoAttr = endpoint.CustomAttributes.FirstOrDefault(x => x.AttributeType.Name == nameof(RetornoAttribute));

                    if (retornoAttr != null)
                    {
                        // Busca o tipo de retorno
                        retorno = (string)retornoAttr.ConstructorArguments[0].Value;

                        // Verifica se é uma lista
                        if ((bool)retornoAttr.ConstructorArguments[1].Value)
                            retorno = $"Array<{retorno}>";

                        resposta = (TipoResposta)retornoAttr.ConstructorArguments[2].Value;
                    }

                    var metodoObj = new ServiceMetodo
                    {
                        Nome = endpoint.Name,
                        Rota = caminhoRota,
                        Tipo = tipoRota,
                        Retorno = retorno,
                        Resposta = resposta.ToDescriptionString(),
                        Parametros = new List<ServiceParametro>()
                    };

                    // Extrair parametros
                    var parametros = endpoint.GetParameters();

                    foreach (var parametro in parametros)
                    {
                        var paramAttrs = parametro.CustomAttributes.FirstOrDefault(x => x.AttributeType.Name == "FromServicesAttribute");
                        if (paramAttrs == null)
                        {
                            ServiceParametro param;

                            if (parametro.ParameterType.Name == "Nullable`1")
                            {
                                var type = parametro.ParameterType.GenericTypeArguments[0].Name;

                                param = new ServiceParametro
                                {
                                    Nome = parametro.Name + "?",
                                    Tipo = MapeiaTipoTS(type),
                                    IsQueryString = metodoObj.Rota.Contains($"{{{parametro.Name}}}")
                                };
                            }
                            else
                            {
                                param = new ServiceParametro
                                {
                                    Nome = parametro.Name,
                                    Tipo = MapeiaTipoTS(parametro.ParameterType.Name),
                                    IsQueryString = metodoObj.Rota.Contains($"{{{parametro.Name}}}")
                                };
                            }

                            metodoObj.Parametros.Add(param);

                            if (param.Tipo.Contains("Entidade") && !serviceObj.Imports.Contains(param.Tipo) && !string.IsNullOrEmpty(param.Tipo.Trim()))
                                serviceObj.Imports.Add(param.Tipo);
                        }
                    }

                    var ret = metodoObj.Retorno.Replace("Array<", "").Replace(">", "");
                    if (!serviceObj.Imports.Contains(ret)
                        && ret != "string"
                        && ret != "boolean"
                        && ret != "number"
                        && ret != "any")
                    {
                        serviceObj.Imports.Add(ret);
                    }

                    serviceObj.Metodos.Add(metodoObj);
                }

                ListaServices.Add(serviceObj);
            }
        }

        private static void CarregarDLL(string caminhoEntidades)
        {
            AsmLoaderProxy = (ProxyDomain)AppDomain.CurrentDomain.CreateInstanceAndUnwrap(Assembly.GetExecutingAssembly().FullName, typeof(ProxyDomain).FullName);
            AsmLoaderProxy.GetAssembly(caminhoEntidades);
        }

        private void GerarClasse()
        {
            var dirServices = Path.Combine(DiretorioGit, Projeto.TXT_DIRETORIO, "src", "services");

            foreach (var service in ListaServices)
            {
                SB = new StringBuilder();

                GerarImports(Projeto, service);
                GerarDeclaracaoClasse(service);
                GerarMetodos(service);
                Fechar(service);
                File.WriteAllText(Path.Combine(dirServices, $"{service.Nome}Service.tsx"), SB.ToString(), Encoding.UTF8);
            }

            // Salva index.tsx
            var listaServices = Directory.GetFiles(dirServices).ToList();
            var servicesIndex = new List<string>();
            foreach (var ent in listaServices)
            {
                var arquivo = new FileInfo(ent);
                if (arquivo.Name != "index.tsx")
                    servicesIndex.Add(arquivo.Name.Replace(".tsx", ""));
            }

            //var servicesTSIndex = new GeradorServiceIndex(servicesIndex).Gerar();
            //File.WriteAllText(Path.Combine(dirServices, $"index.tsx"), servicesTSIndex, Encoding.UTF8);
        }

        private void GerarImports(ProjetoEntidade proj, Service service)
        {
            SB.AppendLine("import { BaseService, RequestType, ResponseType } from \"@intech/react-service\";");

            foreach (var import in service.Imports)
            {
                var imp = import.Replace("Array<", "").Replace(">", "");
                SB.AppendLine($"import {{ {imp} }} from \"../entidades/{imp}\";");
            }

            SB.AppendLine();
        }

        private void GerarDeclaracaoClasse(Service service)
        {
            SB.AppendLine($"class {service.Nome} extends BaseService {{");

            SB.AppendLine("\tconstructor() {");
            SB.AppendLine($"\t\tsuper(\"{service.Nome}\");");
            SB.AppendLine("\t}");
            SB.AppendLine();
        }

        private void GerarMetodos(Service service)
        {
            foreach (var metodo in service.Metodos)
            {
                SB.Append($"\t{metodo.Nome} = (");

                for (var i = 0; i < metodo.Parametros.Count; i++)
                {
                    var param = metodo.Parametros[i];
                    SB.Append($"{param.Nome}: {param.Tipo}");

                    if (i + 1 < metodo.Parametros.Count)
                        SB.Append(", ");
                }

                SB.AppendLine(") =>");

                var rota = metodo.Rota.Replace("[action]", metodo.Nome);

                SB.Append($"\t\tthis.CreateRequest<{metodo.Retorno}>(RequestType.{metodo.Tipo}, `{rota}`");

                var bodyParams = metodo.Parametros.Where(x => !x.IsQueryString).ToList();
                if (bodyParams.Count > 0)
                {
                    SB.Append($", ");

                    if (bodyParams.Count == 1)
                        SB.Append(metodo.Parametros[0].Nome);
                    else
                    {
                        SB.Append("{ ");
                        for (var i = 0; i < bodyParams.Count; i++)
                        {
                            SB.Append(bodyParams[i].Nome);
                            if (i + 1 < bodyParams.Count)
                                SB.Append(", ");
                        }
                        SB.Append("}");
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(metodo.Resposta) && metodo.Resposta != TipoResposta.Normal.ToDescriptionString())
                        SB.Append($", null, ResponseType.{metodo.Resposta}");
                }

                SB.AppendLine(");");
                SB.AppendLine();
            }
        }

        private void Fechar(Service service)
        {
            SB.AppendLine("}");
            SB.AppendLine();
            SB.AppendLine($"export const {service.Nome}Service = new {service.Nome}();");
        }

        protected string MapeiaTipoTS(string type)
        {
            var lista = type.Contains("List<");
            var tipo = type.Replace("List<", "").Replace(">", "");

            var numbers = new string[] { "BIGINT", "FLOAT", "LONG", "MONEY", "NUMERIC", "NUMBER", "SMALLINT", "SMALLMONEY", "DECIMAL", "INT", "INT32", "INT16" };
            var strings = new string[] { "STRING", "TEXT", "CHAR", "VARCHAR", "VARCHAR2", "NVARCHAR", "ANSISTRING", "VARBINARY", "NCHAR" };
            var dates = new string[] { "DATE", "DATETIME" };

            var tipoUpper = tipo.ToUpper();

            if (numbers.Contains(tipoUpper))
                tipo = "number";
            else if (strings.Contains(tipoUpper))
                tipo = "string";
            else if (dates.Contains(tipoUpper))
                tipo = "Date";
            else if (tipoUpper == "BOOL")
                tipo = "boolean";
            else if (tipoUpper == "OBJECT")
                tipo = "any";
            else
            {
                if (tipo.Contains("List<"))
                {
                    tipo = tipo.Replace("List<", "").Replace(">", "");
                    tipo = MapeiaTipoTS(tipo);
                }
            }

            if (lista)
                return $"Array<{tipo}>";
            else
                return tipo;
        }

        private ProjetoEntidade BuscarProjeto(decimal oid)
        {
			var webRequest = WebRequest.Create($"{ApiUrl}/Projeto/{oid}");
			webRequest.Method = WebRequestMethods.Http.Get;
			webRequest.ContentType = "application/json; charset=utf-8";

			var response = (HttpWebResponse)webRequest.GetResponse();

			string resultadoJson = null;

			using (var streamReader = new StreamReader(response.GetResponseStream()))
				resultadoJson = streamReader.ReadToEnd();

			return JsonConvert.DeserializeObject<ProjetoEntidade>(resultadoJson, new JsonSerializerSettings() { DateFormatString = "dd/MM/yyyy hh:mm:ss" });
		}
    }

	public class ProjetoEntidade
	{
		public decimal OID_PROJETO { get; set; }
		public string NOM_PROJETO { get; set; }
		public string IND_TIPO_PROJETO { get; set; }
		public string TXT_DIRETORIO { get; set; }
		public string TXT_NAMESPACE { get; set; }
		public decimal OID_SISTEMA { get; set; }
		public decimal? OID_PROJETO_API { get; set; }
		public decimal? OID_CLIENTE { get; set; }
		public SistemaEntidade Sistema { get; set; }
	}

	public class SistemaEntidade
	{
		public decimal OID_SISTEMA { get; set; }
		public string NOM_SISTEMA { get; set; }
		public string TXT_DIRETORIO_DADOS { get; set; }
		public string TXT_DIRETORIO_NEGOCIO { get; set; }
		public string TXT_DIRETORIO_ENTIDADES { get; set; }
		public string TXT_NAMESPACE_DADOS { get; set; }
		public string TXT_NAMESPACE_NEGOCIO { get; set; }
		public string TXT_NAMESPACE_ENTIDADES { get; set; }
    }

    public class Service
    {
        public string Nome { get; set; }
        public List<ServiceMetodo> Metodos { get; set; }
        public List<string> Imports { get; set; }
    }

    public class ServiceMetodo
    {
        public string Nome { get; set; }
        public string Retorno { get; set; }
        public string Rota { get; set; }
        public string Tipo { get; set; }
        public string Resposta { get; set; }
        public List<ServiceParametro> Parametros { get; set; }
    }
    public class ServiceParametro
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public bool IsQueryString { get; set; }
    }

    class ProxyDomain : MarshalByRefObject
    {
        public void GetAssembly(string AssemblyPath)
        {
            try
            {
                Assembly.LoadFrom(AssemblyPath);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message, ex);
            }
        }
    }
}
