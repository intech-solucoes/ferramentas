using Intech.Ferramentas.GeradorCodigo.Code;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Intech.Ferramentas.GeradorCodigo.Controles.NovoProjeto
{
    public partial class FormProjetosDependentes : Form
    {
        public ControleProjetos ControleProjetos { get; }

        private Projeto Projeto => (Projeto)ControleProjetos.ListBoxProjetos.SelectedItem;

        public FormProjetosDependentes(ControleProjetos controleProjetos)
        {
            InitializeComponent();

            ControleProjetos = controleProjetos;
        }

        private void FormProjetosDependentes_Load(object sender, System.EventArgs e)
        {
            var projetos = new Projetos().Lista.Where(x => x.ID != Projeto.ID).OrderBy(x => x.Nome).ToList();
            CheckedListBoxProjetos.DataSource = projetos;
            CheckedListBoxProjetos.DisplayMember = "Nome";

            if (Projeto.Dependentes != null)
            {
                for (int i = 0; i < projetos.Count; i++)
                {
                    CheckedListBoxProjetos.SetItemChecked(i, Projeto.Dependentes.Any(x => x.ID == projetos[i].ID));
                }
            }
        }

        private void ButtonSalvar_Click(object sender, System.EventArgs e)
        {
            Projeto.Dependentes = CheckedListBoxProjetos.CheckedItems.Cast<Projeto>().ToList();
            new Projetos().Salvar(Projeto);
            Close();
        }
    }
}