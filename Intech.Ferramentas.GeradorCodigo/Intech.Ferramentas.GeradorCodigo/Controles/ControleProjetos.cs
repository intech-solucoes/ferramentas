using Intech.Ferramentas.GeradorCodigo.Code;
using Intech.Ferramentas.GeradorCodigo.Code.Postman;
using Intech.Ferramentas.GeradorCodigo.Code.Service;
using Intech.Ferramentas.GeradorCodigo.Controles.NovoProjeto;
using Newtonsoft.Json;
using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Intech.Ferramentas.GeradorCodigo.Controles
{
    public partial class ControleProjetos : UserControl
    {
        private Projeto ProjetoSelecionado => (Projeto)ListBoxProjetos.SelectedItem;

        public ControleProjetos()
        {
            InitializeComponent();
        }

        private void ControleProjetos_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                PreencherSistemas();
                CarregarListaProjetos();
            }
        }

        private void ListBoxProjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ProjetoSelecionado != null)
            {
                TextBoxDiretorio.Text = ProjetoSelecionado.Diretorio;
                TextBoxRepositorio.Text = ProjetoSelecionado.Nome;
                
                switch(ProjetoSelecionado.Tipo)
                {
                    case TipoProjeto.API:
                        ComboBoxTipo.SelectedItem = "API";
                        break;
                    case TipoProjeto.Mobile:
                        ComboBoxTipo.SelectedItem = "Mobile";
                        break;
                    case TipoProjeto.Web:
                        ComboBoxTipo.SelectedItem = "Web";
                        break;
                }

                ButtonProjetosDependentes.Enabled = ProjetoSelecionado.Tipo == TipoProjeto.API;
                ButtonGerarService.Enabled = ProjetoSelecionado.Tipo == TipoProjeto.API;
                ButtonSelecionarServices.Enabled = ProjetoSelecionado.Tipo != TipoProjeto.API;
                ComboBoxSistema.Text = ProjetoSelecionado.Sistema;
                TextBoxNamespace.Text = ProjetoSelecionado.Namespace;
            }
        }

        private void ButtonVSCode_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void ButtonVS_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNovo_Click(object sender, EventArgs e)
        {
            if(new FormNovoProjeto().ShowDialog() == DialogResult.OK)
            {
                CarregarListaProjetos();
            }
        }

        private void PreencherSistemas()
        {
            ComboBoxSistema.Items.Clear();

            foreach (var sistema in ConfigManager.Config.Sistema)
                ComboBoxSistema.Items.Add(sistema.Nome);

            ComboBoxSistema.SelectedIndex = 0;
        }

        private void PreencherAPIs()
        {
            ComboBoxAPI.Items.Clear();

            foreach (var api in new Projetos().Lista.Where(x => x.Tipo == TipoProjeto.API).OrderBy(x => x.Nome).ToList())
                ComboBoxAPI.Items.Add(api.Nome);

            ComboBoxAPI.SelectedIndex = 0;
        }

        private void CarregarListaProjetos()
        {
            ListBoxProjetos.DataSource = new Projetos().Lista.OrderBy(x => x.Nome).ToList();
            ListBoxProjetos.DisplayMember = "Nome";
        }

        private void Run()
        {
            if (ListBoxProjetos.SelectedItem != null)
            {
                var projeto = (Projeto)ListBoxProjetos.SelectedItem;
                Process.Start($"code", projeto.Diretorio);
            }
        }

        private void ButtonProjetosDependentes_Click(object sender, EventArgs e)
        {
            new FormProjetosDependentes(this).ShowDialog();
        }

        private void ButtonSelecionarServices_Click(object sender, EventArgs e)
        {
            new FormSelecionarServices(this).ShowDialog();
        }

        private async void ButtonGerarService_Click(object sender, EventArgs e)
        {
            try
            {
                string arquivoProjeto = Path.Combine(ProjetoSelecionado.Diretorio, ProjetoSelecionado.Namespace + ".csproj");
                var projeto = (Projeto)ListBoxProjetos.SelectedItem;

                var temErros = false;

                if (CheckBoxBuild.Checked)
                {
                    // Faz build do projeto para gerar documentação XML atualizada
                    temErros = BuildProjeto(arquivoProjeto);
                }

                if (!temErros)
                {
                    // Busca XML de documentação do projeto
                    var xml = ParseXML();

                    // Busca todos os <member> da documentação que não sejam um método (que sejam uma controller)
                    var services = xml.members.Where(x => !x.IsMetodo).ToList();

                    var listaServices = new List<Service>();

                    // Integração com Postman
                    //var postmanService = new PostmanService();
                    //var postmanCollection = await postmanService.BuscarCollectionPorNome(projeto.Nome);
                    //if(postmanCollection == null)
                    //{
                    //    postmanCollection = new PostmanCollection
                    //    {
                    //        collection = new PostmanCollectionObj
                    //        {
                    //            info = new PostmanCollectionInfo
                    //            {
                    //                name = xml.assembly.name,
                    //                description = $"API do projeto {xml.assembly.name}",
                    //                schema = "https://schema.getpostman.com/json/collection/v2.1.0/collection.json"
                    //            },
                    //            item = new List<PostmanCollectionItem>()
                    //        }
                    //    };
                    //}

                    foreach (var service in services)
                    {
                        // Cria novo service
                        var serviceObj = new Service
                        {
                            Nome = service.NomeMetodo.Replace("Controller", ""),
                            Metodos = new List<Metodo>(),
                            Imports = new List<string>()
                        };

                        // Cria nova pasta no Postman
                        var novaPasta = new PostmanCollectionItem
                        {
                            name = serviceObj.Nome,
                            item = new List<PostmanCollectionItem>()
                        };

                        var metodos = xml.members.Where(x =>
                            x.name.Substring(2).Contains(service.name.Substring(2)) &&
                            x.IsMetodo
                        ).ToList();

                        foreach (var metodo in metodos)
                        {
                            var caminhoRota = metodo.rota.caminho;

                            caminhoRota 
                                = caminhoRota != null
                                ? caminhoRota.Replace("[action]", metodo.NomeMetodo).Replace("{", "${")
                                : "";

                            var metodoObj = new Metodo
                            {
                                Nome = metodo.NomeMetodo,
                                Rota = caminhoRota,
                                Tipo = metodo.rota.tipo,
                                Retorno = metodo.retorno.lista ? $"Array<{metodo.retorno.tipo}>" : metodo.retorno.tipo,
                                Parametros = new List<Parametro>()
                            };


                            if (metodo.retorno.resposta == "blob")
                                metodoObj.Resposta = "Blob";
                            else if (metodo.retorno.resposta == "zip")
                                metodoObj.Resposta = "Zip";
                            else
                                metodoObj.Resposta = "";

                            foreach (var param in metodo.parametros)
                            {
                                var isURL = false;
                                if (metodoObj.Rota.Contains(param.nome))
                                    isURL = true;

                                metodoObj.Parametros.Add(new Parametro
                                {
                                    Nome = param.nome,
                                    Tipo = param.tipo,
                                    IsURL = isURL
                                });

                                if (param.tipo.Contains("Entidade") && !serviceObj.Imports.Contains(param.tipo))
                                    serviceObj.Imports.Add(param.tipo);
                            }

                            if (!serviceObj.Imports.Contains(metodo.retorno.tipo)
                                && metodo.retorno.tipo != "string"
                                && metodo.retorno.tipo != "boolean"
                                && metodo.retorno.tipo != "number"
                                && metodo.retorno.tipo != "any")
                            {
                                serviceObj.Imports.Add(metodo.retorno.tipo);
                            }

                            // Cria novo endpoint no Postman
                            //var novoEndpoint = new PostmanCollectionItem
                            //{
                            //    name = $"/{metodoObj.Rota.Replace("$", "")}",
                            //    request = new PostmanRequest
                            //    {
                            //        url = new PostmanUrl {
                            //            raw = "{{host}}/" + serviceObj.Nome + "/" + metodoObj.Rota.Replace("$", ""),
                            //            host = new List<string> { "{{host}}" },
                            //            path = new List<string> { $"{serviceObj.Nome}/{metodoObj.Rota.Replace("$", "")}" }
                            //        },
                            //        method = metodoObj.Tipo,
                            //        description = ""
                            //    }
                            //};

                            //if (metodoObj.Rota == "/")
                            //{
                            //    novoEndpoint.name = "/";
                            //    novoEndpoint.request.url.raw = "{{host}}/" + serviceObj.Nome;
                            //    novoEndpoint.request.url.path = new List<string> { $"{serviceObj.Nome}" };
                            //}

                            //if (metodoObj.Tipo == "POST")
                            //{
                            //    novoEndpoint.request.header = new List<PostmanHeader>
                            //    {
                            //        new PostmanHeader("Content-Type", "application/json")
                            //    };

                            //    novoEndpoint.request.body = new PostmanBody();
                            //}

                            //novaPasta.item.Add(novoEndpoint);
                            serviceObj.Metodos.Add(metodoObj);
                        }

                        //postmanCollection.collection.item.Add(novaPasta);
                        
                        listaServices.Add(serviceObj);
                    }

                    //await postmanService.CriarOuAtualizarCollection(postmanCollection);

                    var serviceTemplateFile = File.ReadAllText("Templates/Service.template");

                    foreach (var projDependente in projeto.Dependentes)
                    {
                        var listaServicesProjetoDependente = listaServices;
                        var dependente = new Projetos().BuscarPorID(projDependente);

                        if (!Directory.Exists(Path.Combine(dependente.Diretorio, "src", "services")))
                            Directory.CreateDirectory(Path.Combine(dependente.Diretorio, "src", "services"));

                        // Filtra os services a serem gerados
                        if (dependente.Services != null)
                        {
                            var listaControllers = dependente.Services.Select(x => x.Replace("Controller", "")).ToList();
                            listaServicesProjetoDependente = listaServices.Where(x => listaControllers.Contains(x.Nome)).ToList();
                        }

                        foreach (var service in listaServicesProjetoDependente)
                        {
                            var serviceTemplate = RazorEngine.Engine.Razor.RunCompile(serviceTemplateFile, "templateService", null, service);
                            File.WriteAllText(Path.Combine(dependente.Diretorio, "src", "services", $"{service.Nome}Service.tsx"), serviceTemplate, Encoding.UTF8);
                        }

                        var serviceIndexTemplateFile = File.ReadAllText("Templates/ServiceIndex.template");
                        var serviceIndexTemplate = RazorEngine.Engine.Razor.RunCompile(serviceIndexTemplateFile, "templateServiceIndex", null, listaServicesProjetoDependente);
                        File.WriteAllText(Path.Combine(dependente.Diretorio, "src", "services", $"index.tsx"), serviceIndexTemplate, Encoding.UTF8);
                    }

                    MessageBox.Show("Services criados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Métodos Auxiliares

        private bool BuildProjeto(string arquivoProjeto)
        {
            var temErros = false;

            var dotnetBuild = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = $"build {arquivoProjeto}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            dotnetBuild.Start();
            while (!dotnetBuild.StandardOutput.EndOfStream)
            {
                string line = dotnetBuild.StandardOutput.ReadLine().Trim();

                if (line.Contains("Erro(s)"))
                {
                    var numeroErros = Convert.ToInt32(line.Split(' ')[0]);
                    if (numeroErros > 0)
                    {
                        temErros = true;
                        MessageBox.Show($"Falha ao executar build do projeto! {numeroErros} erros encontrados!");
                    }
                }
            }

            return temErros;
        }

        private APIXML ParseXML()
        {
            var diretorioXml = Path.Combine(ProjetoSelecionado.Diretorio, "API.xml");
            var xml = File.ReadAllText(diretorioXml);

            StringReader strReader = null;
            XmlSerializer serializer = null;
            XmlTextReader xmlReader = null;
            APIXML obj = null;
            try
            {
                strReader = new StringReader(xml);
                serializer = new XmlSerializer(typeof(APIXML));
                xmlReader = new XmlTextReader(strReader);
                obj = (APIXML)serializer.Deserialize(xmlReader);

                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao validar o XML da API. {ex.Message}.");
            }
            finally
            {
                if (xmlReader != null)
                    xmlReader.Close();

                if (strReader != null)
                    strReader.Close();
            }
        }

        #endregion
    }
}