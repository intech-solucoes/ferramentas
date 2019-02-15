#region Usings
using Intech.Ferramentas.GeradorCodigo.Code;
using Intech.Ferramentas.GeradorCodigo.Controles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
#endregion

namespace Intech.Ferramentas.GeradorCodigo
{
    public partial class FormGerador : Form
    {
        public FormGerador()
        {
            InitializeComponent();
        }

        private void FormGerador_Load(object sender, System.EventArgs e)
        {
            if(UserConfigManager.Get() == null)
            {
                var formConfig = new FormConfiguracao();
                formConfig.ShowDialog();
            }
        }
    }
}