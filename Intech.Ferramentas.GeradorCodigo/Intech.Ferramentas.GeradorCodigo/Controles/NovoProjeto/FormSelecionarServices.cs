#region Usings
using Intech.Ferramentas.GeradorCodigo.Code;
using Intech.Ferramentas.GeradorCodigo.Code.Service;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization; 
#endregion

namespace Intech.Ferramentas.GeradorCodigo.Controles.NovoProjeto
{
    public partial class FormSelecionarServices : Form
    {
        public ControleProjetos ControleProjetos { get; }

        private Projeto Projeto => (Projeto)ControleProjetos.ListBoxProjetos.SelectedItem;

        public FormSelecionarServices(ControleProjetos controleProjetos)
        {
            InitializeComponent();

            ControleProjetos = controleProjetos;
        }

        private void FormSelecionarServices_Load(object sender, EventArgs e)
        {
            BuscarServices();
        }

        private void BuscarServices()
        {
            // Busca XML de documentação do projeto
            var xml = ParseXML();

            if (xml != null)
            {
                // Busca todos os <member> da documentação que não sejam um método (que sejam uma controller)
                var services = xml.members.Where(x => !x.IsMetodo).ToList();

                CheckedListBoxServices.DataSource = services;
                CheckedListBoxServices.DisplayMember = "NomeMetodo";

                if (Projeto.Services != null)
                {
                    for (int i = 0; i < services.Count; i++)
                    {
                        CheckedListBoxServices.SetItemChecked(i, Projeto.Services.Any(x => x == services[i].NomeMetodo));
                    }
                }
            }
            else
            {
                Close();
            }
        }

        private void ButtonAtualizar_Click(object sender, EventArgs e)
        {
            string arquivoProjeto = Path.Combine(Projeto.Diretorio, Projeto.Namespace + ".csproj");

            // Faz build do projeto para gerar documentação XML atualizada
            var temErros = BuildProjeto(arquivoProjeto);

            if (!temErros)
                BuscarServices();
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            Projeto.Services = CheckedListBoxServices.CheckedItems.Cast<member>().Select(x => x.NomeMetodo).ToList();
            new Projetos().Salvar(Projeto);
            Close();
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
            var projetoAPI = new Projetos().BuscarPorID(Projeto.API);

            if (projetoAPI == null)
            {
                MessageBox.Show("Nenhum projeto de API foi selecionado para este projeto.");
                return null;
            }

            var diretorioXml = Path.Combine(projetoAPI.Diretorio, "API.xml");
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