using Intech.Ferramentas.GeradorCodigo.Controles.NovoProjeto;
using System.IO;

namespace Intech.Ferramentas.GeradorCodigo.Code
{
    public class Projetos : JsonListHelper<Projeto>
    {
        public Projetos()
            : base(Path.Combine(Directory.GetCurrentDirectory(), "../projetos.json"))
        {

        }
    }

    public class Projeto : JsonListItem
    {
        public string Nome { get; set; }
        public TipoProjeto Tipo { get; set; }
        public string Diretorio { get; set; }
    }
}