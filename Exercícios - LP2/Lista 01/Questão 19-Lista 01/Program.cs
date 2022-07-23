using System;

namespace Questão_19_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 19-Lista 01");

            Console.WriteLine("Entre com um ângulo do triângulo:\t");
            double angulo_1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com outro ângulo do triângulo:\t");
            double angulo_2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com mais um ângulo do triângulo:\t");
            double angulo_3 = Convert.ToDouble(Console.ReadLine());

            double soma_angulos = angulo_1 + angulo_2 + angulo_3;

            if (soma_angulos != 180)
                Console.WriteLine("O triângulo não é válido.");
            else
                Console.WriteLine("O triângulo é válido.");

            Console.ReadLine();
        }
    }
}
