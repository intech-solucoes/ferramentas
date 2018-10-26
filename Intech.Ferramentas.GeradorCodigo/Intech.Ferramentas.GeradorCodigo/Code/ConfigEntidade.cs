using System.Collections.Generic;

namespace Intech.Ferramentas.GeradorCodigo.Code
{
    public class ConfigEntidade
    {
        public string Nome { get; set; }
        public string NomeTabela { get; set; }
        public bool Sinonimo { get; set; }
        public string ChavePrimaria { get; set; }
        public List<Coluna> ColunasExtras { get; set; } = new List<Coluna>();
    }

    public class Coluna
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public bool AceitaNulo { get; set; }
        public bool ChavePrimaria { get; set; }
        public bool IsColunaExtra { get; set; }
    }

    public class Consulta
    {
        public string Nome { get; set; }
        public string QuerySqlServer { get; set; }
        public string QueryOracle { get; set; }
        public string Retorno { get; set; }
        public bool RetornaLista { get; set; }
        public List<KeyValuePair<string, string>> Parametros { get; set; } = new List<KeyValuePair<string, string>>();
    }

    public class ConfigConsulta
    {
        public bool RetornaLista { get; set; }
        public string Retorno { get; set; }
        public List<KeyValuePair<string, string>> ParametrosConsulta { get; set; } = new List<KeyValuePair<string, string>>();
    }
}
