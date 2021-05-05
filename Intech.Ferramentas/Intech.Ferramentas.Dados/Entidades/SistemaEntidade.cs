using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Intech.Ferramentas.Dados.Entidades
{
	[Table("SISTEMA")]
	public class SistemaEntidade
	{
		[Key]
		public decimal OID_SISTEMA { get; set; }
		public string NOM_SISTEMA { get; set; }
		public string TXT_DIRETORIO_DADOS { get; set; }
		public string TXT_DIRETORIO_NEGOCIO { get; set; }
		public string TXT_DIRETORIO_ENTIDADES { get; set; }
		public string TXT_NAMESPACE_DADOS { get; set; }
		public string TXT_NAMESPACE_NEGOCIO { get; set; }
		public string TXT_NAMESPACE_ENTIDADES { get; set; }
		[Write(false)] public List<ProjetoEntidade> Projetos { get; set; }
	}
}
