using Intech.Ferramentas.Dados.Entidades;
using Intech.Ferramentas.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Intech.Ferramentas.Controles.Conexoes
{
    public partial class Conexoes : PageControl
    {
        public bool ModoEdicao = false;

        public Conexoes()
        {
            InitializeComponent();
            Titulo = "Conexões";
        }

        private void Conexoes_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                CarregarConexoes();
                CarregarSistemas();
                ComboBoxProvedor.SelectedIndex = 0;
                ListConexoes.SelectedIndex = -1;

                ButtonAtualizarBancos.Image = FontAwesome.Instance
                        .GetImage(new FontAwesome.Properties(FontAwesome.Type.Refresh)
                        {
                            Size = 18,
                            ForeColor = Color.Black
                        });
            }
        }

        private void CarregarConexoes()
        {
            ListConexoes.DataSource = ConexaoService.Listar();
        }

        private void CarregarSistemas()
        {
            ComboBoxSistema.DataSource = SistemaService.Listar();
            ComboBoxSistema.SelectedIndex = -1;
        }

        private void CarregarBancos()
        {
            ComboBoxBanco.DataSource = ConexaoService.BuscarBancos(ComboBoxServidor.SelectedItem.ToString(), TextBoxUsuario.Text, TextBoxSenha.Text);
        }

        private void LimparFormulario()
        {
            ListConexoes.SelectedIndex = -1;

            TextBoxNome.Text = "";
            ComboBoxProvedor.SelectedIndex = 0;
            ComboBoxServidor.SelectedIndex = -1;
            TextBoxUsuario.Text = "sysdba";
            TextBoxSenha.Text = "masterkey";
            ComboBoxSistema.SelectedIndex = -1;
        }

        private void ButtonNovo_Click(object sender, EventArgs e)
        {
            LimparFormulario();
            ModoEdicao = false;
        }

        private void ListConexoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var conexao = (ConexaoEntidade)ListConexoes.SelectedItem;

            if (conexao != null)
            {
                TextBoxNome.Text = conexao.NOME;
                ComboBoxProvedor.SelectedItem = conexao.PROVIDER;
                ComboBoxServidor.SelectedItem = conexao.SERVIDOR;
                TextBoxUsuario.Text = conexao.USUARIO;
                TextBoxSenha.Text = conexao.SENHA;
                ComboBoxSistema.SelectedValue = conexao.OID_SISTEMA;

                CarregarBancos();
                ComboBoxBanco.SelectedItem = conexao.BANCO;

                ModoEdicao = true;
            }
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            if (ModoEdicao)
            {
                var conexao = (ConexaoEntidade)ListConexoes.SelectedItem;

                conexao.NOME = TextBoxNome.Text;
                conexao.PROVIDER = ComboBoxProvedor.SelectedItem.ToString();
                conexao.SERVIDOR = ComboBoxServidor.SelectedItem.ToString();
                conexao.USUARIO = TextBoxUsuario.Text;
                conexao.SENHA = TextBoxSenha.Text;
                conexao.OID_SISTEMA = ((SistemaEntidade)ComboBoxSistema.SelectedItem).OID_SISTEMA;
                conexao.BANCO = ComboBoxBanco.SelectedItem.ToString();

                ConexaoService.Atualizar(conexao);

                MessageBox.Show("Conexão alterada com sucesso!");
            }
            else
            {
                var conexao = new ConexaoEntidade
                {
                    NOME = TextBoxNome.Text,
                    PROVIDER = ComboBoxProvedor.SelectedItem.ToString(),
                    SERVIDOR = ComboBoxServidor.SelectedItem.ToString(),
                    USUARIO = TextBoxUsuario.Text,
                    SENHA = TextBoxSenha.Text,
                    BANCO = ComboBoxBanco.SelectedItem.ToString()
                };

                conexao.OID_SISTEMA = ((SistemaEntidade)ComboBoxSistema.SelectedItem).OID_SISTEMA;

                ConexaoService.Inserir(conexao);

                MessageBox.Show("Conexão inserida com sucesso!");
            }

            CarregarConexoes();
            LimparFormulario();
        }

        private void ButtonExcluir_Click(object sender, EventArgs e)
        {
            var conexao = (ConexaoEntidade)ListConexoes.SelectedItem;

            if (conexao != null)
            {
                ConexaoService.Deletar(conexao);
                CarregarConexoes();
                LimparFormulario();
            }
        }

        private void ButtonAtualizarBancos_Click(object sender, EventArgs e)
        {
            CarregarBancos();
        }
    }
}