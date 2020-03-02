using Intech.Ferramentas.Dados.Entidades;
using Intech.Ferramentas.Services;
using System;
using System.Windows.Forms;

namespace Intech.Ferramentas.Controles.Sistemas
{
    public partial class Sistemas : PageControl
    {
        public bool ModoEdicao = false;

        public Sistemas()
        {
            InitializeComponent();
            Titulo = "Sistemas";
        }

        private void Sistemas_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                CarregarSistemas();
                ListSistemas.SelectedIndex = -1;
                LimparFormulario();
            }
        }

        private void ListSistemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sistemaSelecionado = (SistemaEntidade)ListSistemas.SelectedItem;

            if (sistemaSelecionado != null)
            {
                TextBoxNome.Text = sistemaSelecionado.NOM_SISTEMA;
                TextBoxDiretorioDados.Text = sistemaSelecionado.TXT_DIRETORIO_DADOS;
                TextBoxDiretorioNegocio.Text = sistemaSelecionado.TXT_DIRETORIO_NEGOCIO;
                TextBoxDiretorioEntidades.Text = sistemaSelecionado.TXT_DIRETORIO_ENTIDADES;
                TextBoxNamespaceDados.Text = sistemaSelecionado.TXT_NAMESPACE_DADOS;
                TextBoxNamespaceNegocio.Text = sistemaSelecionado.TXT_NAMESPACE_NEGOCIO;
                TextBoxNamespaceEntidades.Text = sistemaSelecionado.TXT_NAMESPACE_ENTIDADES;

                ModoEdicao = true;
            }
        }

        private void ButtonNovoSistema_Click(object sender, EventArgs e)
        {
            LimparFormulario();
            ModoEdicao = false;
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            if (ModoEdicao)
            {
                var sistema = (SistemaEntidade)ListSistemas.SelectedItem;
                sistema.NOM_SISTEMA = TextBoxNome.Text;
                sistema.TXT_DIRETORIO_DADOS = TextBoxDiretorioDados.Text;
                sistema.TXT_DIRETORIO_NEGOCIO = TextBoxDiretorioNegocio.Text;
                sistema.TXT_DIRETORIO_ENTIDADES = TextBoxDiretorioEntidades.Text;
                sistema.TXT_NAMESPACE_DADOS = TextBoxNamespaceDados.Text;
                sistema.TXT_NAMESPACE_NEGOCIO = TextBoxNamespaceNegocio.Text;
                sistema.TXT_NAMESPACE_ENTIDADES = TextBoxNamespaceEntidades.Text;
                SistemaService.Atualizar(sistema);

                MessageBox.Show("Sistema alterado com sucesso!");
            }
            else
            {
                var sistema = new SistemaEntidade
                {
                    NOM_SISTEMA = TextBoxNome.Text,
                    TXT_DIRETORIO_DADOS = TextBoxDiretorioDados.Text,
                    TXT_DIRETORIO_NEGOCIO = TextBoxDiretorioNegocio.Text,
                    TXT_DIRETORIO_ENTIDADES = TextBoxDiretorioEntidades.Text,
                    TXT_NAMESPACE_DADOS = TextBoxNamespaceDados.Text,
                    TXT_NAMESPACE_NEGOCIO = TextBoxNamespaceNegocio.Text,
                    TXT_NAMESPACE_ENTIDADES = TextBoxNamespaceEntidades.Text
                };
                SistemaService.Inserir(sistema);

                MessageBox.Show("Sistema inserido com sucesso!");
            }

            CarregarSistemas();
            LimparFormulario();
        }

        private void ButtonExcluir_Click(object sender, EventArgs e)
        {
            var sistemaSelecionado = (SistemaEntidade)ListSistemas.SelectedItem;

            if (sistemaSelecionado != null)
            {
                SistemaService.Deletar(sistemaSelecionado);
                CarregarSistemas();
                LimparFormulario();
                ModoEdicao = false;
            }
        }

        private void CarregarSistemas()
        {
            ListSistemas.DataSource = SistemaService.Listar();
        }

        private void LimparFormulario()
        {
            ListSistemas.SelectedIndex = -1;

            TextBoxNome.Text = "";
            TextBoxDiretorioDados.Text = "";
            TextBoxDiretorioNegocio.Text = "";
            TextBoxDiretorioEntidades.Text = "";
            TextBoxNamespaceDados.Text = "";
            TextBoxNamespaceNegocio.Text = "";
            TextBoxNamespaceEntidades.Text = "";
        }
    }
}