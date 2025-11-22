using Operadores.Models;

double x = 0;
double y = 0;
string escolha;

Operacao calc = new Operacao();

Console.WriteLine("Calculadora Simples\n");
do
{
    
Console.WriteLine("Digite a operação desejada:");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Potência");
Console.WriteLine("6 - Raiz Quadrada");
Console.WriteLine("Digite 0 para sair.");
escolha = Console.ReadLine()!;

double LerNumero(string mensagem)
{
    Console.WriteLine(mensagem);
    double valor;
    while (!double.TryParse(Console.ReadLine(), out valor))
    {
        Console.WriteLine("Entrada inválida. Digite novamente:");
    }
    return valor;
}

if (escolha == "1" || escolha == "2" || escolha == "3" || escolha == "4")
{
    x = LerNumero("Digite o primeiro número:");
    y = LerNumero("Digite o segundo número:");
}
else if (escolha == "5")
{
    x = LerNumero("Digite a base:");
    y = LerNumero("Digite o expoente:");
}
else if (escolha == "6")
{
    x = LerNumero("Digite o número para calcular a raiz quadrada:"); 
}
else
{
    Console.WriteLine("Operação inválida. Por favor, escolha uma operação válida.");
    return;
}


switch (escolha)
    {
    case "1":
        calc.Somar(x, y);
        break;
    case "2":
        calc.Subtrair(x, y);
        break;
    case "3":
        calc.Multiplicacao(x, y);
        break;
    case "4":
        if (y == 0)
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
            break;
        }
        calc.Divisao(x, y);
        break;
    case "5":
        calc.Potencia(x, y);
        break;
    case "6":
        calc.RaizQuadrada(x);
        break;
    case "0":
        Console.WriteLine("Encerrando a calculadora.");
        Environment.Exit(0);
        break;
    default:
        Console.WriteLine("Operação inválida. Por favor, escolha uma operação válida.");
        break;
    }
} while (escolha != "0");