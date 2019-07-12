using Intech.Ferramentas.GeradorCodigo.Code;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Intech.Ferramentas.GeradorCodigo.Controles
{
    public partial class ControleUtilitarios : UserControl
    {
        private SqlConnection Conexao;

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

        private void ButtonSalvarEmailCelular_Click(object sender, EventArgs e)
        {
            //Conexao = new SqlConnection(ConfigConexao.ConnectionString);
            //Conexao.Open();


        }
    }
}