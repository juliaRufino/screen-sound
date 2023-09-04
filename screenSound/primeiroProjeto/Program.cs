//Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
//List<String> listaDasBandas = new List<string>();

//Criando um dicionario chave = string valores = list<int>
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

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
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMediaDeUmaBanda(); ;
            break;
        case -1:
            Console.WriteLine("Tchau tchau! :)");
            break;
        default:
            Console.WriteLine("Opção Invalida!");
            break;
    }
}

ExibirLogo();
ExibirOpcoesDoMenu();

void RegistrarBanda()
{
    //Limpar console
    Console.Clear();

    ExibirTituloDaOpcao("Registro de Bandas");

    // Exibe o a mensagem no console mas recebe o valor do usuário na mesma linha
    Console.Write("Digite o nome da banda que deseja registrar: ");

    // A exclamação serve para indicar que nao aceitamos numero nulos
    string nomeDaBanda = Console.ReadLine()!;

    //Adicionando os valores no dicionario, e nao temos nota ainda para adicionar
    bandasRegistradas.Add(nomeDaBanda, new List<int>());

    Console.WriteLine("Registrando a banda....");

    // Faz o sistema esperar 2000 milisegundos
    Thread.Sleep(1500);

    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");

    Thread.Sleep(4000);

    //Limpa o console
    Console.Clear();

    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();

    ExibirTituloDaOpcao("Bandas registradas");

    //for (int i = 0; i < listaDasBandas.Count(); i++)
    //{
    //    Console.WriteLine("\nBanda:" + listaDasBandas[i]);
    //}

    //Caminha estre todos os elementos, e pra cada elemento realiza algo
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int qtdDeLetras = titulo.Length;

    // Adiciona elementos a esquerda, recebe 2 argumentos, a quantidade e qual elemento
    string asteriscos = string.Empty.PadLeft(qtdDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    //digite qual banda deseja avaliar
    //se a banda existir no dicionario => atribuir uma nota
    //senão, voltar ao menu

    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    //Verificacão se aquela banda foi registrada
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");

        //Pegando a nota que o usario digtou, e o parse é para converter a string para int
        //O exclamação é porque precisa ser uma string nao queremos outro valor/nem ser vazio
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();

    }else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    }

}

void ExibirMediaDeUmaBanda()
{
    Console.Clear();

    ExibirTituloDaOpcao("Exibir média das notas");
    Console.WriteLine("Digite o nome da banda que deseja visualizar a média das notas: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDasBandas = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A média da banda {nomeDaBanda} é {notasDasBandas.Average()}.");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();

    } else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    }

}


