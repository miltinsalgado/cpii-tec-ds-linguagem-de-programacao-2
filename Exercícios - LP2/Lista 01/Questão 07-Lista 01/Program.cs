using System;

namespace Questão_07_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 07-Lista 01");

            Console.WriteLine("Entre com um ângulo do triângulo (em Graus)");
            double ang_1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com um outro ângulo do triângulo (em Graus)");
            double ang_2 = Convert.ToDouble(Console.ReadLine());

            double ang_3 = 180 - (ang_1 + ang_2);
            Console.WriteLine("O terceiro ângulo do triângulo com os outros dois ângulos iguais a " + ang_1 + " graus e " + ang_2 + " graus mede " + ang_3 + " graus.");
            
            Console.ReadLine();
        }
    }
}
