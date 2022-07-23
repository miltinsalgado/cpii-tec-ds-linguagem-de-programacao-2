using System;

namespace Questão_20_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 20-Lista 01");

            Console.WriteLine("Entre com os ângulos internos do triângulo");

            double angulo_1 = Convert.ToDouble(Console.ReadLine());
            double angulo_2 = Convert.ToDouble(Console.ReadLine());
            double angulo_3 = Convert.ToDouble(Console.ReadLine());

            if ((angulo_1 == angulo_2) && (angulo_1 == angulo_3))
                Console.WriteLine("O triângulo é equilátero.");
            else if ((angulo_1 == angulo_2) && (angulo_1 != angulo_3))
                Console.WriteLine("O triângulo é isóscele.");
            else
                Console.WriteLine("O triângulo é escaleno.");

            Console.ReadLine();
        }
    }
}
