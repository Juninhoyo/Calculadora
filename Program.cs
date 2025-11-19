int primeiroNumero, segundoNumero;
string operacao;


Console.WriteLine("Escolha a operação (+, -, *, /):");
operacao = Console.ReadLine()!;

Console.WriteLine("Digite o primeiro número:");
primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
segundoNumero = Convert.ToInt32(Console.ReadLine());

if (operacao == "+")
{
    Console.WriteLine($"Resultado: {primeiroNumero + segundoNumero}");
}
else if (operacao == "-")
{
    Console.WriteLine($"Resultado: {primeiroNumero - segundoNumero}");
}
else if (operacao == "*")
{
    Console.WriteLine($"Resultado: {primeiroNumero * segundoNumero}");
}
else if (operacao == "/")
{
    if (segundoNumero != 0)
    {
        Console.WriteLine($"Resultado: {primeiroNumero / segundoNumero}");
    }
    else
    {
        Console.WriteLine("Erro: Divisão por zero não é permitida.");
    }
}
else
{
    Console.WriteLine("Operação inválida.");
}