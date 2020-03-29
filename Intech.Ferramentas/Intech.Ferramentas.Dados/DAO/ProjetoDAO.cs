using Dapper;
using Intech.Lib.Dapper;
using Intech.Lib.Web;
using Intech.Ferramentas.Dados.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Intech.Ferramentas.Dados.DAO
{
	public abstract class ProjetoDAO : BaseDAO<ProjetoEntidade>
	{
		public virtual List<ProjetoEntidade> BuscarPorOidSistema(decimal OID_SISTEMA)
		{
			try
			{
				if (AppSettings.IS_SQL_SERVER_PROVIDER)
					return Conexao.Query<ProjetoEntidade>("SELECT *  FROM PROJETO  WHERE OID_SISTEMA = @OID_SISTEMA  ORDER BY NOM_PROJETO", new { OID_SISTEMA }).ToList();
				else if (AppSettings.IS_ORACLE_PROVIDER)
					return Conexao.Query<ProjetoEntidade>("SELECT * FROM PROJETO WHERE OID_SISTEMA=:OID_SISTEMA ORDER BY NOM_PROJETO", new { OID_SISTEMA }).ToList();
				else
					throw new Exception("Provider não suportado!");
			}
			finally
			{
				Conexao.Close();
			}
		}

	}
}
