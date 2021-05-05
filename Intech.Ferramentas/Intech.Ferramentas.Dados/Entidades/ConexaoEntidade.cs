using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Intech.Ferramentas.Dados.Entidades
{
	[Table("CONEXAO")]
	public class ConexaoEntidade
	{
		[Key]
		public decimal OID_CONEXAO { get; set; }
		public string NOME { get; set; }
		public string SERVIDOR { get; set; }
		public string USUARIO { get; set; }
		public string SENHA { get; set; }
		public string BANCO { get; set; }
		public string PROVIDER { get; set; }
		public decimal OID_SISTEMA { get; set; }
	}
}
