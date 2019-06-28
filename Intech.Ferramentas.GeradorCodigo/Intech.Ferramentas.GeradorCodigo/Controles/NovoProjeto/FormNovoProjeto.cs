using System;
using System.Windows.Forms;

namespace Intech.Ferramentas.GeradorCodigo.Controles.NovoProjeto
{
    public partial class FormNovoProjeto : Form
    {
        public FormNovoProjeto()
        {
            InitializeComponent();
        }

        public void Navegar(Control control)
        {
            Controls.Clear();

            control.Dock = DockStyle.Fill;
            Controls.Add(control);
        }

        private void FormNovoProjeto_Load(object sender, EventArgs e)
        {
            Navegar(new ControlPasso1(this));
        }
    }
}