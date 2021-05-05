using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Intech.Ferramentas.Dados.Entidades
{
	[Table("PROJETO")]
	public class ProjetoEntidade
	{
		[Key]
		public decimal OID_PROJETO { get; set; }
		public string NOM_PROJETO { get; set; }
		public string IND_TIPO_PROJETO { get; set; }
		public string TXT_DIRETORIO { get; set; }
		public string TXT_NAMESPACE { get; set; }
		public decimal OID_SISTEMA { get; set; }
		public decimal? OID_PROJETO_API { get; set; }
		public decimal? OID_CLIENTE { get; set; }
		[Write(false)] public List<VersaoEntidade> Versoes { get; set; }
		[Write(false)] public SistemaEntidade Sistema { get; set; }
		[Write(false)] public List<DependenciaEntidade> Dependencias { get; set; }
	}
}
