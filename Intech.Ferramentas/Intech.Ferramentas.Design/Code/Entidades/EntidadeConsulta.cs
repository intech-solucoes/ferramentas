using System.Collections.Generic;

namespace Intech.Ferramentas.Code.Entidades
{
    public class EntidadeConsulta
    {
        public string Nome { get; set; }
        public string QuerySqlServer { get; set; }
        public string QueryOracle { get; set; }
        public string Retorno { get; set; }
        public bool RetornaLista { get; set; }
        public List<KeyValuePair<string, string>> Parametros { get; set; } = new List<KeyValuePair<string, string>>();
    }
}
