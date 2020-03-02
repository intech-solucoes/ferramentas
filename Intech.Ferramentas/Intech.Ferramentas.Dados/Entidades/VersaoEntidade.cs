using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Intech.Ferramentas.Dados.Entidades
{
    [Table("VERSAO")]
    public class VersaoEntidade
    {
		[Key]
		public decimal OID_VERSAO { get; set; }
		public string TXT_VERSAO { get; set; }
		public string TXT_CHANGELOG { get; set; }
		public decimal OID_PROJETO { get; set; }
		public DateTime DTA_UPLOAD { get; set; }
		[Write(false)] public ProjetoEntidade Projeto { get; set; }
        
    }
}
