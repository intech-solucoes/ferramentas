using Intech.Ferramentas.GeradorCodigo.Code;
using Intech.Ferramentas.GeradorCodigo.Code.Service;
using Intech.Ferramentas.GeradorCodigo.Controles.NovoProjeto;
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

            foreach (var cliente in ConfigManager.Config.Sistema)
                ComboBoxSistema.Items.Add(cliente.Nome);

            ComboBoxSistema.SelectedIndex = 0;
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

        private void ButtonGerarService_Click(object sender, EventArgs e)
        {
            try
            {
                var temErros = false;

                string arquivoProjeto = Path.Combine(ProjetoSelecionado.Diretorio, ProjetoSelecionado.Namespace + ".csproj");
                var projeto = (Projeto)ListBoxProjetos.SelectedItem;

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

                if (!temErros)
                {
                    var xml = ParseXML();

                    var services = xml.members.Where(x => !x.IsMetodo).ToList();

                    var listaServices = new List<Service>();

                    foreach(var service in services)
                    {
                        var serviceObj = new Service
                        {
                            Nome = service.NomeMetodo.Replace("Controller", ""),
                            Metodos = new List<Metodo>(),
                            Imports = new List<string>()
                        };

                        var metodos = xml.members.Where(x => 
                            x.name.Substring(2).Contains(service.name.Substring(2)) && 
                            x.IsMetodo
                        ).ToList();

                        foreach(var metodo in metodos)
                        {
                            var metodoObj = new Metodo
                            {
                                Nome = metodo.NomeMetodo,
                                Rota = metodo.rota.caminho,
                                Tipo = metodo.rota.tipo,
                                Retorno = metodo.retorno.lista ? $"Array<{metodo.retorno.tipo}>" : metodo.retorno.tipo,
                                Parametros = new List<Parametro>()
                            };

                            foreach(var param in metodo.parametros)
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

                            serviceObj.Metodos.Add(metodoObj);
                        }

                        listaServices.Add(serviceObj);
                    }

                    var serviceTemplateFile = File.ReadAllText("Templates/Service.template");

                    foreach (var dependente in projeto.Dependentes)
                    {
                        foreach (var service in listaServices)
                        {
                            var serviceTemplate = RazorEngine.Engine.Razor.RunCompile(serviceTemplateFile, "templateService", null, service);
                            File.WriteAllText(Path.Combine(dependente.Diretorio, "src", "services", $"{service.Nome}Service.tsx"), serviceTemplate, Encoding.UTF8);
                        }

                        var serviceIndexTemplateFile = File.ReadAllText("Templates/ServiceIndex.template");
                        var serviceIndexTemplate = RazorEngine.Engine.Razor.RunCompile(serviceIndexTemplateFile, "templateServiceIndex", null, listaServices);
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
    }
}