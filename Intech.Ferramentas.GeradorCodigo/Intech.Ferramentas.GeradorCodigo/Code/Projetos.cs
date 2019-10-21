#region Usings
using Intech.Ferramentas.GeradorCodigo.Controles.NovoProjeto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; 
#endregion

namespace Intech.Ferramentas.GeradorCodigo.Code
{
    public class Projetos : JsonListHelper<Projeto>
    {
        public Projetos()
            : base(Path.Combine(Directory.GetCurrentDirectory(), "../projetos.json"))
        {

        }

        public List<Projeto> BuscarPorSistema(string sistema) =>
            Lista.Where(x => x.Sistema == sistema && x.Tipo != TipoProjeto.API).ToList();
    }

    public class Projeto : JsonListItem
    {
        public string Nome { get; set; }
        public TipoProjeto Tipo { get; set; }
        public string Diretorio { get; set; }
        public List<Guid> Dependentes { get; set; }
        public List<string> Services { get; set; }
        public string Sistema { get; set; }
        public string Namespace { get; set; }
        public Guid API { get; set; }
    }
}