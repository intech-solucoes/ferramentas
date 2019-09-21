using Dapper;
using Intech.Ferramentas.GeradorCodigo.Code;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

                Conexao.Execute("UPDATE CS_DADOS_PESSOAIS SET EMAIL_AUX = @EMAIL_AUX, FONE_CELULAR = @FONE_CELULAR", new { EMAIL_AUX = TextBoxPSEmail.Text, FONE_CELULAR = TextBoxPSCelular.Text });
                Conexao.Close();
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

        private void ButtonLimparNodeModules_Click(object sender, EventArgs e)
        {
            BackgroundWorkerLimparNodeModules.RunWorkerAsync();
            ProgressBar1.Style = ProgressBarStyle.Marquee;
            ProgressBar1.MarqueeAnimationSpeed = 5;
        }

        private void BackgroundWorkerLimparNodeModules_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ExecutarLimpezaNodeModules();
        }

        private void BackgroundWorkerLimparNodeModules_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {

                // reconfigura a progressbar para o padrao.
                ProgressBar1.MarqueeAnimationSpeed = 0;
                ProgressBar1.Style = ProgressBarStyle.Blocks;
                ProgressBar1.Value = 0;
            }
            else
            {
                MessageBox.Show("Diretórios node_modules apagados com sucesso!");
            }
        }

        private void ExecutarLimpezaNodeModules()
        {
            ApagarPastaNodeModules("C:\\git");
        }

        private void ApagarPastaNodeModules(string diretorio)
        {
            var pastas = Directory.EnumerateDirectories(diretorio);

            foreach (var pasta in pastas)
            {
                if (pasta.Contains("node_modules"))
                {
                    Directory.Delete(pasta, true);
                    break;
                }
                else
                {
                    if(!pasta.Contains(".git"))
                        ApagarPastaNodeModules(pasta);
                }
            }
        }

        private void ButtonPWCriarUsuarios_Click(object sender, EventArgs e)
        {
            Conexao = new SqlConnection(ConnectionString);
            Conexao.Open();

            var usuarios = Conexao
                .Query<Usuario>(
                    "SELECT P.NO_PESSOA, P.CD_PESSOA, PF.NR_CPF, CT.SQ_CONTRATO_TRABALHO, E.NO_EMAIL " +
                    "FROM FI_PESSOA_FISICA PF " +
                    "INNER JOIN FI_PESSOA P ON P.CD_PESSOA = PF.CD_PESSOA " +
                    "LEFT JOIN FI_ENDERECO_PESSOA E ON E.CD_PESSOA = P.CD_PESSOA " +
                    "LEFT JOIN FI_CONTRATO_TRABALHO CT ON CT.CD_PESSOA = P.CD_PESSOA")
                .ToList();

            foreach (var user in usuarios)
            {
                var proximoCodigo = Conexao.ExecuteScalar<int>("SELECT TOP 1 (0 + USR_CODIGO + 1) FROM FR_USUARIO ORDER BY USR_CODIGO DESC");
                var senhaEncriptada = GerarHashMd5(proximoCodigo + "123");

                Conexao.Execute(
                        "INSERT INTO FR_USUARIO(USR_CODIGO, USR_LOGIN, USR_SENHA, USR_ADMINISTRADOR, USR_TIPO_EXPIRACAO, USR_NOME, USR_EMAIL, CD_PESSOA, EE_TERMO_RESPONSABILIDADE, CD_PESSOA_CLIENTE) " +
                        "VALUES(@USR_CODIGO, @USR_LOGIN, @USR_SENHA, @USR_ADMINISTRADOR, @USR_TIPO_EXPIRACAO, @USR_NOME, @USR_EMAIL, @CD_PESSOA, @EE_TERMO_RESPONSABILIDADE, @CD_PESSOA_CLIENTE)",
                        new {
                            USR_CODIGO = proximoCodigo,
                            USR_LOGIN = user.NR_CPF,
                            USR_SENHA = senhaEncriptada,
                            USR_ADMINISTRADOR = "N",
                            USR_TIPO_EXPIRACAO = "N",
                            USR_NOME = user.NO_PESSOA,
                            USR_EMAIL = user.NO_EMAIL,
                            CD_PESSOA = user.CD_PESSOA,
                            EE_TERMO_RESPONSABILIDADE = "S",
                            CD_PESSOA_CLIENTE = 1
                        });
            }

            Conexao.Close();

            MessageBox.Show("Usuários incluídos com sucesso!");
        }

        private string GerarHashMd5(string input)
        {
            var md5Hash = MD5.Create();
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }

    public class Usuario
    {
        public string CD_PESSOA { get; set; }
        public string NO_PESSOA { get; set; }
        public string NO_EMAIL { get; set; }
        public string NR_CPF { get; set; }
        public int SQ_CONTRATO_TRABALHO { get; set; }
    }
}