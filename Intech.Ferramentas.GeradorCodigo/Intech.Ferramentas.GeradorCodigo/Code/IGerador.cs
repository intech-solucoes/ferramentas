namespace Intech.Ferramentas.GeradorCodigo.Code
{
    public interface IGerador
    {
        void CriarConexao();
        void BuscarColunas(ConfigEntidade configEntidade);
    }
}
