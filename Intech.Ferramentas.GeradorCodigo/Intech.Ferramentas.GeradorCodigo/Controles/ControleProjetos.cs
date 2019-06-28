using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intech.Ferramentas.GeradorCodigo.Controles.NovoProjeto;

namespace Intech.Ferramentas.GeradorCodigo.Controles
{
    public partial class ControleProjetos : UserControl
    {
        public ControleProjetos()
        {
            InitializeComponent();
        }

        private void ButtonVSCode_Click(object sender, EventArgs e)
        {

        }

        private void ButtonVS_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNovo_Click(object sender, EventArgs e)
        {
            new FormNovoProjeto().ShowDialog();
        }
    }
}