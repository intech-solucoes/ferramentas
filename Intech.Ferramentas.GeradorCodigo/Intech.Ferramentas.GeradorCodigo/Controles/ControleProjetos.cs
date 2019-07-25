using Intech.Ferramentas.GeradorCodigo.Code;
using Intech.Ferramentas.GeradorCodigo.Controles.NovoProjeto;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Intech.Ferramentas.GeradorCodigo.Controles
{
    public partial class ControleProjetos : UserControl
    {
        private Projeto ProjetoSelecionado => (Projeto)ListBoxProjetos.SelectedItem;

        public ControleProjetos()
        {
            InitializeComponent();
        }

        private void ControleProjetos_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                PreencherSistemas();
                CarregarListaProjetos();
            }
        }

        private void ListBoxProjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ProjetoSelecionado != null)
            {
                TextBoxDiretorio.Text = ProjetoSelecionado.Diretorio;
                TextBoxRepositorio.Text = ProjetoSelecionado.Nome;
                
                switch(ProjetoSelecionado.Tipo)
                {
                    case TipoProjeto.API:
                        ComboBoxTipo.SelectedItem = "API";
                        break;
                    case TipoProjeto.Mobile:
                        ComboBoxTipo.SelectedItem = "Mobile";
                        break;
                    case TipoProjeto.Web:
                        ComboBoxTipo.SelectedItem = "Web";
                        break;
                }

                ButtonProjetosDependentes.Enabled = ProjetoSelecionado.Tipo == TipoProjeto.API;
                ButtonGerarService.Enabled = ProjetoSelecionado.Tipo == TipoProjeto.API;
                ComboBoxSistema.Text = ProjetoSelecionado.Sistema;
                TextBoxNamespace.Text = ProjetoSelecionado.Namespace;
            }
        }

        private void ButtonVSCode_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void ButtonVS_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNovo_Click(object sender, EventArgs e)
        {
            if(new FormNovoProjeto().ShowDialog() == DialogResult.OK)
            {
                CarregarListaProjetos();
            }
        }

        private void PreencherSistemas()
        {
            ComboBoxSistema.Items.Clear();

            foreach (var cliente in ConfigManager.Config.Sistema)
                ComboBoxSistema.Items.Add(cliente.Nome);

            ComboBoxSistema.SelectedIndex = 0;
        }

        private void CarregarListaProjetos()
        {
            ListBoxProjetos.DataSource = new Projetos().Lista.OrderBy(x => x.Nome).ToList();
            ListBoxProjetos.DisplayMember = "Nome";
        }

        private void Run()
        {
            if (ListBoxProjetos.SelectedItem != null)
            {
                var projeto = (Projeto)ListBoxProjetos.SelectedItem;
                Process.Start($"code", projeto.Diretorio);
            }
        }

        private void ButtonProjetosDependentes_Click(object sender, EventArgs e)
        {
            new FormProjetosDependentes(this).ShowDialog();
        }

        private void ButtonGerarService_Click(object sender, EventArgs e)
        {
            
        }
    }
}