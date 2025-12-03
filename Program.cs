using Calculadora.Models;

Operacao calc = new Operacao();

double x = 0;
double y = 0;
string escolha, OperaçaoBasica, MenuConversao, RealParaMoeda, MoedaParaReal;
bool ExibirMenuPrincipal = true;

List<string> Historico = new List<string>();


Console.WriteLine("Calculadora Simples\n");


while (ExibirMenuPrincipal)
{
Console.Clear();
Console.WriteLine("selecione a opção desejada:");
Console.WriteLine("1 - Operações Matemáticas");
Console.WriteLine("2 - Conversão de Moedas");
Console.WriteLine("3 - Histórico de Operações");
Console.WriteLine("0 - Sair");
escolha = Console.ReadLine()!;

switch (escolha)
    {
        case "1":
        Console.Clear();
        Console.WriteLine("Operações");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Potência");
        Console.WriteLine("6 - Raiz Quadrada");
        Console.WriteLine("0 - Voltar ao menu principal");
        OperaçaoBasica = Console.ReadLine()!;

            switch (OperaçaoBasica)
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
                    Historico.Add($"{x} X {y} = {res3}");
                    Operacao.Pausar();
                    break;

                case "4":
                    (x, y) = Operacao.LerDoisNumeros();
                    if (y == 0)
                        {
                            Console.WriteLine("Erro: Divisão por zero não é permitida digite enter para continuar.");
                            Operacao.Pausar();
                            break;
                        }
                    double res4 = calc.Divisao(x, y);
                    Historico.Add($"{x} / {y} = {res4}");
                    Operacao.Pausar();
                    break;

                case "5":
                    x = Operacao.LerNumero("Digite a base: ");
                    y = Operacao.LerNumero("Digite o expoente: ");
                    double res5 = calc.Potencia(x, y);
                    Historico.Add($"{x} elevado a {y} = {res5}");
                    Operacao.Pausar();
                    break;

                case "6":
                    x = Operacao.LerNumero("Digite o número para calcular a raiz quadrada: ");
                    double res6 = calc.RaizQuadrada(x);
                    Historico.Add($"A raiz quadrada de {x} é {res6}");
                    Operacao.Pausar();
                    break;

                case "0":
                    break;
                
                default:
                    Console.WriteLine("Opção inválida.");
                    Operacao.Pausar();
                    break;
        }
        break;

        case "2":
            Console.Clear();
            Console.WriteLine("Conversão de Moedas");
            Console.WriteLine("1 - Real para alguma moeda");
            Console.WriteLine("2 - Alguma moeda para Real");
            Console.WriteLine("3 - Voltar ao menu principal");
            MenuConversao = Console.ReadLine()!;

            switch (MenuConversao)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Escolha a moeda para converter de Real:");
                    Console.WriteLine("1 - Dólar");
                    Console.WriteLine("2 - Euro");
                    Console.WriteLine("3 - Iene");
                    Console.WriteLine("0 - Voltar");
                    Console.WriteLine("Digite o número correspondente à moeda ou digite 0 para voltar ao menu principal:");
                    MoedaParaReal = Console.ReadLine()!;
                    
                    switch (MoedaParaReal)
                    {
                        case "1":
                        {
                            x = Operacao.LerNumero("Digite o valor em Real: ");
                            decimal convertido = ConverterMoedas.RealparaDolar((decimal)x);
                            Historico.Add($"R$ {x:F2} convertido para Dólar é $ {convertido:F2}");
                            break;
                        }

                        case "2":
                        {
                            x = Operacao.LerNumero("Digite o valor em Real: ");
                            decimal convertido = ConverterMoedas.RealparaEuro((decimal)x);
                            Historico.Add($"R$ {x:F2} convertido para Euro é € {convertido:F2}");
                            break;
                        }
                        case "3":
                        {
                            x = Operacao.LerNumero("Digite o valor em Real: ");
                            decimal convertido = ConverterMoedas.RealparaIene((decimal)x);
                            Historico.Add($"R$ {x:F2} convertido para Iene é ¥ {convertido:F2}");   
                            break;
                        }

                        case "0":
                            break;
                        
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }

                    Operacao.Pausar();
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Escolha a moeda para converter para Real:");
                    Console.WriteLine("1 - Dólar");
                    Console.WriteLine("2 - Euro");
                    Console.WriteLine("3 - Iene");
                    Console.WriteLine("0 - Voltar");
                    Console.WriteLine("Digite o número correspondente à moeda ou digite 0 para voltar ao menu principal:");
                    RealParaMoeda = Console.ReadLine()!;

                    switch (RealParaMoeda)
                    {
                        case "1":
                        {
                            x = Operacao.LerNumero("Digite o valor em Dólar: ");
                            decimal convertido = ConverterMoedas.DolarParaReal((decimal)x);
                            Historico.Add($"$ {x:F2} convertido para Real é R$ {convertido:F2}");
                            break;
                        }
                        case "2":
                        {
                            x = Operacao.LerNumero("Digite o valor em Euro: ");
                            decimal convertido = ConverterMoedas.EuroParaReal((decimal)x);
                            Historico.Add($"€ {x:F2} convertido para Real é R$ {convertido:F2}");
                            break;
                        }
                        case "3":
                        {
                            x = Operacao.LerNumero("Digite o valor em Iene: ");
                            decimal convertido = ConverterMoedas.IeneParaReal((decimal)x);
                            Historico.Add($"¥ {x:F2} convertido para Real é R$ {convertido:F2}");
                            break;
                        }
                        case "0":
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                    Operacao.Pausar();
                    break;

                case "3":
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    Operacao.Pausar();
                    break;
            }
            break;
        
        case "3":
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
                
            }
            Operacao.Pausar();
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