#region Usings
using Intech.Ferramentas.Dados.Entidades;
using Intech.Ferramentas.Code;
using Intech.Ferramentas.Code.Services;
using Intech.Ferramentas.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using Intech.Lib.Web.API;
using Intech.Ferramentas.Code.Gerador.Classes;
#endregion

namespace Intech.Ferramentas.Controles.Services
{
    public partial class Services : PageControl
    {
        public Services()
        {
            InitializeComponent();
            Titulo = "Services";
        }

        private void Services_Load(object sender, EventArgs e)
        {
            CarregarProjetos();
            CarregarDependentes();
        }

        private void CarregarDependentes()
        {
            var projeto = (ProjetoEntidade)ComboBoxProjeto.SelectedItem;
            CheckedListBoxDependentes.DataSource = ProjetoService
                .Listar()
                .Where(x => x.OID_PROJETO_API == projeto.OID_PROJETO)
                .ToList();
            CheckedListBoxDependentes.DisplayMember = "NOM_PROJETO";
        }

        private void CarregarProjetos()
        {
            ComboBoxProjeto.DataSource = ProjetoService
                            .Listar()
                            .Where(x => x.IND_TIPO_PROJETO == "API")
                            .ToList();
        }

        private void CheckBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CheckedListBoxDependentes.Items.Count; i++)
            {
                CheckedListBoxDependentes.SetItemChecked(i, CheckBoxTodos.Checked);
            }
        }

        private void ButtonGerar_Click(object sender, EventArgs e)
        {
            var projeto = (ProjetoEntidade)ComboBoxProjeto.SelectedItem;
            var projetosSelecionados = new List<ProjetoEntidade>();

            foreach (ProjetoEntidade item in CheckedListBoxDependentes.CheckedItems)
                projetosSelecionados.Add(item);

            new GeradorService(projeto, projetosSelecionados).GerarServices();
        }

        private void ComboBoxProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDependentes();
        }
    }
}