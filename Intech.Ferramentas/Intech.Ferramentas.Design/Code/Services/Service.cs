using System.Collections.Generic;

namespace Intech.Ferramentas.Code.Services
{
    public class Service
    {
        public string Nome { get; set; }
        public List<ServiceMetodo> Metodos { get; set; }
        public List<string> Imports { get; set; }
    }
}