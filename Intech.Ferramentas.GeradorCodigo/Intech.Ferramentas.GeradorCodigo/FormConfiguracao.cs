using Intech.Ferramentas.GeradorCodigo.Code;
using System;
using System.Windows.Forms;

namespace Intech.Ferramentas.GeradorCodigo
{
    public partial class FormConfiguracao : Form
    {
        public FormConfiguracao()
        {
            InitializeComponent();
        }

        private void FormConfiguracao_Load(object sender, System.EventArgs e)
        {
            var userConfig = UserConfigManager.Get();

            if (userConfig != null)
            {
                TextBoxDiretorioGIT.Text = userConfig.GitBase;
            }
        }

        private void ButtonSalvar_Click(object sender, System.EventArgs e)
        {
            try
            {
                new UserConfigManager().Salvar(new UserConfig
                {
                    GitBase = TextBoxDiretorioGIT.Text
                });

                MessageBox.Show("Conexão salva com sucesso!");
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
    }
}