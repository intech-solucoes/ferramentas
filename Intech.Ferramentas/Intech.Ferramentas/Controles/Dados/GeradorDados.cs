#region Usings
using Intech.Ferramentas.Code;
using Intech.Ferramentas.Code.Entidades;
using Intech.Ferramentas.Code.Gerador;
using Intech.Ferramentas.Dados.Dominios;
using Intech.Ferramentas.Dados.Entidades;
using Intech.Ferramentas.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms; 
#endregion

namespace Intech.Ferramentas.Controles.Dados
{
    public partial class GeradorDados : PageControl
    {
        public SistemaEntidade SistemaSelecionado => (SistemaEntidade)ComboBoxSistemas.SelectedItem;
        public Entidade EntidadeSelecionada => Entidade.Buscar((DirectoryInfo)ListEntidades.SelectedItem);

        public GeradorDados()
        {
            InitializeComponent();
            Titulo = "Dados";
        }

        private void GeradorDados_Load(object sender, System.EventArgs e)
        {
            if (!DesignMode)
            {
                CarregarSistemas();
            }
        }

        private void CarregarSistemas()
        {
            ComboBoxSistemas.DataSource = SistemaService.Listar();
        }

        private void ComboBoxSistemas_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            BuscarEntidades();
            CarregarConexoes();
            CarregarProjetos();
        }

        private void BuscarEntidades()
        {
            var caminhoDados = Path.Combine(UserConfigManager.Get().GitBase, SistemaSelecionado.TXT_DIRETORIO_DADOS);
            if (!Directory.Exists(caminhoDados))
            {
                MessageBox.Show($"Diretório {caminhoDados} não encontrado!");
                return;
            }

            var listaEntidades = new List<DirectoryInfo>();
            var diretorioEntidades = Directory.EnumerateDirectories(Path.Combine(caminhoDados, "Scripts"));

            foreach (var diretorioEntidade in diretorioEntidades)
                listaEntidades.Add(new DirectoryInfo(diretorioEntidade));

            ListEntidades.DataSource = listaEntidades;
            ListEntidades.DisplayMember = "Name";
        }

        private void CarregarConexoes()
        {
            ComboBoxConexao.DataSource = ConexaoService.BuscarPorOidSistema(SistemaSelecionado.OID_SISTEMA);

            if (((List<ConexaoEntidade>)ComboBoxConexao.DataSource).Count > 0)
                ComboBoxConexao.SelectedIndex = 0;
            else
                ComboBoxConexao.SelectedIndex = -1;
        }

        private void CarregarProjetos()
        {
            ComboBoxProjeto.DataSource = ProjetoService
                .BuscarPorOidSistema(SistemaSelecionado.OID_SISTEMA)
                .Where(x => x.IND_TIPO_PROJETO != DMN_TIPO_PROJETO.API)
                .ToList();

            if (((List<ProjetoEntidade>)ComboBoxProjeto.DataSource).Count > 0)
                ComboBoxProjeto.SelectedIndex = 0;
            else
                ComboBoxProjeto.SelectedIndex = -1;
        }

        private void ListEntidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            var podeGerarProxy = true;

            foreach (DirectoryInfo entidade in ListEntidades.SelectedItems)
            {
                var caminho = entidade.FullName;
                var nomeEntidade = entidade.Name;
                var nomeArquivo = Path.Combine(UserConfigManager.Get().GitBase, SistemaSelecionado.TXT_DIRETORIO_NEGOCIO, "Proxy", nomeEntidade + "Proxy.cs");

                if (!File.Exists(nomeArquivo))
                {
                    podeGerarProxy = true;
                }
                else
                {
                    var metodos = GetAllMethodNames(nomeArquivo);
                    if (metodos.Count > 0)
                        podeGerarProxy = false;
                }
            }

            CheckBoxGerarProxy.Enabled = podeGerarProxy;
            CheckBoxGerarProxy.Checked = podeGerarProxy;
        }

        private void ButtonGerar_Click(object sender, System.EventArgs e)
        {
            try
            {
                var listaConfigsEntidades = new List<Entidade>();

                foreach (DirectoryInfo entidade in ListEntidades.SelectedItems)
                {
                    var caminhoEntidadeConfig = Path.Combine(entidade.FullName, "entidade.json");
                    var configEntidade = JsonConvert.DeserializeObject<Entidade>(File.ReadAllText(caminhoEntidadeConfig));
                    configEntidade.Nome = entidade.Name;

                    listaConfigsEntidades.Add(configEntidade);
                }

                var conexao = (ConexaoEntidade)ComboBoxConexao.SelectedItem;
                var projeto = (ProjetoEntidade)ComboBoxProjeto.SelectedItem;

                var gerador = new GeradorSqlServer(conexao, SistemaSelecionado, projeto, listaConfigsEntidades);
                gerador.Gerar(CheckBoxGerarEntidade.Checked, CheckBoxGerarDAO.Checked, CheckBoxGerarProxy.Checked);

                MessageBox.Show("Gerado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<string> GetAllMethodNames(string strFileName)
        {
            List<string> methodNames = new List<string>();
            var fileName = new FileInfo(strFileName).Name.Split('.')[0];
            var strMethodLines = File.ReadAllLines(strFileName);

            var metodos = strMethodLines.Where(a => (a.Contains("protected") ||
                                                    a.Contains("private") ||
                                                    a.Contains("public")) &&
                                                    !a.Contains("class"));
            foreach (var item in metodos)
            {
                if (item.IndexOf("(") != -1)
                {
                    var linha = item.Replace("\t\t", "");
                    string strTemp = string.Join("", linha.Substring(0, linha.IndexOf("(")).Reverse()).Trim();
                    string methodName = string.Join("", strTemp.Substring(0, strTemp.IndexOf(" ")).Reverse());

                    if (methodName != fileName)
                        methodNames.Add(methodName);
                }
            }
            return methodNames.Distinct().ToList();
        }
    }
}