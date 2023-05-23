using DesafioFundamentos.models;

//UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal percoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o valor por hora: ");
percoPorHora = Convert.ToDecimal(Console.ReadLine());

//Instancia a classe Estacionamento, já com  os valores obtidos anteriormente
Estacionamento es = new Estacionamento (precoInicial, percoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

//Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Cadastrar veículos");
    Console.WriteLine("2 - Remover veículos");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
        es.AdicionarVeiculos();
        break;

        case "2":
        es.RemoverVeiculos();
        break;

        case "3":
        es.ListarVeiculos();
        break;

        case "4":
        exibirMenu = false;
        break;

        default:
        Console.WriteLine("Opção inválida!");
        break;
    }

    Console.WriteLine("Pressione enter para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");