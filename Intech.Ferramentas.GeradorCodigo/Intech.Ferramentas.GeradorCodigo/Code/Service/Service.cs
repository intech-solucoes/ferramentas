using System.Collections.Generic;

namespace Intech.Ferramentas.GeradorCodigo.Code.Service
{
    public class Service
    {
        public string Nome { get; set; }
        public List<Metodo> Metodos { get; set; }
        public List<string> Imports { get; set; }
    }

    public class Metodo
    {
        public string Nome { get; set; }
        public string Retorno { get; set; }
        public string Rota { get; set; }
        public string Tipo { get; set; }
        public List<Parametro> Parametros { get; set; }
    }

    public class Parametro
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public bool IsURL { get; set; }
    }
}