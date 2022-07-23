using System;

namespace Questão_09_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 09-Lista 01");

            Console.WriteLine("Digite um número inteiro para verificação de paridade:\t");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine(num + " É um número par.");
            else 
                Console.WriteLine(num + " É um número ímpar.");

            Console.ReadLine();
        }
    }
}
