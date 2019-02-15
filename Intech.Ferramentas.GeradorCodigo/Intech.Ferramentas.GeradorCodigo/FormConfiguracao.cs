using Intech.Ferramentas.GeradorCodigo.Code;
using System;
using System.IO;
using System.Windows.Forms;

namespace Intech.Ferramentas.GeradorCodigo
{
    public partial class FormConfiguracao : Form
    {
        public FormConfiguracao()
        {
            InitializeComponent();
        }

        private void FormConfiguracao_Load(object sender, EventArgs e)
        {
            var userConfig = UserConfigManager.Get();

            if (userConfig != null)
            {
                TextBoxDiretorioGIT.Text = userConfig.GitBase;
            }
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TextBoxDiretorioGIT.Text))
                    throw new Exception("É necessário informar o diretório do repositório!");

                new UserConfigManager().Salvar(new UserConfig
                {
                    GitBase = TextBoxDiretorioGIT.Text
                });

                MessageBox.Show("Configuração salva com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConfiguracao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UserConfigManager.Get() == null)
            {
                MessageBox.Show("É necessário informar o diretório do repositório!");
                e.Cancel = true;
            }
        }

        private void ButtonProcurar_Click(object sender, EventArgs e)
        {
            using (var fldrDlg = new FolderBrowserDialog())
            {
                if (fldrDlg.ShowDialog() == DialogResult.OK)
                    TextBoxDiretorioGIT.Text = fldrDlg.SelectedPath;
            }
        }
    }
}