using Intech.Ferramentas.Dados.Entidades;
using System.Collections.Generic;

namespace Intech.Ferramentas.Services
{
    public class ProjetoService : BaseService
    {
        public static List<ProjetoEntidade> Listar() =>
            CriarRequisicaoGet<List<ProjetoEntidade>>("Projeto");

        public static ProjetoEntidade BuscarPorOID(decimal oid) =>
            CriarRequisicaoGet<ProjetoEntidade>($"Projeto/{oid}");

        public static List<ProjetoEntidade> BuscarPorOidSistema(decimal oidSistema) =>
            CriarRequisicaoGet<List<ProjetoEntidade>>($"Projeto/buscarPorOidSistema/{oidSistema}");

        public static decimal Inserir(ProjetoEntidade Projeto) =>
            CriarRequisicaoEnvio<ProjetoEntidade, decimal>("Projeto", Projeto);

        public static bool Atualizar(ProjetoEntidade Projeto) =>
            CriarRequisicaoEnvio<ProjetoEntidade, bool>("Projeto/editar", Projeto);

        public static bool Deletar(ProjetoEntidade Projeto) =>
            CriarRequisicaoEnvio<ProjetoEntidade, bool>("Projeto/deletar", Projeto);
        public static bool InserirDependencias(List<DependenciaEntidade> dependencias) =>
            CriarRequisicaoEnvio<List<DependenciaEntidade>, bool>("Dependencia", dependencias);
    }
}