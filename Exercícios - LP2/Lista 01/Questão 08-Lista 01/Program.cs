using System;

namespace Questão_08_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 08-Lista 01");

            Console.WriteLine("Digite um número inteiro:\t");
            int num_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro:\t");
            int num_2 = Convert.ToInt32(Console.ReadLine());

            if (num_1==num_2)
                Console.WriteLine("Os números "+ num_1 + " e "+ num_2+ " são iguais.");
            else
                Console.WriteLine("Os números " + num_1 + " e " + num_2 + " são diferentes.");

            Console.ReadLine();
        }
    }
}
