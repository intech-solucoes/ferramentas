using Intech.Ferramentas.Code.Services;
using Intech.Ferramentas.Dados.Dominios;
using Intech.Ferramentas.Dados.Entidades;
using Intech.Lib.Web.API;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intech.Ferramentas.Code.Gerador.Classes
{
    public class GeradorService
    {
        public StringBuilder SB { get; private set; }

        private UserConfig Config => UserConfigManager.Get();
        private ProjetoEntidade Projeto;
        private List<ProjetoEntidade> ProjetosSelecionados;

        private List<Service> ListaServices = new List<Service>();

        public GeradorService(ProjetoEntidade projeto, List<ProjetoEntidade> projetosSelecionados)
        {
            Projeto = projeto;
            ProjetosSelecionados = projetosSelecionados;
        }

        public void GerarServices()
        {
            try
            {
                ExtrairDados();
                GerarClasse();

                MessageBox.Show("Services gerados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void ExtrairDados()
        {
            var caminho = $"{Config.GitBase}{Projeto.TXT_DIRETORIO}\\bin\\Debug\\netcoreapp2.2\\{Projeto.TXT_NAMESPACE}.dll";
            var assembly = Assembly.LoadFile(caminho);

            var caminhoEntidades = @"C:\git\brprev-seg\API\Intech.BrPrev.SEG.Entidades\bin\Debug\netcoreapp2.2\Intech.BrPrev.SEG.Entidades.dll";
            CarregarDLL(caminhoEntidades);

            var controllers = AppDomain.CurrentDomain.GetAssemblies()
                .Single(x => x.GetName().Name == assembly.GetName().Name)
                .GetTypes()
                .Where(x
                    => x.BaseType.Name == "BaseController"
                    && !x.Name.Contains("Base")
                )
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
                        throw new Exception($"Nenhum atributo HttpGet ou HttpPost encontrado no método {endpoint.Name}");

                    var caminhoRota = httpMethodAttribute.ConstructorArguments.Count > 0 ? (string)httpMethodAttribute.ConstructorArguments[0].Value : "";
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
                            var param = new ServiceParametro
                            {
                                Nome = parametro.Name,
                                Tipo = MapeiaTipoTS(parametro.ParameterType.Name),
                                IsQueryString = metodoObj.Rota.Contains($"{{{parametro.Name}}}")
                            };

                            metodoObj.Parametros.Add(param);

                            if (param.Tipo.Contains("Entidade") && !serviceObj.Imports.Contains(param.Tipo) && !string.IsNullOrEmpty(param.Tipo.Trim()))
                                serviceObj.Imports.Add(param.Tipo);
                        }
                    }

                    var ret = metodoObj.Retorno.Replace("Array<", "").Replace(">", "");
                    if (!serviceObj.Imports.Contains(ret)
                        && metodoObj.Retorno != "string"
                        && metodoObj.Retorno != "boolean"
                        && metodoObj.Retorno != "number"
                        && metodoObj.Retorno != "any")
                    {
                        serviceObj.Imports.Add(ret);
                    }

                    serviceObj.Metodos.Add(metodoObj);
                }

                ListaServices.Add(serviceObj);
            }
        }

        protected string MapeiaTipoTS(string type)
        {
            var lista = type.Contains("List<");
            var tipo = type.Replace("List<", "").Replace(">", "");
            string tipoTraduzido = "";

            var numbers = new string[] { "BIGINT", "FLOAT", "LONG", "MONEY", "NUMERIC", "NUMBER", "SMALLINT", "SMALLMONEY", "DECIMAL", "INT", "INT32", "INT16" };
            var strings = new string[] { "STRING", "TEXT", "CHAR", "VARCHAR", "VARCHAR2", "NVARCHAR", "ANSISTRING", "VARBINARY", "NCHAR" };
            var dates = new string[] { "DATE", "DATETIME" };

            var tipoUpper = tipo.ToUpper();

            if (numbers.Contains(tipoUpper))
                tipoTraduzido = "number";
            else if (strings.Contains(tipoUpper))
                tipoTraduzido = "string";
            else if (dates.Contains(tipoUpper))
                tipoTraduzido = "Date";
            else if (tipoUpper == "BOOL")
                tipoTraduzido = "boolean";
            else if (tipoUpper == "OBJECT")
                tipoTraduzido = "any";
            else
            {
                if (tipo.Contains("List<"))
                {
                    tipo = tipo.Replace("List<", "").Replace(">", "");
                    tipoTraduzido = MapeiaTipoTS(tipo);
                }
            }

            if (lista)
                return $"Array<{tipoTraduzido}>";
            else
                return tipoTraduzido;
        }

        private static void CarregarDLL(string caminhoEntidades)
        {
            var asmLoaderProxy = (ProxyDomain)AppDomain.CurrentDomain.CreateInstanceAndUnwrap(Assembly.GetExecutingAssembly().FullName, typeof(ProxyDomain).FullName);
            asmLoaderProxy.GetAssembly(caminhoEntidades);
        }

        private void GerarClasse()
        {
            foreach (var service in ListaServices)
            {
                SB = new StringBuilder();

                    GerarImports(proj, service);
                    GerarDeclaracaoClasse(service);
                    GerarMetodos(service);
                    Fechar(service);
                    File.WriteAllText(Path.Combine(dirServices, $"{service.Nome}Service.tsx"), SB.ToString(), Encoding.UTF8);
                }

                foreach (var proj in ProjetosSelecionados)
                {
                    File.WriteAllText(Path.Combine(Config.GitBase, proj.TXT_DIRETORIO, "src", "services", $"{service.Nome}Service.tsx"), SB.ToString(), Encoding.UTF8);
                }
            }
        }

        private void GerarImports(ProjetoEntidade proj, Service service)
        {
            var serviceLib = "react-service";
            if (proj.IND_TIPO_PROJETO == DMN_TIPO_PROJETO.MOBILE)
                serviceLib = "rn-service";

            SB.AppendLine($"import {{ BaseService, RequestType, ResponseType }} from \"@intech/{serviceLib }\";");

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
                    if (!string.IsNullOrEmpty(metodo.Resposta))
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
