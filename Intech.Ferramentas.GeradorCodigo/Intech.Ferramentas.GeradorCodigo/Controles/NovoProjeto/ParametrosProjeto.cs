namespace Intech.Ferramentas.GeradorCodigo.Controles.NovoProjeto
{
    public static class ParametrosProjeto
    {
        public static TipoProjeto? TipoProjeto { get; set; }
        public static TipoOperacao TipoOperacao { get; set; }
        public static string Diretorio { get; set; }
        public static string NomeProjeto { get; set; }
    }

    public enum TipoProjeto
    {
        Web = 0,
        Mobile = 1,
        API = 2
    }

    public enum TipoOperacao
    {
        ProjetoExistente,
        ProjetoNovo
    }
}
