using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Intech.Ferramentas.Dados.Entidades
{
	[Table("DEPENDENCIA")]
	public class DependenciaEntidade
	{
		[Key]
		public decimal ID { get; set; }
		public string TXT_DIRETORIO { get; set; }
		public decimal OID_PROJETO { get; set; }
	}
}
