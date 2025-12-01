using Operadores.Models;

Operacao calc = new Operacao();

double x = 0;
double y = 0;
string escolha;
bool ExibirMenu = true;

List<string> Historico = new List<string>();


Console.WriteLine("Calculadora Simples\n");


while (ExibirMenu)
{
Console.Clear();
Console.WriteLine( 
@"Digite a operação desejada: 
1 - Soma
2 - Subtração
3 - Multiplicação
4 - Divisão
5 - Potência
6 - Raiz Quadrada
7 - Ver Histórico
Digite 0 para sair.");
escolha = Console.ReadLine()!;

switch (escolha)
    {
    case "1":
        (x, y) = Operacao.LerDoisNumeros();
        double res1 = calc.Somar(x, y);
        Historico.Add($"{x} + {y} = {res1}");
        Operacao.Pausar();
        break;

    case "2":
        (x, y) = Operacao.LerDoisNumeros();
        double res2 = calc.Subtrair(x, y);
        Historico.Add($"{x} - {y} = {res2}");
        Operacao.Pausar();
        break;

    case "3":
        (x, y) = Operacao.LerDoisNumeros();
        double res3 = calc.Multiplicacao(x, y);
        Historico.Add($"{x} * {y} = {res3}");
        Operacao.Pausar();
        break;

    case "4":
        if (y == 0)
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
            break;
        }
        (x, y) = Operacao.LerDoisNumeros();
        double res4 = calc.Divisao(x, y);
        Historico.Add($"{x} / {y} = {res4}");
        Operacao.Pausar();
        break;

    case "5":
        x = Operacao.LerNumero("Digite a base:");
        y = Operacao.LerNumero("Digite o expoente:");
        double res5 = calc.Potencia(x, y);
        Historico.Add($"{x} ^ {y} = {res5}");
        Operacao.Pausar();
        break;

    case "6":
        x = Operacao.LerNumero("Digite o número para calcular a raiz quadrada:");
        double res6 = calc.RaizQuadrada(x);
        Historico.Add($"Raiz quadrada de {x} = {res6}");
        Operacao.Pausar();
        break;

    case "7":
        Console.WriteLine("Histórico");
        if (Historico.Count == 0)
        {
            Console.WriteLine("Nenhuma operação realizada ainda.");
            Operacao.Pausar();
        }
        else
        {
            foreach (var item in Historico)
            {
                Console.WriteLine(item);
                Operacao.Pausar();
            }
        }
        break;

    case "0":
        Console.WriteLine("Encerrando a calculadora.");
        Environment.Exit(0);
        break;

    default:
        Console.WriteLine("Operação inválida. Por favor, escolha uma operação válida.");
        break;

    }
}