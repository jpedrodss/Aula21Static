namespace Aula21Static
{
    public class Conversor
    {
        public static float CotacaoDolar = 5.23f;
        public static float CotacaoEuro = 5.88f;
        public static float Valor { get; set; }

        public static float ConverterDolarParaReal(){
            return Valor * CotacaoDolar;
        }
        public static float ConverterEuroParaReal(){
            return Valor * CotacaoEuro;
        }
        public static float ConverterRealParaDolar(){
            return CotacaoDolar / Valor;
        }
        public static float ConverterRealParaEuro(){
            return CotacaoEuro / Valor;
        }
    }
}