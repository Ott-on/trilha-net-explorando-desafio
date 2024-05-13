namespace DesafioProjetoHospedagem.Models
{
    public class TiposDeSuite
    {
    public static Suite Standard { get; } = new Suite("Standard", 2, 100);
    public static Suite Economica { get; } = new Suite("Economica", 2, 80);
    public static Suite Familiar { get; } = new Suite("Familiar", 6, 150);
    public static Suite Duplex { get; } = new Suite("Duplex", 4, 200);
    public static Suite Compacta { get; } = new Suite("Compacta", 2, 70);   
    }
}