using Intech.Ferramentas.Dados.Entidades;
using Intech.Ferramentas.Code;
using Intech.Ferramentas.Services;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Intech.Ferramentas.Controles.Projetos
{
    public partial class Projetos : PageControl
    {
        public bool ModoEdicao = false;
        private ProjetoEntidade ProjetoSelecionado => (ProjetoEntidade) ListProjetos.SelectedItem;

        public Projetos()
        {
            InitializeComponent();
            Titulo = "Projetos";
        }

        private void Projetos_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                ButtonProcurarDiretorio.Image = FontAwesome.Instance
                    .GetImage(new FontAwesome.Properties(FontAwesome.Type.FolderOpenO)
                    {
                        Size = 18,
                        ForeColor = Color.Black
                    });

                CarregarSistemas();
                CarregarProjetos();
                CarregarProjetosAPI();
                ListProjetos.SelectedIndex = -1;
                LimparFormulario();
            }
        }

        private void ListProjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProjetoSelecionado != null)
            {
                TextBoxNome.Text = ProjetoSelecionado.NOM_PROJETO;
                TextBoxDiretorio.Text = $"{UserConfigManager.Get().GitBase}{ProjetoSelecionado.TXT_DIRETORIO}";
                TextBoxNamespace.Text = ProjetoSelecionado.TXT_NAMESPACE;

                switch (ProjetoSelecionado.IND_TIPO_PROJETO)
                {
                    case "WEB":
                        ComboBoxTipo.SelectedItem = "Web";
                        break;
                    case "API":
                        ComboBoxTipo.SelectedItem = "API";
                        break;
                    case "MOB":
                        ComboBoxTipo.SelectedItem = "Mobile";
                        break;
                }

                ComboBoxSistema.SelectedValue = ProjetoSelecionado.OID_SISTEMA;

                CarregarProjetosAPI(ProjetoSelecionado);

                if (ComboBoxProjetoAPI.Items.Count > 0)
                {
                    ComboBoxProjetoAPI.Enabled = true;

                    if (ProjetoSelecionado.OID_PROJETO_API.HasValue)
                        ComboBoxProjetoAPI.SelectedValue = ProjetoSelecionado.OID_PROJETO_API.Value;
                    else
                        ComboBoxProjetoAPI.SelectedIndex = -1;
                } else
                {
                    ComboBoxProjetoAPI.Enabled = false;
                    ComboBoxProjetoAPI.SelectedIndex = -1;
                    ComboBoxProjetoAPI.Text = "";
                }

                ModoEdicao = true;
            }
        }

        private void ButtonNovo_Click(object sender, EventArgs e)
        {
            CarregarProjetosAPI();
            LimparFormulario();
            ModoEdicao = false;
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            if (ModoEdicao)
            {
                ProjetoSelecionado.NOM_PROJETO = TextBoxNome.Text;
                ProjetoSelecionado.TXT_DIRETORIO = TextBoxDiretorio.Text.Replace(UserConfigManager.Get().GitBase, "");
                ProjetoSelecionado.TXT_NAMESPACE = TextBoxNamespace.Text;

                switch (ComboBoxTipo.SelectedItem)
                {
                    case "Web":
                        ProjetoSelecionado.IND_TIPO_PROJETO = "WEB";
                        break;
                    case "API":
                        ProjetoSelecionado.IND_TIPO_PROJETO = "API";
                        break;
                    case "Mobile":
                        ProjetoSelecionado.IND_TIPO_PROJETO = "MOB";
                        break;
                }

                ProjetoSelecionado.OID_SISTEMA = ((SistemaEntidade)ComboBoxSistema.SelectedItem).OID_SISTEMA;

                if (ComboBoxProjetoAPI.SelectedItem != null)
                    ProjetoSelecionado.OID_PROJETO_API = ((ProjetoEntidade)ComboBoxProjetoAPI.SelectedItem).OID_PROJETO;

                ProjetoService.Atualizar(ProjetoSelecionado);

                MessageBox.Show("Projeto alterado com sucesso!");
            }
            else
            {
                var projeto = new ProjetoEntidade
                {
                    NOM_PROJETO = TextBoxNome.Text,
                    TXT_DIRETORIO = TextBoxDiretorio.Text.Replace(UserConfigManager.Get().GitBase, ""),
                    TXT_NAMESPACE = TextBoxNamespace.Text
                };

                switch (ComboBoxTipo.SelectedItem)
                {
                    case "Web":
                        projeto.IND_TIPO_PROJETO = "WEB";
                        break;
                    case "API":
                        projeto.IND_TIPO_PROJETO = "API";
                        break;
                    case "Mobile":
                        projeto.IND_TIPO_PROJETO = "MOB";
                        break;
                }

                projeto.OID_SISTEMA = ((SistemaEntidade)ComboBoxSistema.SelectedItem).OID_SISTEMA;

                if (ComboBoxProjetoAPI.SelectedItem != null)
                    projeto.OID_PROJETO_API = ((ProjetoEntidade)ComboBoxProjetoAPI.SelectedItem).OID_PROJETO;

                ProjetoService.Inserir(projeto);

                MessageBox.Show("Projeto inserido com sucesso!");
            }

            CarregarProjetos();
            LimparFormulario();
        }

        private void ButtonExcluir_Click(object sender, EventArgs e)
        {
            if (ProjetoSelecionado != null)
            {
                ProjetoService.Deletar(ProjetoSelecionado);
                CarregarProjetos();
                LimparFormulario();
            }
        }

        private void CarregarProjetos()
        {
            ListProjetos.DataSource = ProjetoService.Listar();
        }

        private void CarregarProjetosAPI(ProjetoEntidade projetoSelecionado = null)
        {
            if(projetoSelecionado != null)
            {
                ComboBoxProjetoAPI.DataSource = ProjetoService
                    .Listar()
                    .Where(x
                        => x.OID_PROJETO != projetoSelecionado.OID_PROJETO
                        && x.IND_TIPO_PROJETO == "API"
                    )
                    .ToList();
            } else
            {
                ComboBoxProjetoAPI.DataSource = ProjetoService
                    .Listar()
                    .Where(x
                        => x.IND_TIPO_PROJETO == "API"
                    )
                    .ToList();
            }
            
        }

        private void CarregarSistemas()
        {
            ComboBoxSistema.DataSource = SistemaService.Listar();
            ComboBoxSistema.SelectedIndex = -1;
        }

        private void LimparFormulario()
        {
            ListProjetos.SelectedIndex = -1;

            TextBoxNome.Text = "";
            TextBoxDiretorio.Text = UserConfigManager.Get().GitBase;
            TextBoxNamespace.Text = "";
            ComboBoxTipo.SelectedIndex = -1;
            ComboBoxSistema.SelectedIndex = -1;
            ComboBoxProjetoAPI.Enabled = true;
            ComboBoxProjetoAPI.SelectedIndex = -1;
        }

        private void ButtonProcurarDiretorio_Click(object sender, EventArgs e)
        {
            using (var fldrDlg = new FolderBrowserDialog())
            {
                if (fldrDlg.ShowDialog() == DialogResult.OK)
                    TextBoxDiretorio.Text = fldrDlg.SelectedPath;
            }
        }

        private void ButtonDependencias_Click(object sender, EventArgs e)
        {
            new Dependecias(ProjetoSelecionado).ShowDialog();
        }
    }
}