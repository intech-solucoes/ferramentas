using Intech.Ferramentas.GeradorCodigo.Code;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Intech.Ferramentas.GeradorCodigo
{
    public partial class FormNovaEntidade : Form
    {
        public Sistema Sistema { get; }
        public Entidade Entidade { get; set; }
        public bool Edicao { get; }

        public FormNovaEntidade()
        {
            InitializeComponent();
        }

        public FormNovaEntidade(Sistema sistema)
        {
            InitializeComponent();

            Sistema = sistema;
            LabelNomeSistema.Text = Sistema.Nome;

            ListBoxColunasExtras.DisplayMember = "Nome";
        }

        public FormNovaEntidade(Sistema sistema, Entidade entidade)
        {
            InitializeComponent();

            Sistema = sistema;
            Entidade = entidade;

            LabelNomeSistema.Text = Sistema.Nome;

            TextBoxNomeEntidade.Text = entidade.Nome;
            TextBoxNomeEntidade.Enabled = false;

            TextBoxNomeTabela.Text = entidade.NomeTabela;

            if(entidade.Sinonimo.HasValue)
                CheckBoxSinonimo.Checked = entidade.Sinonimo.Value;

            if (!string.IsNullOrEmpty(entidade.ChavePrimaria))
            {
                CheckBoxChavePrimaria.Checked = true;
                TextBoxChavePrimaria.Text = entidade.ChavePrimaria;
            }
            
            ListBoxColunasExtras.DataSource = entidade.ColunasExtras;
            ListBoxColunasExtras.DisplayMember = "Nome";

            Edicao = true;
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TextBoxNomeEntidade.Text))
            {
                MessageBox.Show("É necessário informar um nome para a entidade!");
                TextBoxNomeEntidade.Focus();
            }

            if (string.IsNullOrEmpty(TextBoxNomeTabela.Text))
            {
                MessageBox.Show("É necessário informar um nome de tabela!");
                TextBoxNomeTabela.Focus();
            }

            List<Coluna> colunasExtras = new List<Coluna>();

            var entidade = new Entidade
            {
                NomeTabela = TextBoxNomeTabela.Text,
                Sinonimo = !CheckBoxSinonimo.Checked ? (bool?)null : CheckBoxSinonimo.Checked,
                ChavePrimaria = string.IsNullOrEmpty(TextBoxChavePrimaria.Text) ? null : TextBoxChavePrimaria.Text,
                ColunasExtras = ListBoxColunasExtras.Items.Cast<Coluna>().ToList()
            };

            var diretorioEntidade = Path.Combine(Sistema.Diretorios.Dados, "Scripts", TextBoxNomeEntidade.Text);

            var diretorioEntidadeJson = Path.Combine(diretorioEntidade, "entidade.json");

            if (!Edicao)
            {
                if (Directory.Exists(diretorioEntidade))
                {
                    MessageBox.Show("Já existe uma entidade com o mesmo nome!");
                    return;
                }

                Directory.CreateDirectory(diretorioEntidade);
            }
            else
            {
                File.Delete(diretorioEntidadeJson);
            }

            File.WriteAllText(diretorioEntidadeJson, JsonConvert.SerializeObject(entidade, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore } ));

            MessageBox.Show("Entidade criada com sucesso!");
            Close();
        }

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            ListBoxColunasExtras.Items.Add(new Coluna
            {
                Nome = TextBoxNomeColuna.Text,
                Tipo = TextBoxTipo.Text,
                AceitaNulo = CheckBoxNulo.Checked
            });

            TextBoxNomeColuna.Text = "";
            TextBoxTipo.Text = "";
            CheckBoxNulo.Checked = false;
        }

        private void ListBoxColunasExtras_SelectedIndexChanged(object sender, EventArgs e)
        {
            var coluna = (Coluna)ListBoxColunasExtras.SelectedItem;

            if (coluna != null)
            {
                TextBoxNomeColuna.Text = coluna.Nome;
                TextBoxTipo.Text = coluna.Tipo;
                CheckBoxNulo.Checked = coluna.AceitaNulo;
            }
        }

        private void ButtonNovaColuna_Click(object sender, EventArgs e)
        {
            TextBoxNomeColuna.Text = "";
            TextBoxTipo.Text = "";
            CheckBoxNulo.Checked = false;
        }

        private void ButtonDeletar_Click(object sender, EventArgs e)
        {
            ListBoxColunasExtras.Items.Remove((Coluna)ListBoxColunasExtras.SelectedItem);

            TextBoxNomeColuna.Text = "";
            TextBoxTipo.Text = "";
            CheckBoxNulo.Checked = false;
        }

        private void CheckBoxChavePrimaria_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxChavePrimaria.Enabled = CheckBoxChavePrimaria.Checked;

            if (!CheckBoxChavePrimaria.Checked)
                TextBoxChavePrimaria.Text = "";
        }
    }
}