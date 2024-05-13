using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Console.WriteLine("==Bem-vindo ao nosso sistema de cadastro de hóspedes==\n");
Console.Write("Quantos hóspedes serão: ");
int quantidadeDeHospedes = int.Parse(Console.ReadLine());
for (int i = 1; i <= quantidadeDeHospedes; i++)
{   
    Console.Write($"Digite o nome do hóspede {i}: ");
    hospedes.Add(new Pessoa(Console.ReadLine()));
}

Console.WriteLine("\nTipos de Suite:\n0 - Standard (2 pessoas)\nR$ 100,00\n1 - Econômica(2 pessoas)\nR$ 80,00\n2 - Familiar(6 pessoas)\nR$ 150,00\n3 - Duplex(4 pessoas)\nR$ 200,00\n4 - Compacta(2 pessoas)\nR$ 70,00");
Suite suite = null;
int opcao = int.Parse(Console.ReadLine());

// Cria a suíte
switch(opcao)
{   
    case 0:
        suite = TiposDeSuite.Standard;
        break;
    case 1:
        suite = TiposDeSuite.Economica;
        break;
    case 2:
        suite = TiposDeSuite.Familiar;
        break;
    case 3:
        suite = TiposDeSuite.Duplex;
        break;
    case 4:
        suite = TiposDeSuite.Compacta;
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}

Console.Write("\nDiga a quantidade dias que deseja reservar: ");
int diasParaReservar = int.Parse(Console.ReadLine());

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: diasParaReservar);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
Console.WriteLine($"O tipo de suíte é {reserva.Suite.TipoSuite}");