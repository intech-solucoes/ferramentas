using Intech.Ferramentas.GeradorCodigo.Code;
using System;
using System.IO;
using System.Windows.Forms;

namespace Intech.Ferramentas.GeradorCodigo.Controles.NovoProjeto
{
    public partial class ControlPasso2 : UserControl
    {
        public FormNovoProjeto FormControlador { get; }

        public ControlPasso2(FormNovoProjeto formControlador)
        {
            InitializeComponent();

            FormControlador = formControlador;

            ParametrosProjeto.TipoProjeto = null;
            ParametrosProjeto.NomeProjeto = null;

            if (ParametrosProjeto.TipoOperacao == TipoOperacao.ProjetoExistente)
            {
                RadioButtonAPI.Enabled = false;
                RadioButtonMobile.Enabled = false;
                RadioButtonWeb.Enabled = false;
                ButtonContinuar.Text = "Salvar";
            }

            BuscarSistemas();
        }

        private void ButtonProcurar_Click(object sender, EventArgs e)
        {
            using (var fldrDlg = new FolderBrowserDialog())
            {
                fldrDlg.SelectedPath = "C:\\git";
                if (fldrDlg.ShowDialog() == DialogResult.OK)
                {
                    TextBoxDiretorio.Text = fldrDlg.SelectedPath;
                    ParametrosProjeto.Diretorio = fldrDlg.SelectedPath;

                    if (ParametrosProjeto.TipoOperacao == TipoOperacao.ProjetoExistente)
                        BuscarProjetoExistente();
                }
            }
        }

        private void BuscarSistemas()
        {
            ComboBoxSistemas.Items.Clear();

            foreach (var cliente in ConfigManager.Config.Sistema)
                ComboBoxSistemas.Items.Add(cliente.Nome);

            ComboBoxSistemas.SelectedIndex = 0;
        }

        private void BuscarProjetoExistente()
        {
            var repositorio = new DirectoryInfo(ParametrosProjeto.Diretorio);

            // Verifica se é um projeto API
            //var diretorioAppsettings = Path.Combine(ParametrosProjeto.Diretorio, "API.xml");
            var csproj = Directory.GetFiles(ParametrosProjeto.Diretorio, "*.csproj");
            if (csproj.Length > 0)
            {
                ParametrosProjeto.TipoProjeto = TipoProjeto.API;
                ParametrosProjeto.NomeProjeto = repositorio.Parent.Name;
            }

            // Verifica se é um projeto Web
            var diretorioPackage = Path.Combine(ParametrosProjeto.Diretorio, "package.json");
            if (File.Exists(diretorioPackage))
            {
                ParametrosProjeto.TipoProjeto = TipoProjeto.Web;
                ParametrosProjeto.NomeProjeto = repositorio.Name;
            }

            // Verifica se é um projeto Mobile
            var diretorioAppJson = Path.Combine(ParametrosProjeto.Diretorio, "app.json");
            if(File.Exists(diretorioAppJson))
            {
                ParametrosProjeto.TipoProjeto = TipoProjeto.Mobile;
                ParametrosProjeto.NomeProjeto = repositorio.Name;
            }

            if (ParametrosProjeto.TipoProjeto == null)
            {
                MessageBox.Show("Nenhum projeto compatível foi encontrado!");
                return;
            }

            SelecionarTipoProjeto();
            TextBoxNomeProjeto.Text = ParametrosProjeto.NomeProjeto;

            if(ParametrosProjeto.TipoProjeto != TipoProjeto.API)
            {
                TextBoxNamespace.Enabled = false;
                TextBoxNamespace.Text = null;
            }
        }

        private void SelecionarTipoProjeto()
        {
            RadioButtonAPI.Checked = ParametrosProjeto.TipoProjeto == TipoProjeto.API;
            RadioButtonMobile.Checked = ParametrosProjeto.TipoProjeto == TipoProjeto.Mobile;
            RadioButtonWeb.Checked = ParametrosProjeto.TipoProjeto == TipoProjeto.Web;
        }

        private void ButtonContinuar_Click(object sender, EventArgs e)
        {
            new Projetos().Salvar(new Projeto
            {
                ID = Guid.NewGuid(),
                Diretorio = TextBoxDiretorio.Text,
                Nome = TextBoxNomeProjeto.Text,
                Tipo = ParametrosProjeto.TipoProjeto.Value,
                Sistema = ComboBoxSistemas.Text,
                Namespace = TextBoxNamespace.Text
            });

            MessageBox.Show("Projeto salvo com sucesso!");
            FormControlador.Fechar();
        }
    }
}