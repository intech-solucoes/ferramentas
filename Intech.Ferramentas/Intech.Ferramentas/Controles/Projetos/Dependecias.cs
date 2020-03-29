using Intech.Ferramentas.Dados.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intech.Ferramentas.Controles.Projetos
{
    public partial class Dependecias : Form
    {
        private DataTable DataTable = new DataTable();

        public ProjetoEntidade ProjetoSelecionado { get; set; }

        public Dependecias(ProjetoEntidade projetoSelecionado)
        {
            ProjetoSelecionado = projetoSelecionado;
            DataTable.Columns.Add("Diretorio");
            InitializeComponent();
        }

        private void Dependecias_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                ButtonProcurarDiretorio.Image = FontAwesome.Instance
                    .GetImage(new FontAwesome.Properties(FontAwesome.Type.FolderOpenO)
                    {
                        Size = 18,
                        ForeColor = Color.Black
                    });


            }
        }
        
        private void ButtonProcurarDiretorio_Click(object sender, EventArgs e)
        {
            using (var fldrDlg = new FolderBrowserDialog())
            {
                if (fldrDlg.ShowDialog() == DialogResult.OK)
                    TextBoxDiretorio.Text = fldrDlg.SelectedPath;
            }
        }

        private void ButtonIncluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxDiretorio.Text))
            {
                var newRow = DataTable.NewRow();
                newRow.SetField("Diretorio", TextBoxDiretorio.Text);
                DataTable.Rows.Add(newRow);
                GridDiretorios.DataSource = DataTable;
                TextBoxDiretorio.Text = "";
            }
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            var dados = GridDiretorios.DataSource;
            var rows = ((DataTable)dados).Rows;
            var row = rows[0][0];


        }
    }
}