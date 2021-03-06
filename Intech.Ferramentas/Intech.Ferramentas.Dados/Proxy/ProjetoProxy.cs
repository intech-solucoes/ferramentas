﻿#region Usings
using Intech.Ferramentas.Dados.DAO;
using Intech.Ferramentas.Dados.Entidades;
using System;
using System.Collections.Generic;
#endregion

namespace Intech.Ferramentas.Dados.Proxy
{
    public class ProjetoProxy : ProjetoDAO
    {
        public override long Inserir(ProjetoEntidade entidade)
        {
            return base.Inserir(entidade);
        }

        public override List<ProjetoEntidade> Listar()
        {
            var lista = base.Listar();

            lista.ForEach(projeto =>
            {
                projeto.Sistema = new SistemaProxy().BuscarPorChave(projeto.OID_SISTEMA);
                projeto.Dependencias = new DependenciaProxy().BuscarPorOidProjeto(projeto.OID_PROJETO);
            });

            return lista;
        }

        public override ProjetoEntidade BuscarPorChave(object chave)
        {
            var projeto = base.BuscarPorChave(chave);

            projeto.Sistema = new SistemaProxy().BuscarPorChave(projeto.OID_SISTEMA);
            projeto.Dependencias = new DependenciaProxy().BuscarPorOidProjeto(projeto.OID_PROJETO);

            return projeto;
        }
    }
}