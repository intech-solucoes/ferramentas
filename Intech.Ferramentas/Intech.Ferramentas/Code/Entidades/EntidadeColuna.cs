namespace Intech.Ferramentas.Code.Entidades
{
    public class EntidadeColuna
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string TipoTS { get; set; }
        public bool AceitaNulo { get; set; }
        public bool? ChavePrimaria { get; set; }
        public bool? IsColunaExtra { get; set; }
    }
}