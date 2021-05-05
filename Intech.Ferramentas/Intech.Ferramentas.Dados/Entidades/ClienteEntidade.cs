using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Intech.Ferramentas.Dados.Entidades
{
	[Table("CLIENTE")]
	public class ClienteEntidade
	{
		[Key]
		public decimal OID_CLIENTE { get; set; }
		public string NOME { get; set; }
		public string SENHA { get; set; }
		public string USUARIO { get; set; }
	}
}
