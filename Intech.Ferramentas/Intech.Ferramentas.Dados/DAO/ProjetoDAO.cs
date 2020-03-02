#region Usings
using Dapper;
using Intech.Lib.Dapper;
using Intech.Lib.Web;
using Intech.Ferramentas.Dados.Entidades;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
#endregion

namespace Intech.Ferramentas.Dados.DAO
{   
    public abstract class ProjetoDAO : BaseDAO<ProjetoEntidade>
    {
        
		public virtual IEnumerable<ProjetoEntidade> BuscarPorOidSistema(decimal OID_SISTEMA)
		{
			try
			{
				if(AppSettings.IS_SQL_SERVER_PROVIDER)
					return Conexao.Query<ProjetoEntidade>("SELECT *  FROM PROJETO  WHERE OID_SISTEMA = @OID_SISTEMA  ORDER BY NOM_PROJETO", new { OID_SISTEMA });
				else if(AppSettings.IS_ORACLE_PROVIDER)
					return Conexao.Query<ProjetoEntidade>("SELECT * FROM PROJETO WHERE OID_SISTEMA=:OID_SISTEMA ORDER BY NOM_PROJETO", new { OID_SISTEMA });
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
