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

            if (Directory.Exists(diretorioEntidade))
            {
                MessageBox.Show("Já existe uma entidade com o mesmo nome!");
                return;
            }

            Directory.CreateDirectory(diretorioEntidade);

            var diretorioEntidadeJson = Path.Combine(diretorioEntidade, "entidade.json");
            File.WriteAllText(diretorioEntidadeJson, JsonConvert.SerializeObject(entidade, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore } ));

            MessageBox.Show("Entidade criada com sucesso!");
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