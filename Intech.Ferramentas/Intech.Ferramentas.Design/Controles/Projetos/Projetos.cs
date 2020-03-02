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
            var projetoSelecionado = (ProjetoEntidade)ListProjetos.SelectedItem;

            if (projetoSelecionado != null)
            {
                TextBoxNome.Text = projetoSelecionado.NOM_PROJETO;
                TextBoxDiretorio.Text = $"{UserConfigManager.Get().GitBase}{projetoSelecionado.TXT_DIRETORIO}";
                TextBoxNamespace.Text = projetoSelecionado.TXT_NAMESPACE;

                switch (projetoSelecionado.IND_TIPO_PROJETO)
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

                ComboBoxSistema.SelectedValue = projetoSelecionado.OID_SISTEMA;

                CarregarProjetosAPI(projetoSelecionado);

                if (ComboBoxProjetoAPI.Items.Count > 0)
                {
                    ComboBoxProjetoAPI.Enabled = true;

                    if (projetoSelecionado.OID_PROJETO_API.HasValue)
                        ComboBoxProjetoAPI.SelectedValue = projetoSelecionado.OID_PROJETO_API.Value;
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
                var projeto = (ProjetoEntidade)ListProjetos.SelectedItem;

                projeto.NOM_PROJETO = TextBoxNome.Text;
                projeto.TXT_DIRETORIO = TextBoxDiretorio.Text.Replace(UserConfigManager.Get().GitBase, "");
                projeto.TXT_NAMESPACE = TextBoxNamespace.Text;

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

                ProjetoService.Atualizar(projeto);

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
            var ProjetoSelecionado = (ProjetoEntidade)ListProjetos.SelectedItem;

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
    }
}