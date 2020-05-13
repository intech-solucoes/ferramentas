using System.Collections.Generic;
using System.Text;

namespace Intech.Ferramentas.Code.Gerador.Classes
{
    public class GeradorServiceIndex
    {
        public StringBuilder SB { get; private set; }

        private readonly List<string> Services;

        public GeradorServiceIndex(List<string> services)
        {
            Services = services;
        }

        public string Gerar()
        {
            SB = new StringBuilder();

            foreach (var service in Services)
            {
                SB.AppendLine($"export {{ {service} }} from \"./{service}\";");
            }

            return SB.ToString();
        }
    }
}