//Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
List<String> listaDasBandas = new List<string>();

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");

    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");

    //Pegando a opção que o usuário escolheu
    string opcaoEscolhida = Console.ReadLine()!;

    //Convertando de string para inteiro e guardando na variavél
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Tchau tchau! :)");
            break;
        default:
            Console.WriteLine("Opção Invalida!");
            break;
    }
}

void RegistrarBanda()
{
    //Limpar console
    Console.Clear();

    Console.WriteLine("**************************");
    // Exibe a mensagem no console mas pula uma linha
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("**************************");

    // Exibe o a mensagem no console mas recebe o valor do usuário na mesma linha
    Console.Write("Digite o nome da banda que deseja registrar: ");

    // A exclamação serve para indicar que nao aceitamos numero nulos
    string nomeDaBanda = Console.ReadLine()!;

    listaDasBandas.Add(nomeDaBanda);

    Console.WriteLine("Registrando a banda....");

    // Faz o sistema esperar 2000 milisegundos
    Thread.Sleep(1500);

    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");

    Thread.Sleep(2000);

    //Limpa o console
    Console.Clear();

    ExibirLogo();
    ExibirOpcoesDoMenu();
}

ExibirLogo();
ExibirOpcoesDoMenu();

void MostrarBandasRegistradas()
{
    Console.Clear();

    Console.WriteLine("**************************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("**************************");

    for (int i = 0; i < listaDasBandas.Count(); i++)
    {
        Console.WriteLine("\n" + listaDasBandas[i]);
    }

}


