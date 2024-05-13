namespace DesafioProjetoHospedagem.Models
{   
    public enum TiposDeSuite
    {
        Standard,
        Econômica,
        Familiar,
        Duplex,
        Compacta
    }
    public class Suite
    {
        public Suite() { }

        public Suite(TiposDeSuite tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public TiposDeSuite TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}