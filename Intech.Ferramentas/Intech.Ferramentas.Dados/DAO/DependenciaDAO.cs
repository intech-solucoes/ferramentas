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
	public abstract class DependenciaDAO : BaseDAO<DependenciaEntidade>
	{
		public DependenciaDAO (IDbTransaction tx = null) : base(tx) { }

		public virtual List<DependenciaEntidade> BuscarPorOidProjeto(decimal OID_PROJETO)
		{
			try
			{
				if (AppSettings.IS_SQL_SERVER_PROVIDER)
					return Conexao.Query<DependenciaEntidade>("SELECT *  FROM DEPENDENCIA  WHERE OID_PROJETO = @OID_PROJETO", new { OID_PROJETO }).ToList();
				else if (AppSettings.IS_ORACLE_PROVIDER)
					return Conexao.Query<DependenciaEntidade>("SELECT * FROM DEPENDENCIA WHERE OID_PROJETO=:OID_PROJETO", new { OID_PROJETO }).ToList();
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
