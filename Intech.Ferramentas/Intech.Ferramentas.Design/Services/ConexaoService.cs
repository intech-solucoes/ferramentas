using Intech.Ferramentas.Dados.Entidades;
using System.Collections.Generic;

namespace Intech.Ferramentas.Services
{
    public class ConexaoService : BaseService
    {
        public static List<ConexaoEntidade> Listar() =>
            CriarRequisicaoGet<List<ConexaoEntidade>>("conexao");

        public static ConexaoEntidade BuscarPorOID(decimal oid) =>
            CriarRequisicaoGet<ConexaoEntidade>($"conexao/{oid}");

        public static List<ConexaoEntidade> BuscarPorOidSistema(decimal oidSistema) =>
            CriarRequisicaoGet<List<ConexaoEntidade>>($"conexao/buscarPorOidSistema/{oidSistema}");

        public static decimal Inserir(ConexaoEntidade conexao) =>
            CriarRequisicaoEnvio<ConexaoEntidade, decimal>("conexao", conexao);

        public static bool Atualizar(ConexaoEntidade conexao) =>
            CriarRequisicaoEnvio<ConexaoEntidade, bool>("conexao/editar", conexao);

        public static bool Deletar(ConexaoEntidade conexao) =>
            CriarRequisicaoEnvio<ConexaoEntidade, bool>("conexao/deletar", conexao);

        public static List<string> BuscarBancos(string server, string user, string senha) =>
            CriarRequisicaoGet<List<string>>($"conexao/BuscarBancos/{server}/{user}/{senha}");

        public static List<dynamic> BuscarColunas(string server, string user, string senha, string database, string tabela, bool sinonimo) =>
            CriarRequisicaoGet<List<dynamic>>($"conexao/BuscarColunas/{server}/{user}/{senha}/{database}/{tabela}/{sinonimo}");
    }
}