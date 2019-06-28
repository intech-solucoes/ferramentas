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
                TextBoxNomeProjeto.Enabled = false;
                RadioButtonAPI.Enabled = false;
                RadioButtonMobile.Enabled = false;
                RadioButtonWeb.Enabled = false;
            }
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

        private void BuscarProjetoExistente()
        {
            var repositorio = new DirectoryInfo(ParametrosProjeto.Diretorio);

            // Verifica se é um projeto API
            var diretorioAppsettings = Path.Combine(ParametrosProjeto.Diretorio, "appsettings.json");
            if (File.Exists(diretorioAppsettings))
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
        }

        private void SelecionarTipoProjeto()
        {
            RadioButtonAPI.Checked = ParametrosProjeto.TipoProjeto == TipoProjeto.API;
            RadioButtonMobile.Checked = ParametrosProjeto.TipoProjeto == TipoProjeto.Mobile;
            RadioButtonWeb.Checked = ParametrosProjeto.TipoProjeto == TipoProjeto.Web;
        }

        private void ButtonContinuar_Click(object sender, EventArgs e)
        {

        }
    }
}