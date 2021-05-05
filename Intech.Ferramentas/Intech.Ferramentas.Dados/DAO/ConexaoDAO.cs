using Dapper;
using Intech.Lib.Dapper;
using Intech.Lib.Web;
using Intech.Ferramentas.Dados.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Intech.Ferramentas.Dados.DAO
{
	public abstract class ConexaoDAO : BaseDAO<ConexaoEntidade>
	{
		public ConexaoDAO (IDbTransaction tx = null) : base(tx) { }

		public virtual List<ConexaoEntidade> BuscarPorOidSistema(decimal OID_SISTEMA)
		{
			try
			{
				if (AppSettings.IS_SQL_SERVER_PROVIDER)
					return Conexao.Query<ConexaoEntidade>("SELECT *  FROM CONEXAO  WHERE OID_SISTEMA = @OID_SISTEMA", new { OID_SISTEMA }).ToList();
				else if (AppSettings.IS_ORACLE_PROVIDER)
					return Conexao.Query<ConexaoEntidade>("SELECT * FROM CONEXAO WHERE OID_SISTEMA=:OID_SISTEMA", new { OID_SISTEMA }).ToList();
				else
					throw new Exception("Provider não suportado!");
			}
			finally
			{
				if(Transaction == null)
					Conexao.Close();
			}
		}

	}
}
