using Dapper;
using Intech.Ferramentas.GeradorCodigo.Code;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
            //try
            //{
            //    using (var fldrDlg = new FolderBrowserDialog())
            //    {
            //        fldrDlg.SelectedPath = "C:\\";

            //        if (fldrDlg.ShowDialog() == DialogResult.OK)
            //        {
            //            ApagarPastaNodeModules(fldrDlg.SelectedPath);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

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
    }
}