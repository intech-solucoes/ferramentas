using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Intech.Ferramentas.GeradorCodigo.Code.Service
{
    [XmlRoot(ElementName = "doc")]
    public class APIXML
    {
        public assembly assembly { get; set; }
        public List<member> members { get; set; }
    }

    public class assembly
    {
        public string name { get; set; }
    }

    public class member
    {
        [XmlAttribute]
        public string name { get; set; }

        public service service { get; set; }
        public rota rota { get; set; }
        public List<parametro> parametros { get; set; }
        public retorno retorno { get; set; }

        public bool IsMetodo => name[0] == 'M';
        public string NomeMetodo => name.Contains('(') ? name.Substring(2, name.IndexOf('(') - 2).Split('.').Last() : name.Substring(2).Split('.').Last();
    }

    public class service
    {
        [XmlAttribute]
        public string nome { get; set; }
    }

    public class rota
    {
        [XmlAttribute]
        public string caminho { get; set; }

        [XmlAttribute]
        public string tipo { get; set; }
    }

    public class parametro
    {
        [XmlAttribute]
        public string nome { get; set; }

        [XmlAttribute]
        public string tipo { get; set; }
    }

    public class retorno
    {
        [XmlAttribute]
        public string tipo { get; set; }

        [XmlAttribute]
        public bool lista { get; set; }

        [XmlAttribute]
        public string resposta { get; set; }
    }
}