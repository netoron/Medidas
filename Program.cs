using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            string medida;
            double km = 0;
            double soma2;
            
            Console.WriteLine("Digite uma medida em metros para ser convertida em km e cm");
            medida = Console.ReadLine();
            soma2 = Convert.ToDouble(medida); 
            Console.WriteLine($"O Total em km é {km},{medida}Km");
            Console.WriteLine($"O Total em cm é {medida}00cm");


            
        }
    }
}
