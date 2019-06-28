using System;
using System.Windows.Forms;

namespace Intech.Ferramentas.GeradorCodigo.Controles.NovoProjeto
{
    public partial class ControlPasso1 : UserControl
    {
        public FormNovoProjeto FormControlador { get; }

        public ControlPasso1(FormNovoProjeto formControlador)
        {
            InitializeComponent();

            FormControlador = formControlador;
        }

        private void ButtonProjetoExistente_Click(object sender, EventArgs e)
        {
            ParametrosProjeto.TipoOperacao = TipoOperacao.ProjetoExistente;
            FormControlador.Navegar(new ControlPasso2(FormControlador));
        }
    }
}