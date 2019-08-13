using Dapper;
using Intech.Ferramentas.GeradorCodigo.Code;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Intech.Ferramentas.GeradorCodigo.Controles
{
    public partial class ControleUtilitarios : UserControl
    {
        private SqlConnection Conexao;
        private string ConnectionString => ((Conexao)ComboBoxConexao.SelectedItem).ConnectionString;

        public ControleUtilitarios()
        {
            InitializeComponent();
        }

        private void ControleUtilitarios_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                ComboBoxConexao.DataSource = new Conexoes().Lista;
            }
        }

        private void ButtonPSSalvarEmailCelular_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new SqlConnection(ConnectionString);
                Conexao.Open();

                Conexao.Execute("UPDATE CS_DADOS_PESSOAIS SET EMAIL_AUX = 'roniely@intech.com.br', FONE_CELULAR = '061999999349' ", new { EMAIL_AUX = TextBoxPSEmail.Text, FONE_CELULAR = TextBoxPSCelular.Text });
                MessageBox.Show("Dados alterados com sucesso!");
            }
            catch (Exception ex)
            {
                var msg = MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.Retry)
                    ButtonPSSalvarEmailCelular_Click(sender, e);
            }
        }

        private void ButtonPWResetarSenhas_Click(object sender, EventArgs e)
        {

        }
    }
}