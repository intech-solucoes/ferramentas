#region Usings
using Intech.Ferramentas.Code;
using System;
using System.Drawing;
using System.Windows.Forms;
#endregion

namespace Intech.Ferramentas.Controles.Home
{
    public partial class Home : PageControl
    {
        public Home()
        {
            InitializeComponent();
            Titulo = "Home";
        }

        private void Home_Load(object sender, EventArgs e)
        {
            var userConfig = UserConfigManager.Get();

            if (userConfig != null)
            {
                TextBoxDiretorioGIT.Text = userConfig.GitBase;
                ComboBoxUrlApi.SelectedItem = userConfig.UrlApi;
            }

            ButtonProcurarDiretorio.Image = FontAwesome.Instance
                    .GetImage(new FontAwesome.Properties(FontAwesome.Type.FolderOpenO)
                    {
                        Size = 18,
                        ForeColor = Color.Black
                    });
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TextBoxDiretorioGIT.Text))
                    throw new Exception("É necessário informar o diretório do repositório!");

                new UserConfigManager().Salvar(new UserConfig
                {
                    GitBase = TextBoxDiretorioGIT.Text,
                    UrlApi = (string)ComboBoxUrlApi.SelectedItem
                });

                MessageBox.Show("Configuração salva com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonProcurarDiretorio_Click(object sender, EventArgs e)
        {
            using (var fldrDlg = new FolderBrowserDialog())
            {
                if (fldrDlg.ShowDialog() == DialogResult.OK)
                    TextBoxDiretorioGIT.Text = fldrDlg.SelectedPath;
            }
        }
    }
}