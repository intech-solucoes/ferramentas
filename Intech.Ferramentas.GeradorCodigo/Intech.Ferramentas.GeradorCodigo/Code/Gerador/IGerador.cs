namespace Intech.Ferramentas.GeradorCodigo.Code.Gerador
{
    public interface IGerador
    {
        void CriarConexao();
        void BuscarColunas(Entidade configEntidade);
    }
}
