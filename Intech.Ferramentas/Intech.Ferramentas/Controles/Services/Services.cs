#region Usings
using Intech.Ferramentas.Dados.Entidades;
using Intech.Ferramentas.Code;
using Intech.Ferramentas.Code.Services;
using Intech.Ferramentas.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using Intech.Lib.Web.API;
#endregion

namespace Intech.Ferramentas.Controles.Services
{
    public partial class Services : PageControl
    {
        public Services()
        {
            InitializeComponent();
            Titulo = "Services";
        }

        private void Services_Load(object sender, EventArgs e)
        {
            CarregarProjetos();
            CarregarDependentes();
        }

        private void CarregarDependentes()
        {
            var projeto = (ProjetoEntidade)ComboBoxProjeto.SelectedItem;
            CheckedListBoxDependentes.DataSource = ProjetoService
                .Listar()
                .Where(x => x.OID_PROJETO_API == projeto.OID_PROJETO)
                .ToList();
            CheckedListBoxDependentes.DisplayMember = "NOM_PROJETO";
        }

        private void CarregarProjetos()
        {
            ComboBoxProjeto.DataSource = ProjetoService
                            .Listar()
                            .Where(x => x.IND_TIPO_PROJETO == "API")
                            .ToList();
        }

        private void CheckBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CheckedListBoxDependentes.Items.Count; i++)
            {
                CheckedListBoxDependentes.SetItemChecked(i, CheckBoxTodos.Checked);
            }
        }

        private void ButtonGerar_Click(object sender, EventArgs e)
        {
            var projetoSelecionado = (ProjetoEntidade)ComboBoxProjeto.SelectedItem;
            var userConfig = UserConfigManager.Get();
            var caminho = $"{userConfig.GitBase}{projetoSelecionado.TXT_DIRETORIO}\\bin\\Debug\\netcoreapp2.2\\{projetoSelecionado.TXT_NAMESPACE}.dll";
            var assembly = Assembly.LoadFile(caminho);

            var controllers = assembly
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
                    var retorno = "";

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
                        var param = new ServiceParametro
                        {
                            Nome = parametro.Name,
                            Tipo = parametro.ParameterType.Name,
                            IsURL = metodoObj.Rota.Contains($"{{{parametro.Name}}}")
                        };

                        if (!serviceObj.Imports.Contains(param.Tipo) && ValidarTiposPrimarios(param.Tipo))
                            serviceObj.Imports.Add(param.Tipo);
                    }
                }
            }



        }

        private bool ValidarTiposPrimarios(string tipo)
        {
            return 
        }

        private void ComboBoxProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDependentes();
        }
    }
}