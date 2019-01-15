﻿#region Usings
using Intech.Ferramentas.GeradorCodigo.Code;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
            BuscarSistemas();
            BuscarEntidades();
        }

        private void BuscarSistemas()
        {
            foreach (var cliente in Config.Sistema)
                ComboBoxSistemas.Items.Add(cliente.Nome);

            ComboBoxSistemas.SelectedIndex = 0;
        }

        private void BuscarEntidades()
        {
            if (!Directory.Exists(SistemaSelecionado.Diretorios.Dados))
            {
                MessageBox.Show("Projeto não encontrato!");
                return;
            }

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

            MessageBox.Show("Gerado com sucesso!");
        }

        private void ComboBoxSistemas_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            BuscarEntidades();
        }

        private void ListEntidades_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var podeGerarProxy = true;
            var listaConfigsEntidades = new List<ConfigEntidade>();

            foreach (DirectoryInfo entidade in ListEntidades.SelectedItems)
            {
                var caminho = entidade.FullName;
                var nomeEntidade = entidade.Name;
                var nomeArquivo = Path.Combine(SistemaSelecionado.Diretorios.Negocio, "Proxy", nomeEntidade + "Proxy.cs");

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

        public List<string> GetAllMethodNames(string strFileName)
        {
            List<string> methodNames = new List<string>();
            var strMethodLines = File.ReadAllLines(strFileName);

            var metodos = strMethodLines.Where(a => (a.Contains("protected") ||
                                                    a.Contains("private") ||
                                                    a.Contains("public")) &&
                                                    !a.Contains("class"));
            foreach (var item in metodos)
            {
                if (item.IndexOf("(") != -1)
                {
                    string strTemp = string.Join("", item.Substring(0, item.IndexOf("(")).Reverse());
                    methodNames.Add(string.Join("", strTemp.Substring(0, strTemp.IndexOf(" ")).Reverse()));
                }
            }
            return methodNames.Distinct().ToList();
        }
    }
}