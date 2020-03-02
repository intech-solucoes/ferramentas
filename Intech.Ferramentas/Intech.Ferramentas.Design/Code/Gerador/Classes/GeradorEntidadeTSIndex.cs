#region Usings
using Intech.Ferramentas.Code.Entidades;
using Intech.Ferramentas.Dados.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Intech.Ferramentas.Code.Gerador.Classes
{
    public class GeradorEntidadeTSIndex
    {
        public StringBuilder StringEntidade { get; private set; }

        private readonly List<string> Entidades;

        public GeradorEntidadeTSIndex(List<string> entidades)
        {
            Entidades = entidades;
        }

        public string Gerar()
        {
            StringEntidade = new StringBuilder();

            foreach (var entidade in Entidades)
            {
                StringEntidade.AppendLine($"export {{ {entidade} }} from \"./{entidade}\";");
            }

            return StringEntidade.ToString();
        }
    }
}