using System.Collections.Generic;

namespace Intech.Ferramentas.Code.Services
{
    public class ServiceMetodo
    {
        public string Nome { get; set; }
        public string Retorno { get; set; }
        public string Rota { get; set; }
        public string Tipo { get; set; }
        public string Resposta { get; set; }
        public List<ServiceParametro> Parametros { get; set; }
    }
}