using System;

namespace Aula21Static
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um valor para ser convertido:");
            Conversor.Valor = float.Parse(Console.ReadLine());
            Console.WriteLine( $"Seu valor de R${Conversor.Valor} de reais convertido em dólar é : U${Conversor.ConverterDolarParaReal()}" );
        }
    }
}
