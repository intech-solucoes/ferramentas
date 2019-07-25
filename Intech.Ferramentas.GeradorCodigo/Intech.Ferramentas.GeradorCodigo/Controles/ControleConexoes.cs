using Intech.Ferramentas.GeradorCodigo.Code;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Intech.Ferramentas.GeradorCodigo.Controles
{
    public partial class ControleConexoes : UserControl
    {
        public ControleConexoes()
        {
            InitializeComponent();
        }

        private void ControleConexoes_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                PreencherConexoes();
                PreencherSistemas();
            }
        }

        private void ListBoxConexoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var conexao = (Conexao)ListBoxConexoes.SelectedItem;

            if (conexao != null)
            {
                ComboBoxSistema.Text = conexao.Sistema;
                ComboBoxProvider.Text = conexao.Provider;
                ComboBoxServidor.Text = conexao.DataSource;
                TextBoxUsuario.Text = conexao.Username;
                TextBoxSenha.Text = conexao.Password;
                TextBoxBanco.Text = conexao.Database;
            }
        }

        private void ButtonNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void PreencherConexoes()
        {
            ListBoxConexoes.DataSource = new Conexoes().Lista.OrderBy(x => x.Database).ToList();
        }

        private void PreencherSistemas()
        {
            ComboBoxSistema.Items.Clear();

            foreach (var cliente in ConfigManager.Config.Sistema)
                ComboBoxSistema.Items.Add(cliente.Nome);

            ComboBoxSistema.SelectedIndex = 0;
        }

        private void Limpar()
        {
            ComboBoxSistema.Text = "";
            ComboBoxServidor.Text = "";
            TextBoxUsuario.Text = "";
            TextBoxSenha.Text = "";
            TextBoxBanco.Text = "";
            ListBoxConexoes.SelectedItem = null;
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                new Conexoes().Salvar(new Conexao
                {
                    ID = ListBoxConexoes.SelectedItem != null ? ((Conexao)ListBoxConexoes.SelectedItem).ID : Guid.NewGuid(),
                    Provider = ComboBoxProvider.Text,
                    DataSource = ComboBoxServidor.Text,
                    Username = TextBoxUsuario.Text,
                    Password = TextBoxSenha.Text,
                    Database = TextBoxBanco.Text,
                    Sistema = ComboBoxSistema.Text
                });

                MessageBox.Show("Conexão salva com sucesso!");
                PreencherConexoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                new Conexoes().Deletar((Conexao)ListBoxConexoes.SelectedItem);

                MessageBox.Show("Conexão deletada com sucesso!");
                PreencherConexoes();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}