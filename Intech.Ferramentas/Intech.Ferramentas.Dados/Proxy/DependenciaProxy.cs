using Intech.Ferramentas.Dados.DAO;
using Intech.Ferramentas.Dados.Entidades;
using System.Collections.Generic;

namespace Intech.Ferramentas.Dados.Proxy
{
	public class DependenciaProxy : DependenciaDAO
	{
		public bool Inserir(decimal oidProjeto, List<string> dependencias)
		{
			foreach (var dependencia in dependencias)
				base.Inserir(new DependenciaEntidade
				{
					TXT_DIRETORIO = dependencia,
					OID_PROJETO = oidProjeto
				});

			return true;
		}
	}
}