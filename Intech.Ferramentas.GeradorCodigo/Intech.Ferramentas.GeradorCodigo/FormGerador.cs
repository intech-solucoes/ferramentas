#region Usings
using Intech.Ferramentas.GeradorCodigo.Code;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
#endregion

namespace Intech.Ferramentas.GeradorCodigo
{
    public partial class FormGerador : Form
    {
        public Config Config { get; set; }

        public Sistema SistemaSelecionado => Config.Sistema[ComboBoxSistemas.SelectedIndex];

        public FormGerador()
        {
            InitializeComponent();
            
            Config = ConfigManager.Get();
        }

        private void FormGerador_Load(object sender, System.EventArgs e)
        {
            BuscarClientes();
            BuscarEntidades();
        }

        private void BuscarClientes()
        {
            foreach (var cliente in Config.Sistema)
                ComboBoxSistemas.Items.Add(cliente.Nome);

            ComboBoxSistemas.SelectedIndex = 0;
        }

        private void BuscarEntidades()
        {
            var listaEntidades = new List<DirectoryInfo>();
            var diretorioEntidades = Directory.EnumerateDirectories(Path.Combine(SistemaSelecionado.Diretorios.Dados, "Scripts"));

            foreach (var diretorioEntidade in diretorioEntidades)
                listaEntidades.Add(new DirectoryInfo(diretorioEntidade));

            ListEntidades.DataSource = listaEntidades;
            ListEntidades.DisplayMember = "Name";
        }

        private void ButtonGerar_Click(object sender, System.EventArgs e)
        {
            var listaConfigsEntidades = new List<ConfigEntidade>();

            foreach (DirectoryInfo entidade in ListEntidades.SelectedItems)
            {
                var caminhoEntidadeConfig = Path.Combine(entidade.FullName, "entidade.json");
                var configEntidade = JsonConvert.DeserializeObject<ConfigEntidade>(File.ReadAllText(caminhoEntidadeConfig));
                configEntidade.Nome = entidade.Name;

                listaConfigsEntidades.Add(configEntidade);
            }

            var gerador = new GeradorSqlServer(Config, SistemaSelecionado, listaConfigsEntidades);
            gerador.Gerar(CheckBoxGerarEntidade.Checked, CheckBoxGerarDAO.Checked, CheckBoxGerarProxy.Checked);
        }

        private void ComboBoxSistemas_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            BuscarEntidades();
        }
    }
}
