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
    public abstract class VersaoDAO : BaseDAO<VersaoEntidade>
    {
        
    }
}
