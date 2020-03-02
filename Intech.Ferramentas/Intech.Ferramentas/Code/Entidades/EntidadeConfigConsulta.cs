using System.Collections.Generic;

namespace Intech.Ferramentas.Code.Entidades
{
    public class EntidadeConfigConsulta
    {
        public bool RetornaLista { get; set; }
        public string Retorno { get; set; }
        public List<KeyValuePair<string, string>> ParametrosConsulta { get; set; } = new List<KeyValuePair<string, string>>();
    }
}
