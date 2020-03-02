using Intech.Ferramentas.Dados.Entidades;
using System.Collections.Generic;

namespace Intech.Ferramentas.Services
{
    public class SistemaService : BaseService
    {
        public static List<SistemaEntidade> Listar() =>
            CriarRequisicaoGet<List<SistemaEntidade>>("sistema");

        public static SistemaEntidade BuscarPorOID(decimal oid) =>
            CriarRequisicaoGet<SistemaEntidade>($"sistema/{oid}");

        public static decimal Inserir(SistemaEntidade sistema) =>
            CriarRequisicaoEnvio<SistemaEntidade, decimal>("sistema", sistema);

        public static bool Atualizar(SistemaEntidade sistema) =>
            CriarRequisicaoEnvio<SistemaEntidade, bool>("sistema/editar", sistema);

        public static bool Deletar(SistemaEntidade sistema) =>
            CriarRequisicaoEnvio<SistemaEntidade, bool>("sistema/deletar", sistema);
    }
}