using Operadores.Models;

Operacao calc = new Operacao();

double x = 0;
double y = 0;
string escolha, OperaçaoBasica;
bool ExibirMenuPrincipal = true;

List<string> Historico = new List<string>();


Console.WriteLine("Calculadora Simples\n");


while (ExibirMenuPrincipal)
{
Console.Clear();
Console.WriteLine("selecione a opção desejada:");
Console.WriteLine("1 - Operações Básicas (Soma, Subtração, Multiplicação, Divisão)");
Console.WriteLine("2 - Potência");
Console.WriteLine("3 - Raiz Quadrada");
Console.WriteLine("4 - Conversão de Moedas");
Console.WriteLine("5 - Histórico de Operações");
Console.WriteLine("0 - Sair");
escolha = Console.ReadLine()!;

switch (escolha)
    {
        case "1":
        Console.Clear();
        Console.WriteLine("Operações Básicas");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Voltar ao menu principal");
        OperaçaoBasica = Console.ReadLine()!;

            switch (OperaçaoBasica)
            {   
                case "1":
                    (x, y) = Operacao.LerDoisNumeros();
                    calc.Somar(x, y);
                    Historico.Add($"{x} + {y} = {x + y}");
                    Operacao.Pausar();
                    break;

                case "2":
                    (x, y) = Operacao.LerDoisNumeros();
                    calc.Subtrair(x, y);
                    Historico.Add($"{x} - {y} = {x - y}");
                    Operacao.Pausar();
                    break;

                case "3":
                    (x, y) = Operacao.LerDoisNumeros();
                    calc.Multiplicacao(x, y);
                    Historico.Add($"{x} X {y} = {x * y}");
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
                    break;
                
                default:
                    Console.WriteLine("Opção inválida.");
                    Operacao.Pausar();
                    break;
        }
        break;

        case "2":
            x = Operacao.LerNumero("Digite a base: ");
            y = Operacao.LerNumero("Digite o expoente: ");
            calc.Potencia(x, y);
            Historico.Add($"{x} elevado a {y} = {Math.Pow(x, y)}");
            Operacao.Pausar();
            break;

        case "3":
            x = Operacao.LerNumero("Digite o número para calcular a raiz quadrada: ");
            calc.RaizQuadrada(x);
            Historico.Add($"A raiz quadrada de {x} é {Math.Sqrt(x)}");
            Operacao.Pausar();
            break;

        case "4":
            Console.WriteLine("Conversão de moedas ainda não implementada.");
            Operacao.Pausar();
            break;
        
        case "5":
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
            Console.WriteLine("Calculadora encerrada.");
            ExibirMenuPrincipal = false;
            break;

        default:
            Console.WriteLine("Opção inválida.");
            Operacao.Pausar();
            break;
    
    }
}