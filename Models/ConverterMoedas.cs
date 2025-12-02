using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class ConverterMoedas
    {
        private static Dictionary<string, decimal> cotacoes = new()
        {
            {"Dolar", 5.35m},
            {"Euro", 6.20m},
            {"Iene", 0.034m}
        };
        public static decimal DolarParaReal(decimal valor)
        {
            decimal convertido = valor * cotacoes["Dolar"];
            Console.WriteLine($"$ {valor:F2} convertido para Real é R$ {convertido:F2}");
            return convertido;;
        }
        public static decimal RealparaDolar(decimal valor)
        {
            decimal convertido = valor / cotacoes["Dolar"];
            Console.WriteLine($"R$ {valor:F2} convertido para Dólar é $ {convertido:F2}");
            return convertido;
        }
        public static decimal EuroParaReal(decimal valor)
        {
            decimal convertido = valor * cotacoes["Euro"];
            Console.WriteLine($"€ {valor:F2} convertido para Real é R$ {convertido:F2}");
            return convertido;
        }
        public static decimal RealparaEuro(decimal valor)
        {
            decimal convertido = valor / cotacoes["Euro"];
            Console.WriteLine($"R$ {valor:F2} convertido para Euro é € {convertido:F2}");
            return convertido;
        }
        public static decimal IeneParaReal(decimal valor)
        {
            decimal convertido = valor * cotacoes["Iene"];
            Console.WriteLine($"¥ {valor:F2} convertido para Real é R$ {convertido:F2}");
            return convertido;
        }
        public static decimal RealparaIene(decimal valor)
        {
            decimal convertido = valor / cotacoes["Iene"];
            Console.WriteLine($"R$ {valor:F2} convertido para Iene é ¥ {convertido:F2}");
            return convertido;
        }
    }
}