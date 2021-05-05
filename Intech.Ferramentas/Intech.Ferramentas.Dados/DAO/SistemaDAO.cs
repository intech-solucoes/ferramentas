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
	public abstract class SistemaDAO : BaseDAO<SistemaEntidade>
	{
		public SistemaDAO (IDbTransaction tx = null) : base(tx) { }

	}
}
