using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Operacao
    {
        public static double LerNumero(string mensagem)
        {
            Console.WriteLine(mensagem);
            double valor;
            while (!double.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Entrada inválida. Digite novamente:");
            }
                return valor;
        }
        public static (double x, double y) LerDoisNumeros()
        {
            double x = LerNumero("Digite o primeiro número: ");
            double y = LerNumero("Digite o segundo número: ");
            return (x, y);
        }
        public static void Pausar()
        {
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        public double Somar(double x, double y)
        {
            double resultado = x + y;
            Console.WriteLine($"{x} + {y} = {resultado}");
            return resultado;
        }

        public double Subtrair(double x, double y)
        {
            double resultado = x - y;
            Console.WriteLine($"{x} - {y} = {resultado}");
            return resultado;
        }

        public double Multiplicacao(double x, double y)
        {
            double resultado = x * y;
            Console.WriteLine($"{x} X {y} = {resultado}");
            return resultado;
        }

        public double Divisao(double x, double y)
        {
            double resultado = x / y;
            Console.WriteLine($"{x} / {y} = {resultado}");
            return resultado;
        }

        public double Potencia(double x, double y)
        {
            double resultado = Math.Pow(x, y);
            Console.WriteLine($"{x} elevado a {y} = {resultado}");
            return resultado;
        }

        public double RaizQuadrada(double x)
        {
            double resultado = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é {resultado}");
            return resultado;
        }      
    }
}