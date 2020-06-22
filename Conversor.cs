using System;

namespace Aula21Static
{
    public class Conversor
    {
        public static float CotacaoDolar = 5.23f;
        public static float CotacaoEuro = 5.88f;
        public static float Valor { get; set; }

        public static void ConverterDolarParaReal(){

            System.Console.WriteLine("Digite um valor em reais para ser convertido em dólar:");
            Conversor.Valor = float.Parse(Console.ReadLine());
            float resultado = Valor / CotacaoDolar;
            Console.WriteLine($"Seu valor de R${Valor} de reais convertido em dólar é : U${resultado}\n");

        }
        public static void ConverterEuroParaReal(){

            System.Console.WriteLine("Digite um valor em euros para ser convertido em reais:");
            Conversor.Valor = float.Parse(Console.ReadLine());
            float resultado = Valor / CotacaoEuro;
            Console.WriteLine($"Seu valor de €{Valor} euros convertido em reais é : €{resultado}\n");

        }
        public static void ConverterRealParaDolar(){

            System.Console.WriteLine("Digite um valor em dólar para ser convertido em reais:");
            Conversor.Valor = float.Parse(Console.ReadLine());
            float resultado = Valor * CotacaoDolar;
            Console.WriteLine($"Seu valor de R${Valor} de reais convertido em dólar é : U${resultado}\n");

        }
        public static void ConverterRealParaEuro(){
            
            System.Console.WriteLine("Digite um valor em euros para ser convertido em reais:");
            Conversor.Valor = float.Parse(Console.ReadLine());
            float resultado = Valor * CotacaoEuro;
            Console.WriteLine($"Seu valor de R${Valor} de real convertido em euros é : €{resultado}\n");

        }
    }
}