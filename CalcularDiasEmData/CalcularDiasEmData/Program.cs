using System;

namespace CalcularDiasEmData
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CalcularDiasEmData(1101);

            Console.ReadKey();
        }

        public static void CalcularDiasEmData(long dias)
        {            
            TimeSpan tempoCalculado = TimeSpan.FromDays(dias);
            DateTime dataCalculada = new DateTime(tempoCalculado.Ticks);
            Console.WriteLine("Tempo desde o Inicio: {0} Ano(s), {1} Mes(es), {2} dia(s)", dataCalculada.Year-1, dataCalculada.Month-1, dataCalculada.Day-1);
            
        }
    }
}
