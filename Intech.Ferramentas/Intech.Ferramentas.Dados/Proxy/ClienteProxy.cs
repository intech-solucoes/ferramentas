using Intech.Ferramentas.Dados.DAO;
using System.Data;

namespace Intech.Ferramentas.Dados.Proxy
{
	public class ClienteProxy : ClienteDAO
	{
		public ClienteProxy (IDbTransaction tx = null) : base(tx) { }
	}
}
